using System;

using R5T.T0132;
using R5T.T0180;
using R5T.T0180.Extensions;
using R5T.T0187;


namespace R5T.F0129
{
    [FunctionalityMarker]
    public partial interface ISolutionDirectoryNameOperator : IFunctionalityMarker
    {
        public IDirectoryName Get_SolutionDirectoryName(ISolutionName solutionName)
        {
            // The solution file name stem is just the solution name.
            var candidateDirectoryName = solutionName.Value;

            // Ensure the the file name stem is valid as a file name.
            var output = Instances.DirectoryNameOperator.Ensure_IsValid(candidateDirectoryName)
                .ToDirectoryName();

            return output;
        }
    }
}
