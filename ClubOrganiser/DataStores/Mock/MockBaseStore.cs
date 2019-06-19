using DataStores.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataStores.Mock
{
    public class MockStore<T> : IBaseStore<T>
    {
        #region IBaseStore implementation

        public void DropTable()
        {

        }
        public virtual Task InitializeStore()
        {
            throw new NotImplementedException();
        }
        public virtual Task<System.Collections.Generic.IEnumerable<T>> GetItemsAsync(bool forceRefresh = false)
        {
            throw new NotImplementedException();
        }
        public virtual Task<T> GetItemAsync(string id)
        {
            throw new NotImplementedException();
        }
        public virtual Task<bool> InsertAsync(T item)
        {
            throw new NotImplementedException();
        }
        public virtual Task<bool> UpdateAsync(T item)
        {
            throw new NotImplementedException();
        }
        public virtual Task<bool> RemoveAsync(T item)
        {
            throw new NotImplementedException();
        }
        public virtual Task<bool> SyncAsync()
        {
            return Task.FromResult(true);
        }

        public string Identifier => "store";
        #endregion
    }
}
