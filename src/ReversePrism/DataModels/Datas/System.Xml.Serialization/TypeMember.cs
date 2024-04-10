using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     000186692850 ModelClassType Type Type Type Pointer
    // 018 Member                                   000186671910 ModelPrimitiveType string string string String
    public partial class TypeMember : DataModel
    {
        public Type?                                    Type                                    { get; set; }
        public string                                   Member                                  { get; set; }

        public static TypeMember? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeMember() { Pointer= p0 };

            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 024667515298 0x10 Type                        ( 000186692850 ModelClassType Type Type Type Pointer )
            value.Member                                    = GetString(new IntPtr(p + 0x018)); // 0246675152B8 0x18 Member                      ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
