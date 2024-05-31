using System;


namespace R5T.F0129
{
    public static class Instances
    {
        public static F0124.IDirectoryNameOperator DirectoryNameOperator => F0124.DirectoryNameOperator.Instance;
        public static F0000.IFileExtensionOperator FileExtensionOperator => F0000.FileExtensionOperator.Instance;
        public static Z0072.Z004.IFileExtensions FileExtensions => Z0072.Z004.FileExtensions.Instance;
        public static F0124.IFileNameOperator FileNameOperator => F0124.FileNameOperator.Instance;
        public static F0002.IPathOperator PathOperator => F0002.PathOperator.Instance;
        public static IProjectDirectoryNameOperator ProjectDirectoryNameOperator => F0129.ProjectDirectoryNameOperator.Instance;
        public static F0130.IProjectNameConventions ProjectNameConventions => F0130.ProjectNameConventions.Instance;
        public static ISolutionDirectoryNameOperator SolutionDirectoryNameOperator => F0129.SolutionDirectoryNameOperator.Instance;
        public static ISolutionFileNameOperator SolutionFileNameOperator => F0129.SolutionFileNameOperator.Instance;
    }
}