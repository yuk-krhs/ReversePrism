using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     000186692F60 ModelClassType Type Type Type Pointer
    // 018 TypeName                                 0001866722E0 ModelPrimitiveType string string string String
    // 020 TypeNs                                   0001866722E0 ModelPrimitiveType string string string String
    // 028 Callback                                 0001865C7460 ModelClassType XmlSerializationWriteCallback XmlSerializationWriteCallback XmlSerializationWriteCallback Pointer
    public partial class WriteCallbackInfo
    {
        public Type?                                    Type                                    { get; set; }
        public string                                   TypeName                                { get; set; }
        public string                                   TypeNs                                  { get; set; }
        public XmlSerializationWriteCallback?           Callback                                { get; set; }

        public static WriteCallbackInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WriteCallbackInfo();

            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0270D74CE850 0x10 Type                        ( 000186692F60 ModelClassType Type Type Type Pointer )
            value.TypeName                                  = GetString(new IntPtr(p + 0x018)); // 0270D74CE870 0x18 TypeName                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.TypeNs                                    = GetString(new IntPtr(p + 0x020)); // 0270D74CE890 0x20 TypeNs                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Callback                                  = GetObject<XmlSerializationWriteCallback>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlSerializationWriteCallback.FromPointer); // 0270D74CE8B0 0x28 Callback                    ( 0001865C7460 ModelClassType XmlSerializationWriteCallback XmlSerializationWriteCallback XmlSerializationWriteCallback Pointer )

            return value;
        }
    }
}
