using System;

using R5T.T0132;
using R5T.T0172;
using R5T.T0172.Extensions;
using R5T.T0180;
using R5T.T0187;
using R5T.T0187.Extensions;


namespace R5T.F0129
{
    [FunctionalityMarker]
    public partial interface ISolutionPathsOperator : IFunctionalityMarker
    {
        public ISolutionName Get_SolutionName(ISolutionFilePath solutionFilePath)
        {
            var fileNameStem = Instances.PathOperator.Get_FileNameStem(solutionFilePath.Value);

            // The solution name is just the file name stem.
            var output = fileNameStem.ToSolutionName();
            return output;
        }

        public ISolutionDirectoryPath Get_SolutionDirectoryPath(
            IDirectoryPath solutionDirectoryParentDirectoryPath,
            ISolutionName solutionName)
        {
            var solutionDirectoryName = Instances.SolutionDirectoryNameOperator.Get_SolutionDirectoryName(solutionName);

            var output = this.Get_SolutionDirectoryPath(
                solutionDirectoryParentDirectoryPath,
                solutionDirectoryName);

            return output;
        }

        public ISolutionDirectoryPath Get_SolutionDirectoryPath(
            IDirectoryPath solutionDirectoryParentDirectoryPath,
            IDirectoryName solutionDirectoryName)
        {
            var output = Instances.PathOperator.Combine(
                solutionDirectoryParentDirectoryPath.Value,
                solutionDirectoryName.Value)
                .ToSolutionDirectoryPath();

            return output;
        }

        public ISolutionDirectoryPath Get_SolutionDirectoryPath(ISolutionFilePath solutionFilePath)
        {
            var output = Instances.PathOperator.Get_ParentDirectoryPath_ForFile(
                solutionFilePath.Value)
                .ToSolutionDirectoryPath();

            return output;
        }

        public ISolutionFilePath Get_SolutionFilePath(
            ISolutionDirectoryPath solutionDirectoryPath,
            ISolutionName solutionName)
        {
            var solutionFileName = Instances.SolutionFileNameOperator.Get_SolutionFileName(solutionName);

            var output = Instances.PathOperator.Get_FilePath(
                solutionDirectoryPath.Value,
                solutionFileName.Value)
                .ToSolutionFilePath();

            return output;
        }

        public ISolutionFilePath Get_SolutionFilePath(
            IDirectoryPath solutionDirectoryParentDirectoryPath,
            ISolutionName solutionName)
        {
            var solutionDirectoryPath = this.Get_SolutionDirectoryPath(
                solutionDirectoryParentDirectoryPath,
                solutionName);

            var solutionFilePath = this.Get_SolutionFilePath(
                solutionDirectoryPath,
                solutionName);

            return solutionFilePath;
        }
    }
}
