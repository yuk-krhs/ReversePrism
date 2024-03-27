using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Reader                                   00018675F670 ModelClassType JsonSerializerInternalReader JsonSerializerInternalReader JsonSerializerInternalReader Pointer
    // 018 Contract                                 000186755BB0 ModelClassType JsonISerializableContract JsonISerializableContract JsonISerializableContract Pointer
    // 020 Member                                   000186603120 ModelClassType JsonProperty JsonProperty JsonProperty Pointer
    public partial class JsonFormatterConverter
    {
        public JsonSerializerInternalReader?            Reader                                  { get; set; }
        public JsonISerializableContract?               Contract                                { get; set; }
        public JsonProperty?                            Member                                  { get; set; }

        public static JsonFormatterConverter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonFormatterConverter();

            value.Reader                                    = GetObject<JsonSerializerInternalReader>(new IntPtr(p + 0x010), ReversePrism.DataModels.JsonSerializerInternalReader.FromPointer); // 0270D877B9D8 0x10 Reader                      ( 00018675F670 ModelClassType JsonSerializerInternalReader JsonSerializerInternalReader JsonSerializerInternalReader Pointer )
            value.Contract                                  = GetObject<JsonISerializableContract>(new IntPtr(p + 0x018), ReversePrism.DataModels.JsonISerializableContract.FromPointer); // 0270D877B9F8 0x18 Contract                    ( 000186755BB0 ModelClassType JsonISerializableContract JsonISerializableContract JsonISerializableContract Pointer )
            value.Member                                    = GetObject<JsonProperty>(new IntPtr(p + 0x020), ReversePrism.DataModels.JsonProperty.FromPointer); // 0270D877BA18 0x20 Member                      ( 000186603120 ModelClassType JsonProperty JsonProperty JsonProperty Pointer )

            return value;
        }
    }
}
