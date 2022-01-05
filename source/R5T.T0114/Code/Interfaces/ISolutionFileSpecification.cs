using System;

using R5T.T0122;


namespace R5T.T0114
{
    public interface ISolutionFileSpecification : IFileSpecification, INameSpecification
    {
        /// <summary>
        /// Project references that should exist in directly in the solution itself.
        /// </summary>
        public string[] ProjectReferenceFilePaths { get; set; }
        /// <summary>
        /// Project reference that should exist in the dependencies solution folder.
        /// </summary>
        public string[] DependencyProjectReferenceFilePaths { get; set; }
    }
}
