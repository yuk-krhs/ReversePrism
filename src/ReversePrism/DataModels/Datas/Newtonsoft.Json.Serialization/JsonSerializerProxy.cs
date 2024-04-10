using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0E0 SerializerReader                         00018675F670 ModelClassType JsonSerializerInternalReader JsonSerializerInternalReader JsonSerializerInternalReader Pointer
    // 0E8 SerializerWriter                         00018675FB00 ModelClassType JsonSerializerInternalWriter JsonSerializerInternalWriter JsonSerializerInternalWriter Pointer
    // 0F0 Serializer                               00018675EEB0 ModelClassType JsonSerializer JsonSerializer JsonSerializer Pointer
    public partial class JsonSerializerProxy : DataModel
    {
        public JsonSerializerInternalReader?            SerializerReader                        { get; set; }
        public JsonSerializerInternalWriter?            SerializerWriter                        { get; set; }
        public JsonSerializer?                          Serializer                              { get; set; }

        public static JsonSerializerProxy? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonSerializerProxy() { Pointer= p0 };

            value.SerializerReader                          = GetObject<JsonSerializerInternalReader>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.JsonSerializerInternalReader.FromPointer); // 0246687E5818 0xE0 SerializerReader            ( 00018675F670 ModelClassType JsonSerializerInternalReader JsonSerializerInternalReader JsonSerializerInternalReader Pointer )
            value.SerializerWriter                          = GetObject<JsonSerializerInternalWriter>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.JsonSerializerInternalWriter.FromPointer); // 0246687E5838 0xE8 SerializerWriter            ( 00018675FB00 ModelClassType JsonSerializerInternalWriter JsonSerializerInternalWriter JsonSerializerInternalWriter Pointer )
            value.Serializer                                = GetObject<JsonSerializer>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.JsonSerializer.FromPointer); // 0246687E5858 0xF0 Serializer                  ( 00018675EEB0 ModelClassType JsonSerializer JsonSerializer JsonSerializer Pointer )

            return value;
        }
    }
}
