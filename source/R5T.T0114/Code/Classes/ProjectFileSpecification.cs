using System;


namespace R5T.T0114
{
    public class ProjectFileSpecification : IProjectFileSpecification
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Documentation { get; set; }
        public string DefaultNamespaceName { get; set; }

        public string[] ProjectReferenceFilePaths { get; set; }
        public string[] DependencyProjectReferenceFilePaths { get; set; }

        public string FilePath { get; set; }
    }
}