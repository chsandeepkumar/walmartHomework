using System.Collections.Generic;

namespace WalmartHW.Component.Model
{
    public class RootObject
    {
        public string Query { get; set; }
        public string Sort { get; set; }
        public string ResponseGroup { get; set; }
        public int TotalResults { get; set; }
        public int Start { get; set; }
        public int NumItems { get; set; }
        public List<Item> Items { get; set; }
        public List<object> Facets { get; set; }
    }
}
