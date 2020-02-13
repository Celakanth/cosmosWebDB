using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Cosmos.Fluent;
using Microsoft.Extensions.Configuration;
using TestingCosmos.models;



namespace TestingCosmos.services
{
    public class CosmosDBService : ICosmosDbService
    {
        private Container _container;

        public CosmosDBService(
           CosmosClient dbClient,
           string databaseName,
           string containerName)
        {
            this._container = dbClient.GetContainer(databaseName, containerName);
        }

        public async Task AddItemAsync(Contact contact)
        {
            await this._container.CreateItemAsync<Contact>(contact, new PartitionKey(contact.Id));
        }

        public async Task DeleteItemAsync(string id)
        {
            await this._container.DeleteItemAsync<Contact>(id, new PartitionKey(id));
        }

        public async Task<Contact> GetItemAsync(string id)
        {
            try
            {
                ItemResponse<Contact> response = await this._container.ReadItemAsync<Contact>(id, new PartitionKey(id));
                return response.Resource;
            }
            catch (CosmosException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }

        }

        public async Task<IEnumerable<Contact>> GetItemsAsync(string queryString)
        {
            var query = this._container.GetItemQueryIterator<Contact>(new QueryDefinition(queryString));
            List<Contact> results = new List<Contact>();
            while (query.HasMoreResults)
            {
                var response = await query.ReadNextAsync();

                results.AddRange(response.ToList());
            }

            return results;
        }

        public async Task UpdateItemAsync(string id, Contact contact)
        {
            await this._container.UpsertItemAsync<Contact>(contact, new PartitionKey(id));
        }


    }

}
