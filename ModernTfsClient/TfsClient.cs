using System;
using System.Net;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.Framework.Common;
using Microsoft.TeamFoundation.VersionControl.Client;
using TfsClientAbstraction;

namespace ModernTfsClient
{
    public class TfsClient : ITeamFoundationServerClient
    {
        private TfsTeamProjectCollection tfsServer;

        public void Connect(Uri uri, ICredentials credentials)
        {
            tfsServer = new TfsTeamProjectCollection(uri,
                                                     new TfsClientCredentials(
                                                         new WindowsCredential(
                                                             credentials)));

            tfsServer.Connect(ConnectOptions.None);
        }

        public IWorkspace CreateWorkspace(string workspaceName)
        {
            var vcs = tfsServer.GetService<VersionControlServer>();
            return new TfsWorkspace(vcs.CreateWorkspace(workspaceName));
        }
    }
}
