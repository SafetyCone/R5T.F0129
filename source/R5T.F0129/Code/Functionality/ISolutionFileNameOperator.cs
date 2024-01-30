using System;

using R5T.T0132;
using R5T.T0172;
using R5T.T0172.Extensions;
using R5T.T0180;
using R5T.T0180.Extensions;
using R5T.T0187;


namespace R5T.F0129
{
    [FunctionalityMarker]
    public partial interface ISolutionFileNameOperator : IFunctionalityMarker
    {
        public IFileNameStem Get_SolutionFileNameStem(ISolutionName solutionName)
        {
            // The solution file name stem is just the solution name.
            var candidateFileNameStem = solutionName.Value;

            // Ensure the the file name stem is valid as a file name.
            var output = Instances.FileNameOperator.Ensure_IsValid(candidateFileNameStem)
                .ToFileNameStem();

            return output;
        }

        public ISolutionFileName Get_SolutionFileName(ISolutionName solutionName)
        {
            var solutionFileNameStem = this.Get_SolutionFileNameStem(solutionName);

            var output = Instances.FileExtensionOperator.Get_FileName(
                solutionFileNameStem.Value,
                Instances.FileExtensions.SolutionFile.Value)
                .ToSolutionFileName();

            return output;
        }
    }
}
