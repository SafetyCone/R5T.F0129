using System;


namespace R5T.F0129
{
    public class ProjectDirectoryNameOperator : IProjectDirectoryNameOperator
    {
        #region Infrastructure

        public static IProjectDirectoryNameOperator Instance { get; } = new ProjectDirectoryNameOperator();


        private ProjectDirectoryNameOperator()
        {
        }

        #endregion
    }
}
