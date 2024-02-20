using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ReversePrism
{
    public class BodyParameterSet
    {
        public List<BodyParameter>?     param                   { get; set; }
        public Dictionary<string, BodyParameter?>? map          { get; set; }

        public static string GetRealName(CatalogASet catalog)
        {
            var label   = CatalogDB.CalcResourceLabel("body_parameter.json");

            if(!catalog.TryGetValue(label, out var rec))
                throw new InvalidDataException();

            var real    = CatalogDB.GetRealName(rec);

            return real;
        }

        public static BodyParameterSet FromFile(string file)
        {
            var text    = File.ReadAllText(file);
            var value   = JsonSerializer.Deserialize<BodyParameterSet>(text);

            if(value == null || value.param == null)
                throw new InvalidDataException();

            value.map   = value.param.Where(i => i?.charaId != null).ToDictionary(i => i.charaId);

            return value;
        }
    }

    public class BodyParameter
    {
        public string?  charaName;
        public string?  charaId;
        public float    height;
        public float    bust;
        public float    head;
        public float    thin;
        public float    shoulder;
        public float    hip;
        public int      skin;
        public int      color;
        public string?  skinBright;
        public string?  skinDark;
    }
}
