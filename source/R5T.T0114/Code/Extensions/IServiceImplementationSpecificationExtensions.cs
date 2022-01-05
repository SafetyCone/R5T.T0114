using System;

using R5T.T0114;


namespace System
{
    public static class IServiceImplementationSpecificationExtensions
    {
        public static ServiceDefinitionSpecification GetDefinitionSpecification(this IServiceImplementationSpecification serviceImplementationSpecification)
        {
            var output = new ServiceDefinitionSpecification
            {
                DefinitionNamespacedTypeName = serviceImplementationSpecification.DefinitionNamespacedTypeName,
            };

            return output;
        }
    }
}
