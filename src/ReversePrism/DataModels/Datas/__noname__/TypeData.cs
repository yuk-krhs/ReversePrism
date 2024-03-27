using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     0001866936B0 ModelClassType Type Type Type Pointer
    // 018 M_FullTypeName                           000186671910 ModelPrimitiveType string string string String
    // 020 M_TypeName                               000186671910 ModelPrimitiveType string string string String
    // 028 M_TypeNamespace                          000186671910 ModelPrimitiveType string string string String
    public partial class TypeData
    {
        public Type?                                    Type                                    { get; set; }
        public string                                   M_FullTypeName                          { get; set; }
        public string                                   M_TypeName                              { get; set; }
        public string                                   M_TypeNamespace                         { get; set; }

        public static TypeData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeData();

            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0270067F4C58 0x10 Type                        ( 0001866936B0 ModelClassType Type Type Type Pointer )
            value.M_FullTypeName                            = GetString(new IntPtr(p + 0x018)); // 0270067F4C78 0x18 M_FullTypeName              ( 000186671910 ModelPrimitiveType string string string String )
            value.M_TypeName                                = GetString(new IntPtr(p + 0x020)); // 0270067F4C98 0x20 M_TypeName                  ( 000186671910 ModelPrimitiveType string string string String )
            value.M_TypeNamespace                           = GetString(new IntPtr(p + 0x028)); // 0270067F4CB8 0x28 M_TypeNamespace             ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
