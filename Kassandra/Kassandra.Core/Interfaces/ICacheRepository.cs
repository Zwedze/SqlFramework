﻿using System;
using System.Runtime.Caching;

namespace Kassandra.Core.Interfaces
{
    public interface ICacheRepository
    {
        TOutput GetEntry<TOutput>(string cacheKey);
        void Insert(string cacheKey, object item, TimeSpan duration, CacheItemPriority priority = CacheItemPriority.Default);
    }
}