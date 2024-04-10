using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsReturnValue                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 MemberName                               000186671910 ModelPrimitiveType string string string String
    // 020 MemberType                               000186692850 ModelClassType Type Type Type Pointer
    // 028 XmlAttributes                            00018658B300 ModelClassType XmlAttributes XmlAttributes XmlAttributes Pointer
    // 030 DeclaringType                            000186692850 ModelClassType Type Type Type Pointer
    public partial class XmlReflectionMember : DataModel
    {
        public bool                                     IsReturnValue                           { get; set; }
        public string                                   MemberName                              { get; set; }
        public Type?                                    MemberType                              { get; set; }
        public XmlAttributes?                           XmlAttributes                           { get; set; }
        public Type?                                    DeclaringType                           { get; set; }

        public static XmlReflectionMember? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlReflectionMember() { Pointer= p0 };

            value.IsReturnValue                             = GetBool(new IntPtr(p + 0x010)); // 02466751A998 0x10 IsReturnValue               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MemberName                                = GetString(new IntPtr(p + 0x018)); // 02466751A9B8 0x18 MemberName                  ( 000186671910 ModelPrimitiveType string string string String )
            value.MemberType                                = GetObject<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 02466751A9D8 0x20 MemberType                  ( 000186692850 ModelClassType Type Type Type Pointer )
            value.XmlAttributes                             = GetObject<XmlAttributes>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlAttributes.FromPointer); // 02466751A9F8 0x28 XmlAttributes               ( 00018658B300 ModelClassType XmlAttributes XmlAttributes XmlAttributes Pointer )
            value.DeclaringType                             = GetObject<Type>(new IntPtr(p + 0x030), ReversePrism.DataModels.Type.FromPointer); // 02466751AA18 0x30 DeclaringType               ( 000186692850 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
