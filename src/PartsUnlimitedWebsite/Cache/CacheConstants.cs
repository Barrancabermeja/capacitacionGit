// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information. 
namespace PartsUnlimited.Cache
{
    public static class CacheConstants
    {
        public static class Key
        {
            public static string Category = "category";
            public static string AnnouncementProduct = "announcementProduct";
            public static string TopSellingProducts = "topselling";
            public static string NewArrivalProducts = "newarrivals";
            public static string Promos = "promo";

            public static string ProductKey(int id)
            {
                return $"product_{id}";
            }
        }
    }
}