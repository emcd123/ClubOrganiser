﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ClubRestAPI.DataModels;

namespace DataStores.Interfaces
{
    public interface IBaseStore<T>
    {
        Task InitializeStore();
        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
        Task<T> GetItemAsync(string id);
        Task<bool> InsertAsync(T item);
        Task<bool> UpdateAsync(T item);
        Task<bool> RemoveAsync(T item);
        Task<bool> SyncAsync();

        void DropTable();

        string Identifier { get; }
    }
}
