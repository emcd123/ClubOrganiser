using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataStores.Interfaces
{
    public interface IStoreManager
    {
        bool IsInitialized { get; }
        Task InitializeAsync();

        Task<bool> SyncAllAsync(bool syncUserSpecific);
        Task DropEverythingAsync();
    }
}
