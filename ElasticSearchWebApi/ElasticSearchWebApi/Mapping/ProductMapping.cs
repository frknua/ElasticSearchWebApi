using System;
using ElasticSearchWebApi.Entities;
using Nest;

namespace ElasticSearchWebApi.Mapping
{
    public static class Mapping
    {
        public static CreateIndexDescriptor ProductMapping(this CreateIndexDescriptor descriptor)
        {
            return descriptor.Map<Product>(m => m.Properties(p => p
                .Text(t => t.Name(n => n.Name))
                .Text(t => t.Name(n => n.ImageUrl))
                .Number(t => t.Name(n => n.Price))));
        }
    }
}
