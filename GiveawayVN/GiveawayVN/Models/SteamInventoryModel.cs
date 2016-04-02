using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GiveawayVN.Models
{
    public class Inventory
    {
        public Inventory()
        {
        }

        // get Inventory or not
        [JsonProperty("success")]
        public bool success { get; set; }

        [JsonProperty("rgInventory")]
        public List<rgInventory> rgInventorys { get; set; }

        [JsonProperty("rgCurrency")]
        public List<rgCurrency> rgCurrencys { get; set; }

        [JsonProperty("rgDescriptions")]
        public List<rgDescription> rgDescriptions { get; set; }
    }

    public class rgInventory
    {
        public rgInventory()
        {
        }

        [JsonProperty("id")]
        public long id { get; set; }

        [JsonProperty("class")]
        public long classid { get; set; }

        [JsonProperty("instanceid")]
        public int instanceid { get; set; }

        [JsonProperty("amount")]
        public int amount { get; set; }

        //Vi tri cua item
        [JsonProperty("pos")]
        public int pos { get; set; }
    }

    public class rgCurrency
    {
        public rgCurrency()
        {
        }
    }

    public class rgDescription
    {
        [JsonProperty("appid")]
        public int appid { get; set; }

        [JsonProperty("classid")]
        public long classid { get; set; }

        [JsonProperty("instanceid")]
        public int instanceid { get; set; }

        [JsonProperty("icon_url")]
        public string icon_url { get; set; }

        [JsonProperty("icon_url_large")]
        public string icon_url_large { get; set; }

        [JsonProperty("icon_drag_url")]
        public string icon_drag_url { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("market_hash_name")]
        public string market_hash_name { get; set; }

        [JsonProperty("market_name")]
        public string market_name { get; set; }

        [JsonProperty("name_color")]
        public string name_color { get; set; }

        [JsonProperty("background_color")]
        public string background_color { get; set; }

        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("tradable")]
        public int tradable { get; set; }

        [JsonProperty("marketable")]
        public int marketable { get; set; }

        [JsonProperty("commodity")]
        public int commodity { get; set; }

        [JsonProperty("market_tradable_restriction")]
        public string market_tradable_restriction { get; set; }

        [JsonProperty("market_marketable_restriction")]
        public string market_marketable_restriction { get; set; }

        [JsonProperty("descriptions")]
        public List<ItemDescription> descriptions { get; set; }

        [JsonProperty("actions")]
        public List<ItemAction> actions { get; set; }

    }

    public class ItemDescription
    {
        // get Inventory or not

        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("value")]
        public string value { get; set; }
    }

    public class ItemAction
    {
        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("link")]
        public string link { get; set; }
    }

    public class InventoryItem
    {
        public InventoryItem() { }

        public long id { get; set; }

        public long contextid { get; set; }

        public int appid { get; set; }

        public double price { get; set; }

        public string name { get; set; }

        public string marketHashName {get;set;}

        public string image { get; set; }

        public string commodity { get; set; } 

    }
}
