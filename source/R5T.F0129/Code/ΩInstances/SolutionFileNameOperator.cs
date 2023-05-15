using System;


namespace R5T.F0129
{
    public class SolutionFileNameOperator : ISolutionFileNameOperator
    {
        #region Infrastructure

        public static ISolutionFileNameOperator Instance { get; } = new SolutionFileNameOperator();


        private SolutionFileNameOperator()
        {
        }

        #endregion
    }
}
