using Microsoft.TeamFoundation.Build.Client;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.VersionControl.Client;
using System;
using System.Net;
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

        public TfsVersions GetServerVersion()
        {
            var buildServer = (IBuildServer)tfsServer.GetService((typeof(IBuildServer)));
            return ConvertBuildServerVersionToTfsVersion(buildServer.BuildServerVersion);
        }

        private TfsVersions ConvertBuildServerVersionToTfsVersion(BuildServerVersion buildServerVersion)
        {
            switch (buildServerVersion)
            {
                case BuildServerVersion.V1:
                    return TfsVersions.Tfs2005;
                case BuildServerVersion.V2:
                    return TfsVersions.Tfs2008;
                default:
                    throw new TfsException(string.Format("Unknown TFS Server version '{0}'.", buildServerVersion));
            }
        }
    }
}
