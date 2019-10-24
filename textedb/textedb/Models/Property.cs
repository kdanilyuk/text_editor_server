using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace textedb.Models
{
    [Serializable]
    public class Property
    {
        [JsonProperty(PropertyName = "font")]
        public string Font { get; set; }

        [JsonProperty(PropertyName = "fontsize")]
        public int FontSize { get; set; }

        [JsonProperty(PropertyName = "text_align")]
        public string TextAlign { get; set; }

        [JsonProperty(PropertyName = "text_color")]
        public string TextColor { get; set; }

        [JsonProperty(PropertyName = "background_color")]
        public string BackgroundColor { get; set; }

        [JsonProperty(PropertyName = "is_bold")]
        public bool IsBold { get; set; }

        [JsonProperty(PropertyName = "is_incline")]
        public bool IsIncline { get; set; }

        [JsonProperty(PropertyName = "is_underline")]
        public bool IsUnderline { get; set; }

        [JsonProperty(PropertyName = "is_cross_out")]
        public bool IsCrossOut { get; set; }

        [JsonProperty(PropertyName = "is_numered_list")]
        public bool IsNumeredList { get; set; }

        [JsonProperty(PropertyName = "is_unordered_list")]
        public bool IsUnorderedList { get; set; }

        public Property(string font = "Comic Sans MS", int fontsize = 10,
                        string textalign = "left", string textcolor = "#000000",
                        string backgroundcolor = "#ffffff", bool isbold = false,
                        bool isincline = false, bool isnumeredlist = false,
                        bool isunderline = false, bool isunorderedlist = false,
                        bool iscrossout = false)
        {
            Font = font;
            FontSize = fontsize;
            TextAlign = textalign;
            TextColor = textcolor;
            BackgroundColor = backgroundcolor;
            IsBold = isbold;
            IsCrossOut = iscrossout;
            IsIncline = isincline;
            IsNumeredList = isnumeredlist;
            IsUnderline = isunderline;
            IsUnorderedList = isunorderedlist;
        }
    }
}
