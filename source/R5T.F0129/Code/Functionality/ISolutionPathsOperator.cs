using System;

using R5T.T0132;
using R5T.T0172;
using R5T.T0172.Extensions;
using R5T.T0187;
using R5T.T0187.Extensions;


namespace R5T.F0129
{
    [FunctionalityMarker]
    public partial interface ISolutionPathsOperator : IFunctionalityMarker
    {
        public ISolutionName Get_SolutionName(ISolutionFilePath solutionFilePath)
        {
            var fileNameStem = Instances.PathOperator.GetFileNameStem(solutionFilePath.Value);

            // The solution name is just the file name stem.
            var output = fileNameStem.ToSolutionName();
            return output;
        }

        public ISolutionDirectoryPath Get_SolutionDirectoryPath(ISolutionFilePath solutionFilePath)
        {
            var output = Instances.PathOperator.GetParentDirectoryPath_ForFile(
                solutionFilePath.Value)
                .ToSolutionDirectoryPath();

            return output;
        }

        public ISolutionFilePath Get_SolutionFilePath(
            ISolutionDirectoryPath solutionDirectoryPath,
            ISolutionName solutionName)
        {
            var solutionFileName = Instances.SolutionFileNameOperator.Get_SolutionFileName(solutionName);

            var output = Instances.PathOperator.GetFilePath(
                solutionDirectoryPath.Value,
                solutionFileName.Value)
                .ToSolutionFilePath();

            return output;
        }
    }
}
