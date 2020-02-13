using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingCosmos.models;

namespace TestingCosmos.services
{
    public interface ICosmosDbService
    {
        Task<IEnumerable<Contact>> GetItemsAsync(string query);
        Task<Contact> GetItemAsync(string id);
        Task AddItemAsync(Contact contact);
        Task UpdateItemAsync(string id, Contact contact);
        Task DeleteItemAsync(string id);
    }
}
