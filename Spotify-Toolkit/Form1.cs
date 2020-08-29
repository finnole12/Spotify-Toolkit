using System;
using System.Collections.Generic;
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
            ImplicitGrantAuth auth = new ImplicitGrantAuth("5349838ba8c54428a41ffc17eac1111b", "http://localhost:8888", "http://localhost:8888", Scope.UserLibraryModify);
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
            if (createNewPlaylist)
            {
                pbrReverse.Value = 0;
                pbrReverse.Visible = true;
                Paging<PlaylistTrack> paging = new Paging<PlaylistTrack>();
                for (int i = 0; i < playlist.Tracks.Total; i += 100)
                {
                    paging = _spotify.GetPlaylistTracks(playlist.Id, "", 100, i);
                }
                pbrReverse.Maximum = playlist.Tracks.Total;

                BackgroundWorker bgw = new BackgroundWorker();
                bgw.WorkerReportsProgress = false;
                bgw.DoWork += (sender, e) =>
                {
                    FullPlaylist newPlaylist = _spotify.CreatePlaylist(_spotify.GetPrivateProfile().Id, playlist.Name + " - REV", false);
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
        }

        /// <summary>
        /// performs clean progressbar step
        /// </summary>
        /// <param name="pbr"></param> progressbar to perform step
        private static void progressBarStep(ProgressBar pbr)
        {
            Boolean modified = false;
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
    }
}
