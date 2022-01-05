using System;


namespace R5T.T0114
{
    public interface IServiceImplementationSpecification : IServiceDefinitionSpecification
    {
        public string ImplementationNamespacedTypeName { get; }
    }
}
