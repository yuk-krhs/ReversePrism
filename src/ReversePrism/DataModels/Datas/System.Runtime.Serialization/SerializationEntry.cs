using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186672F10 ModelPrimitiveType string string string String
    // 018 _value                                   <object> IL2CPP_TYPE_OBJECT
    // 020 Type                                     0001866936B0 ModelClassType Type Type Type Pointer
    public partial class SerializationEntry : DataModel
    {
        public string                                   Name                                    { get; set; }
        public Type?                                    Type                                    { get; set; }

        public static SerializationEntry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SerializationEntry() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 024666C65380 0x10 Name                        ( 000186672F10 ModelPrimitiveType string string string String )
            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 024666C653C0 0x20 Type                        ( 0001866936B0 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
