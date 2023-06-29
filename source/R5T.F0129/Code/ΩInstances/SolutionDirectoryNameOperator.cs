using System;


namespace R5T.F0129
{
    public class SolutionDirectoryNameOperator : ISolutionDirectoryNameOperator
    {
        #region Infrastructure

        public static ISolutionDirectoryNameOperator Instance { get; } = new SolutionDirectoryNameOperator();


        private SolutionDirectoryNameOperator()
        {
        }

        #endregion
    }
}
