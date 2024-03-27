using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     0001866736C0 ModelPrimitiveType string string string String
    // 018 Type                                     000186693B90 ModelClassType Type Type Type Pointer
    public partial class NameType
    {
        public string                                   Name                                    { get; set; }
        public Type?                                    Type                                    { get; set; }

        public static NameType? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NameType();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0270D8968800 0x10 Name                        ( 0001866736C0 ModelPrimitiveType string string string String )
            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 0270D8968820 0x18 Type                        ( 000186693B90 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
