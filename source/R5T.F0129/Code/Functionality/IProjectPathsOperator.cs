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
    public partial interface IProjectPathsOperator : IFunctionalityMarker
    {
        public IProjectDirectoryPath Get_ProjectDirectoryPath(
            IDirectoryPath projectDirectoryParentDirectoryPath,
            IProjectName projectName)
        {
            var projectDirectoryName = Instances.ProjectDirectoryNameOperator.Get_ProjectDirectoryName(projectName);

            var output = this.Get_ProjectDirectoryPath(
                projectDirectoryParentDirectoryPath,
                projectDirectoryName);

            return output;
        }

        public IProjectDirectoryPath Get_ProjectDirectoryPath(
            IDirectoryPath projectDirectoryParentDirectoryPath,
            IDirectoryName projectDirectoryName)
        {
            var output = Instances.PathOperator.Combine(
                projectDirectoryParentDirectoryPath.Value,
                projectDirectoryName.Value)
                .ToProjectDirectoryPath();

            return output;
        }

        public IProjectDirectoryPath Get_ProjectDirectoryPath(IProjectFilePath projectFilePath)
        {
            var output = Instances.PathOperator.GetParentDirectoryPath_ForFile(projectFilePath.Value)
                .ToProjectDirectoryPath();

            return output;
        }

        public IProjectFileName Get_ProjectFileName(IProjectFilePath projectFilePath)
        {
            var projectFileName = Instances.PathOperator.GetFileName(
                projectFilePath.Value)
                .ToProjectFileName();

            return projectFileName;
        }

        public IProjectFilePath Get_ProjectFilePath(
            IProjectDirectoryPath projectDirectoryPath,
            IProjectFileName projectFileName)
        {
            var output = Instances.PathOperator.GetFilePath(
                projectDirectoryPath.Value,
                projectFileName.Value)
                .ToProjectFilePath();

            return output;
        }

        public IProjectFilePath Get_ProjectFilePath(
            IProjectDirectoryPath projectDirectoryPath,
            IProjectName projectName)
        {
            var projectFileName = Instances.ProjectNameConventions.Get_ProjectFileName(projectName);

            var projectFilePath = this.Get_ProjectFilePath(
                projectDirectoryPath,
                projectFileName);

            return projectFilePath;
        }

        public IProjectFilePath Get_ProjectFilePath(
            IDirectoryPath projectDirectoryParentDirectoryPath,
            IProjectName projectName)
        {
            var projectDirectoryPath = this.Get_ProjectDirectoryPath(
                projectDirectoryParentDirectoryPath,
                projectName);

            var projectFilePath = this.Get_ProjectFilePath(
                projectDirectoryPath,
                projectName);

            return projectFilePath;
        }

        public IProjectName Get_ProjectName(IProjectFilePath projectFilePath)
        {
            var projectName = Instances.PathOperator.GetFileNameStem(
                projectFilePath.Value)
                .ToProjectName();

            return projectName;
        }
    }
}
