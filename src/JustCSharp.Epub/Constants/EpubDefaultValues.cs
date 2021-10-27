using System.Reflection;

namespace JustCSharp.Epub.Constants
{
    public static class EpubDefaultValues
    {
        public const int BufferSize = 4096;
        
        public static readonly BindingFlags SearchPropertyFlags = BindingFlags.Instance | BindingFlags.Public |
                                                                  BindingFlags.NonPublic | BindingFlags.FlattenHierarchy;
    }
}