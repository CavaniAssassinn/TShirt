/*using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tshirt;

namespace Tshirt
{
   public class Storage: TshirtItem
        {
            readonly List<TshirtItem> items;

            public Storage()
            {
                items = new List<TshirtItem>()
            {
                new TshirtItem {Name = "First item", Gender="Gender of customer", Adrress="Address of customer", Color="Color of item", Size="size of poduct"},
                new TshirtItem {Name = "Second item", Gender="Gender of customer", Adrress="Address of customer", Color="Color of item", Size="size of poduct"},
                new TshirtItem {Name = "Third item", Gender="Gender of customer", Adrress="Address of customer", Color="Color of item", Size="size of poduct"},
                new TshirtItem {Name = "Fourth item", Gender="Gender of customer", Adrress="Address of customer", Color="Color of item", Size="size of poduct"},
                new TshirtItem {Name = "Fifth item", Gender="Gender of customer" ,Adrress="Address of customer", Color="Color of item", Size="size of poduct"},
                new TshirtItem {Name = "Sixth item", Gender="Gender of customer" ,Adrress="Address of customer", Color="Color of item", Size="size of poduct"}
            };
            }
        public async Task<bool> AddItemAsync(TshirtItem item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }
    }
    }
    */