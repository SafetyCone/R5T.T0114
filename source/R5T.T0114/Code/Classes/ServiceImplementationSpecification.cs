using System;


namespace R5T.T0114
{
    public class ServiceImplementationSpecification : IServiceImplementationSpecification
    {
        public string ImplementationNamespacedTypeName { get; set; }
        public string DefinitionNamespacedTypeName { get; set; }
    }
}
