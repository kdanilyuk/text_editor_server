using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace textedb.Models
{
    [Serializable]
    public class Document
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "owner")]
        public string Owner { get; set; }

        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        public Document() { }

        public Document(string name, string owner, string text, int id)
        {
            Name = name;
            Owner = owner;
            Text = text;
            Id = id;
        }

        public override string ToString()
        {
            return Name.ToString();
        }
    }
}
