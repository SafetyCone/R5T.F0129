using System;

using R5T.T0132;
using R5T.T0180;
using R5T.T0187;


namespace R5T.F0129
{
    [FunctionalityMarker]
    public partial interface IProjectDirectoryNameOperator : IFunctionalityMarker
    {
        public IDirectoryName Get_ProjectDirectoryName(IProjectName projectName)
        {
            return Instances.ProjectNameConventions.Get_ProjectDirectoryName(projectName);
        }
    }
}
