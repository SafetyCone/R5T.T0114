using System;

using R5T.T0122;


namespace R5T.T0114
{
    public interface IProjectFileSpecification : IFileSpecification, INameAndDescriptionSpecification
    {
        public string Documentation { get; set; }
        public string DefaultNamespaceName { get; set; }

        public string[] ProjectReferenceFilePaths { get; set; }
        public string[] DependencyProjectReferenceFilePaths { get; set; }
    }
}