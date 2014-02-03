using Microsoft.TeamFoundation.Build.Client;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.Framework.Common;
using Microsoft.TeamFoundation.VersionControl.Client;
using System;
using System.Net;
using TfsClientAbstraction;

namespace ModernTfsClient
{
    public class TfsClient : ITeamFoundationServerClient
    {
        private TfsTeamProjectCollection tfsServer;

        public void Connect(Uri uri, ICredentials credentials)
        {
            tfsServer = new TfsTeamProjectCollection(uri, new TfsClientCredentials(new WindowsCredential(credentials)));
            tfsServer.Connect(ConnectOptions.None);
        }

        public IWorkspace CreateWorkspace(string workspaceName)
        {
            var vcs = tfsServer.GetService<VersionControlServer>();
            return new TfsWorkspace(vcs.CreateWorkspace(workspaceName));
        }

        public TfsVersions GetServerVersion()
        {
            var vcs = tfsServer.GetService<IBuildServer>();
            return ConvertBuildServerVersionToTfsVersion(vcs.BuildServerVersion);
        }

        private TfsVersions ConvertBuildServerVersionToTfsVersion(BuildServerVersion buildServerVersion)
        {
            switch (buildServerVersion)
            {
                case BuildServerVersion.V1:
                    return TfsVersions.Tfs2005;
                case BuildServerVersion.V2:
                    return TfsVersions.Tfs2008;
                case BuildServerVersion.V3:
                    return TfsVersions.Tfs2010;
                case BuildServerVersion.V4:
                    return TfsVersions.Tfs2012;
                case BuildServerVersion.V5:
                    return TfsVersions.Tfs2013;
                default:
                    throw new TfsException(string.Format("Unknown TFS Server version '{0}'.", buildServerVersion));
            }

        }
    }
}
