using System;

using R5T.T0122;


namespace R5T.T0114
{
    public interface IProjectSpecification : INameAndDescriptionSpecification
    {
        string Type { get; set; }
    }
}
