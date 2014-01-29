using System;
using Microsoft.TeamFoundation.VersionControl.Client;
using TfsClientAbstraction;

namespace ModernTfsClient
{
    public class TfsWorkspace : IWorkspace
    {
        private readonly Workspace tfsWorkspace;

        public TfsWorkspace(Workspace tfsWorkspace)
        {
            if (tfsWorkspace == null) throw new ArgumentNullException("tfsWorkspace");
            this.tfsWorkspace = tfsWorkspace;
        }

        public string DisplayName { get { return tfsWorkspace.DisplayName; } }
    }
}
