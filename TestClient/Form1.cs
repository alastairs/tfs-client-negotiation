using System;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.TeamFoundation;
using Microsoft.TeamFoundation.Build.Client;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.Framework.Common;
using Microsoft.TeamFoundation.VersionControl.Client;

namespace TestClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            tfsServerBindingSource.Add(new TfsServer("TFS 2005 SP1", "http://soc-tfs-2005sp1.testnet.red-gate.com:8080/"));
            tfsServerBindingSource.Add(new TfsServer("TFS 2008 SP1", "http://soc-tfs-2008sp1.testnet.red-gate.com:8080/"));
            tfsServerBindingSource.Add(new TfsServer("TFS 2010", "http://soc-tfs-2010rtm.testnet.red-gate.com:8080/tfs/SQLSourceControlCollection"));
            tfsServerBindingSource.Add(new TfsServer("TFS 2012", "http://soc-tfs-2012rtm.testnet.red-gate.com:8080/tfs/"));
            tfsServerBindingSource.Add(new TfsServer("TFS 2013", "http://soc-tfs-2013rtm.testnet.red-gate.com:8080/tfs/"));
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            IBuildServer buildServer;
            Workspace workspace;

            try
            {
                busyGif.Show();
                buildServer = await ConnectToTfs(new Uri(tfsServerToConnectTo.SelectedValue.ToString()));
                workspace = await CreateTfsWorkspace(buildServer, workspaceName.Text);
                busyGif.Hide();
            }
            catch (WorkspaceExistsException)
            {
                HandleException(string.Format("Workspace '{0}' already exists!", workspaceName.Text));
                return;
            }
            catch (TeamFoundationClientVersionCheckException)
            {
                HandleException(
                    string.Format("Cannot connect to TFS server '{0}' using the {1} version of the client libraries",
                        tfsServerToConnectTo.SelectedValue, "2013"));

                return;
            }

            MessageBox.Show(string.Format("Workspace '{0}' successfully created on TFS version {1}", workspace.DisplayName, buildServer.BuildServerVersion));
        }

        private async Task<IBuildServer> ConnectToTfs(Uri uri)
        {
            var credentials = new NetworkCredential("TfsAdmin", "T3@m5erver", "TESTNET");
            
            if (tfsServerToConnectTo.SelectedIndex == 0 || tfsServerToConnectTo.SelectedIndex == 1)
            {
                var tfsServer = new TeamFoundationServer(uri, credentials);
                return await Task.Run(() => tfsServer.GetService<IBuildServer>());
            }
            else
            {
                var tfsServer = new TfsTeamProjectCollection(
                    uri,
                    new TfsClientCredentials(
                        new WindowsCredential(
                            credentials)));

                await Task.Run(() => tfsServer.Connect(ConnectOptions.None));
                return await Task.Run(() => tfsServer.GetService<IBuildServer>());
            }
        }

        private async Task<Workspace> CreateTfsWorkspace(IBuildServer buildServer, string workspaceName)
        {
            var vcs = await Task.Run(() => buildServer.TeamProjectCollection.GetService<VersionControlServer>());
            return await Task.Run(() => vcs.CreateWorkspace(workspaceName));
        }

        private void HandleException(string message)
        {
            busyGif.Hide();
            MessageBox.Show(message, @"TFS Test Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
