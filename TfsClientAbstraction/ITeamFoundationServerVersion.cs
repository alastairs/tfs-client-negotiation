namespace TfsClientAbstraction
{
    public enum TfsVersions
    {
        Tfs2005,
        Tfs2008,
        Tfs2010,
        Tfs2012,
        Tfs2013
    }

    public interface ITeamFoundationServerVersion
    {
        TfsVersions GetServerVersion();
    }
}