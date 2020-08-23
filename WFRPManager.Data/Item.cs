using System;
using System.Collections.Generic;
using System.Text;

namespace WFRPManager.Data
{
    public class Item
    {
        public string ItemName { get; set; }
        public string ItemWeight { get; set; }
        public string ItemDescription { get; set; }

        public Item()
        {
             this.ItemName = "";
             this.ItemWeight = "";
             this.ItemDescription = "";
        }
        public Item(string ItemName) : this() => this.ItemName = ItemName;
        public Item(string ItemName, string ItemWeight) : this(ItemName) => this.ItemWeight = ItemWeight;
        public Item(string ItemName, string ItemWeight, string ItemDescription) : this(ItemName, ItemWeight) => this.ItemDescription = ItemDescription;
    }
}
