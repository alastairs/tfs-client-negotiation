using ModernTfsClient;
using System;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
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

            ITeamFoundationServerClient tfsClient;
            try
            {
                busyGif.Show();
                tfsClient = await ConnectToTfs(new Uri(tfsServerToConnectTo.SelectedValue.ToString()));
                workspace = await CreateTfsWorkspace(tfsClient, workspaceName.Text);
            }
            catch (TfsException ex)
            {
                MessageBox.Show(ex.Message, @"TFS Test Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                busyGif.Hide();
            }

            MessageBox.Show(string.Format("Workspace '{0}' successfully created on TFS version {1}", workspace.DisplayName, tfsClient.GetServerVersion()));
        }

        private async Task<ITeamFoundationServerClient> ConnectToTfs(Uri uri)
        {
            var credentials = new NetworkCredential("TfsAdmin", "T3@m5erver", "TESTNET");

            ITeamFoundationServerClient tfsClient = new ExceptionHandlingTfsClient(IsLegacyTfsServer() ? (ITeamFoundationServerClient)new LegacyTfsClient()
                                                                                                       : new TfsClient());

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

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
