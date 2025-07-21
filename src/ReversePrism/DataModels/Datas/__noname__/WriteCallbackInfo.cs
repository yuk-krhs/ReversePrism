using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     ModelClassType Type Type Type Pointer
    // 018 TypeName                                 ModelPrimitiveType string string string String
    // 020 TypeNs                                   ModelPrimitiveType string string string String
    // 028 Callback                                 ModelClassType XmlSerializationWriteCallback XmlSerializationWriteCallback XmlSerializationWriteCallback Pointer
    public partial class WriteCallbackInfo : DataModel
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
            var value   = new WriteCallbackInfo() { Pointer= p0 };

            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0x10 Type                        ( ModelClassType Type Type Type Pointer )
            value.TypeName                                  = GetString(new IntPtr(p + 0x018)); // 0x18 TypeName                    ( ModelPrimitiveType string string string String )
            value.TypeNs                                    = GetString(new IntPtr(p + 0x020)); // 0x20 TypeNs                      ( ModelPrimitiveType string string string String )
            value.Callback                                  = GetObject<XmlSerializationWriteCallback>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlSerializationWriteCallback.FromPointer); // 0x28 Callback                    ( ModelClassType XmlSerializationWriteCallback XmlSerializationWriteCallback XmlSerializationWriteCallback Pointer )

            return value;
        }
    }
}
