using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Reader                                   ModelClassType JsonSerializerInternalReader JsonSerializerInternalReader JsonSerializerInternalReader Pointer
    // 018 Contract                                 ModelClassType JsonISerializableContract JsonISerializableContract JsonISerializableContract Pointer
    // 020 Member                                   ModelClassType JsonProperty JsonProperty JsonProperty Pointer
    public partial class JsonFormatterConverter : DataModel
    {
        public JsonSerializerInternalReader?            Reader                                  { get; set; }
        public JsonISerializableContract?               Contract                                { get; set; }
        public JsonProperty?                            Member                                  { get; set; }

        public static JsonFormatterConverter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonFormatterConverter() { Pointer= p0 };

            value.Reader                                    = GetObject<JsonSerializerInternalReader>(new IntPtr(p + 0x010), ReversePrism.DataModels.JsonSerializerInternalReader.FromPointer); // 0x10 Reader                      ( ModelClassType JsonSerializerInternalReader JsonSerializerInternalReader JsonSerializerInternalReader Pointer )
            value.Contract                                  = GetObject<JsonISerializableContract>(new IntPtr(p + 0x018), ReversePrism.DataModels.JsonISerializableContract.FromPointer); // 0x18 Contract                    ( ModelClassType JsonISerializableContract JsonISerializableContract JsonISerializableContract Pointer )
            value.Member                                    = GetObject<JsonProperty>(new IntPtr(p + 0x020), ReversePrism.DataModels.JsonProperty.FromPointer); // 0x20 Member                      ( ModelClassType JsonProperty JsonProperty JsonProperty Pointer )

            return value;
        }
    }
}
