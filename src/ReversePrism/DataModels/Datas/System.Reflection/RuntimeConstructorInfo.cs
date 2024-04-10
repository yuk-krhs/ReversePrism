using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 mhandle                                  <int> IL2CPP_TYPE_I
    // 018 Name                                     000186671910 ModelPrimitiveType string string string String
    // 020 Reftype                                  000186692850 ModelClassType Type Type Type Pointer
    public partial class RuntimeConstructorInfo : DataModel
    {
        public string                                   Name                                    { get; set; }
        public Type?                                    Reftype                                 { get; set; }

        public static RuntimeConstructorInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RuntimeConstructorInfo() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0245A2E60FE8 0x18 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Reftype                                   = GetObject<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 0245A2E61008 0x20 Reftype                     ( 000186692850 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
