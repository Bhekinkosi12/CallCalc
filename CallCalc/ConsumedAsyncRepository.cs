using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace CallCalc
{
    public class ConsumedAsyncRepository
    {      
        public SQLiteAsyncConnection database;

        public ConsumedAsyncRepository(string databasePath)
        {
            database = new SQLiteAsyncConnection(databasePath);
        }

        public async Task CreateTable()
        {
            await database.CreateTableAsync<Consumed>();
        }

        public async Task<List<Consumed>> GetItemsAsync()
        {
            return await database.Table<Consumed>().ToListAsync();

        }
        public async Task<Consumed> GetItemAsync(int id)
        {
            return await database.GetAsync<Consumed>(id);
        }
        public async Task<int> DeleteItemAsync(Consumed item)
        {
            return await database.DeleteAsync(item);
        }
        public async Task<int> SaveItemAsync(Consumed item)
        {
            if (item.Id != 0)
            {
                await database.UpdateAsync(item);
                return item.Id;
            }
            else
            {
                return await database.InsertAsync(item);
            }
        }
    }
}
