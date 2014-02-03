using Microsoft.TeamFoundation;
using Microsoft.TeamFoundation.VersionControl.Client;
using System;
using System.Net;

namespace TfsClientAbstraction
{
    public class ExceptionHandlingTfsClient : ITeamFoundationServerClient
    {
        private readonly ITeamFoundationServerClient wrappedClient;

        public ExceptionHandlingTfsClient(ITeamFoundationServerClient wrappedClient)
        {
            if (wrappedClient == null)
            {
                throw new ArgumentNullException("wrappedClient");
            }

            this.wrappedClient = wrappedClient;
        }

        public void Connect(Uri uri, ICredentials credentials)
        {
            try
            {
                wrappedClient.Connect(uri, credentials);
            }
            catch (TeamFoundationClientVersionCheckException ex)
            {
                throw new TfsException(string.Format("Cannot connect to TFS server '{0}'. The client library in use is not supported for use with your server", uri), ex);
            }
        }

        public IWorkspace CreateWorkspace(string workspaceName)
        {
            try
            {
                return wrappedClient.CreateWorkspace(workspaceName);
            }
            catch (WorkspaceExistsException ex)
            {
                throw new TfsException(string.Format("Workspace '{0}' already exists!", workspaceName), ex);
            }
        }

        public TfsVersions GetServerVersion()
        {
            return wrappedClient.GetServerVersion();
        }
    }
}
