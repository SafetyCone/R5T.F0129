using System;


namespace R5T.F0129
{
    public class SolutionPathsOperator : ISolutionPathsOperator
    {
        #region Infrastructure

        public static ISolutionPathsOperator Instance { get; } = new SolutionPathsOperator();


        private SolutionPathsOperator()
        {
        }

        #endregion
    }
}
