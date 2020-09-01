using System;
using System.Collections.Generic;
using System.Drawing;
using System.ComponentModel;
using SpotifyAPI.Web;
using SpotifyAPI.Web.Enums;
using SpotifyAPI.Web.Models;
using SpotifyAPI.Web.Auth;
using System.Windows.Forms;

namespace Spotify_Toolkit
{
    public partial class Form1 : Form
    {
        SpotifyWebAPI _spotify;
        PrivateProfile privateProfile;
        List<SimplePlaylist> userPlaylists;
        private bool nameTyped;
        private string generatedName;

        public Form1()
        {
            InitializeComponent();
            getProfile();
        }

        /// <summary>
        /// starts authentication process
        /// </summary>
        public void getProfile()
        {
            ImplicitGrantAuth auth = new ImplicitGrantAuth("5349838ba8c54428a41ffc17eac1111b", "http://localhost:8888", "http://localhost:8888", Scope.PlaylistModifyPublic);
            auth.AuthReceived += async (sender, payload) =>
            {
                auth.Stop();
                _spotify = new SpotifyWebAPI()
                {
                    TokenType = payload.TokenType,
                    AccessToken = payload.AccessToken
                };
                Invoke(new MethodInvoker(delegate { buildPanel(); }));
            };
            auth.Start();
            auth.OpenBrowser();
        }

        /// <summary>
        /// fills up the Panel and initiates global variables
        /// </summary>
        private void buildPanel()
        {
            //ReversePlaylist//////////////////////////////////////////////////////////////
            privateProfile = _spotify.GetPrivateProfile();
            lblProfileDisplayName.Text = privateProfile.DisplayName;
            userPlaylists = new List<SimplePlaylist>();
            int i = 0;
            while (i == userPlaylists.Count)
            {
                userPlaylists.AddRange(_spotify.GetUserPlaylists(privateProfile.Id, 50, i).Items);
                i += 50;
            }
            foreach (SimplePlaylist spList in userPlaylists)
            {
                cobxReverse.Items.Add(spList.Name);
            }
            //MessageBox.Show(playlists[1].Name);
            pnlProfile.Visible = true;
        }

        /// <summary>
        /// Reverses the playlist
        /// </summary>
        /// <param name="playlist"></param> The Playlist
        /// <param name="createNewPlaylist"></param> Wether or not a new playlist is to be created
        private void ReversePlaylist(SimplePlaylist playlist, bool createNewPlaylist)
        {
            pbrReverse.Value = 0;
            pbrReverse.Visible = true;
            pbrReverse.Maximum = playlist.Tracks.Total;
            if (createNewPlaylist)
            {
                Paging<PlaylistTrack> paging = new Paging<PlaylistTrack>();
                for (int i = 0; i < playlist.Tracks.Total; i += 100)
                {
                    paging = _spotify.GetPlaylistTracks(playlist.Id, "", 100, i);
                }

                BackgroundWorker bgw = new BackgroundWorker();
                bgw.WorkerReportsProgress = false;
                bgw.DoWork += (sender, e) =>
                {
                    FullPlaylist newPlaylist = _spotify.CreatePlaylist(_spotify.GetPrivateProfile().Id, tbxNewName.Text, true);
                    for (int i = playlist.Tracks.Total - 1; i >= 0; i--)
                    {
                        _spotify.AddPlaylistTrack(newPlaylist.Id, paging.Items[i].Track.Uri);
                        Invoke(new MethodInvoker(delegate { progressBarStep(pbrReverse); }));
                    }
                    Invoke(new MethodInvoker(delegate
                    {
                        pbrReverse.Visible = false;
                        pbrReverse.Value = 0;
                    }));
                };
                bgw.RunWorkerAsync();
            }
            else
            {
                for(int i = 0; i < playlist.Tracks.Total; i++)
                {
                    _spotify.ReorderPlaylist(playlist.Id, i, 0);
                }
            }
        }

        /// <summary>
        /// performs clean progressbar step
        /// </summary>
        /// <param name="pbr"></param> progressbar to perform step
        private static void progressBarStep(ProgressBar pbr)
        {
            bool modified = false;
            if (pbr.Value + 2 > pbr.Maximum)
            {
                pbr.Maximum = pbr.Value + 2;
                modified = true;
            }
            pbr.Value = pbr.Value + 2;
            pbr.Value = pbr.Value - 1;
            if (modified) pbr.Maximum = pbr.Maximum - 2;
        }

        //Buttons----------------------------------------------------------------------------------------------------------------------------
        private void btnReverse_Click(object sender, EventArgs e)
        {
            ReversePlaylist(userPlaylists[cobxReverse.SelectedIndex], cbxNewPlaylist.Checked);
        }

        private void cobxReverse_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!nameTyped)
            {
                tbxNewName.Text = userPlaylists[cobxReverse.SelectedIndex].Name + " - REV";
                nameTyped = false;
            }
        }

        private void cbxNewPlaylist_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxNewPlaylist.Checked)
            {
                tbxNewName.Enabled = true;
                tbxNewName.ForeColor = nameTyped ? SystemColors.WindowText : SystemColors.ControlDarkDark;
                lblName.Enabled = true;
            }
            else
            {
                tbxNewName.ForeColor = SystemColors.Window;
                tbxNewName.ReadOnly = false;
                lblName.Enabled = false;
            }
        }

        private void tbxNewName_TextChanged(object sender, EventArgs e)
        {
            nameTyped = true;
        }

        private void tbxNewName_Enter(object sender, EventArgs e)
        {
            generatedName = tbxNewName.Text;
            tbxNewName.Text = "";
            nameTyped = false;
            tbxNewName.ForeColor = SystemColors.WindowText;
        }

        private void tbxNewName_Leave(object sender, EventArgs e)
        {
            if (!nameTyped)
            {
                tbxNewName.ForeColor = SystemColors.ControlDark;
                tbxNewName.Text = generatedName;
            }
        }
    }
}
