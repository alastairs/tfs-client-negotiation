using System;
using System.Net;

namespace TfsClientAbstraction
{
    public interface ITeamFoundationServerClient
    {
        void Connect(Uri uri, ICredentials credentials);
        IWorkspace CreateWorkspace(string workspaceName);
    }
}
