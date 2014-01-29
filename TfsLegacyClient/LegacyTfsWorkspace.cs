using System;
using Microsoft.TeamFoundation.VersionControl.Client;
using TfsClientAbstraction;

namespace TfsLegacyClient
{
    public class LegacyTfsWorkspace : IWorkspace
    {
        private readonly Workspace tfsWorkspace;

        public LegacyTfsWorkspace(Workspace tfsWorkspace)
        {
            if (tfsWorkspace == null) throw new ArgumentNullException("tfsWorkspace");
            this.tfsWorkspace = tfsWorkspace;
        }

        public string DisplayName
        {
            get { return tfsWorkspace.DisplayName; }
        }
    }
}
