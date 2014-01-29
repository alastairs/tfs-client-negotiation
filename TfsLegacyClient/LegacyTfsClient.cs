using System;
using System.Net;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.VersionControl.Client;
using TfsClientAbstraction;

namespace TfsLegacyClient
{
    public class LegacyTfsClient : ITeamFoundationServerClient
    {
        private TeamFoundationServer tfsServer;

        public void Connect(Uri uri, ICredentials credentials)
        {
            tfsServer = new TeamFoundationServer(uri.ToString(), credentials);
        }

        public IWorkspace CreateWorkspace(string workspaceName)
        {
            var vcs = (VersionControlServer)tfsServer.GetService(typeof(VersionControlServer));
            return new LegacyTfsWorkspace(vcs.CreateWorkspace(workspaceName));
        }
    }
}
