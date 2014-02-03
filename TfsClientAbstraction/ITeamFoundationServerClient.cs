using System;
using System.Net;

namespace TfsClientAbstraction
{
    public interface ITeamFoundationServerClient : ITeamFoundationServerVersion
    {
        void Connect(Uri uri, ICredentials credentials);
        IWorkspace CreateWorkspace(string workspaceName);
    }
}
