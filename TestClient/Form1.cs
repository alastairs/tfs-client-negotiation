using System;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.TeamFoundation;
using Microsoft.TeamFoundation.VersionControl.Client;
using ModernTfsClient;
using TfsClientAbstraction;
using TfsLegacyClient;

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
            IWorkspace workspace;

            try
            {
                busyGif.Show();
                ITeamFoundationServerClient tfsClient = await ConnectToTfs(new Uri(tfsServerToConnectTo.SelectedValue.ToString()));
                workspace = await CreateTfsWorkspace(tfsClient, workspaceName.Text);
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

            MessageBox.Show(string.Format("Workspace '{0}' successfully created on TFS version {1}", workspace.DisplayName, @"TO BE COMPLETED"));
        }

        private async Task<ITeamFoundationServerClient> ConnectToTfs(Uri uri)
        {
            var credentials = new NetworkCredential("TfsAdmin", "T3@m5erver", "TESTNET");

            ITeamFoundationServerClient tfsClient = IsLegacyTfsServer() ? (ITeamFoundationServerClient) new LegacyTfsClient()
                                                                        : new TfsClient();

            await Task.Run(() => tfsClient.Connect(uri, credentials));
            return tfsClient;
        }

        private static async Task<IWorkspace> CreateTfsWorkspace(ITeamFoundationServerClient tfsClient, string workspaceName)
        {
            return await Task.Run(() => tfsClient.CreateWorkspace(workspaceName));
        }

        private bool IsLegacyTfsServer()
        {
            return tfsServerToConnectTo.SelectedIndex == 0 || tfsServerToConnectTo.SelectedIndex == 1;
        }

        private void HandleException(string message)
        {
            busyGif.Hide();
            MessageBox.Show(message, @"TFS Test Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
