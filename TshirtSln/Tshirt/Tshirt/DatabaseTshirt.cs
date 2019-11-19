using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tshirt
{
    public class DatabaseTshirt
    {
        public SQLiteAsyncConnection database;

        public DatabaseTshirt(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<TshirtItem>().Wait();
        }

        public  Task<List<TshirtItem>> GetTshirtItemAsync()
        {
            
            return database.Table<TshirtItem>().ToListAsync();
        }

        public Task<List<TshirtItem>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<TshirtItem>("SELECT * FROM [TshirtItem] WHERE [Done] = 0");
        }

        public Task<TshirtItem> GetItemAsync(int id)
        {
            return database.Table<TshirtItem>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(TshirtItem item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(TshirtItem item)
        {
            return database.DeleteAsync(item);
        }
    }
}
