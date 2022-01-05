using System;


namespace R5T.T0114
{
    public class SolutionFileSpecification : ISolutionFileSpecification
    {
        public string Name { get; set; }

        public string FilePath { get; set; }

        public string[] ProjectReferenceFilePaths { get; set; }
        public string[] DependencyProjectReferenceFilePaths { get; set; }
    }
}
