using System;


namespace R5T.F0129
{
    public static class Instances
    {
        public static F0000.IFileExtensionOperator FileExtensionOperator => F0000.FileExtensionOperator.Instance;
        public static Z0044.Z001.IFileExtensions FileExtensions => Z0044.Z001.FileExtensions.Instance;
        public static F0124.IFileNameOperator FileNameOperator => F0124.FileNameOperator.Instance;
        public static F0002.IPathOperator PathOperator => F0002.PathOperator.Instance;
        public static F0130.IProjectNameConventions ProjectNameConventions => F0130.ProjectNameConventions.Instance;
        public static ISolutionFileNameOperator SolutionFileNameOperator => F0129.SolutionFileNameOperator.Instance;
    }
}