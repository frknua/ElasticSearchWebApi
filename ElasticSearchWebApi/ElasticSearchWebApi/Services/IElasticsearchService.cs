using ElasticSearchWebApi.Entities;

namespace ElasticSearchWebApi.Services
{
    public interface IElasticsearchService
    {
        Task ChekIndex(string indexName);
        Task InsertDocument(string indexName, Product product);
        Task InsertDocuments(string indexName, List<Product> products);
        Task<Product> GetDocument(string indexName, int id);
        Task<List<Product>> GetDocuments(string indexName);
    }
}
