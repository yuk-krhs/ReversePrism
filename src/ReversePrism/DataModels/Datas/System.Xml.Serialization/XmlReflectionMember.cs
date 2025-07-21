using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsReturnValue                            ModelPrimitiveType bool bool bool Bool
    // 018 MemberName                               ModelPrimitiveType string string string String
    // 020 MemberType                               ModelClassType Type Type Type Pointer
    // 028 XmlAttributes                            ModelClassType XmlAttributes XmlAttributes XmlAttributes Pointer
    // 030 DeclaringType                            ModelClassType Type Type Type Pointer
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

            value.IsReturnValue                             = GetBool(new IntPtr(p + 0x010)); // 0x10 IsReturnValue               ( ModelPrimitiveType bool bool bool Bool )
            value.MemberName                                = GetString(new IntPtr(p + 0x018)); // 0x18 MemberName                  ( ModelPrimitiveType string string string String )
            value.MemberType                                = GetObject<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 0x20 MemberType                  ( ModelClassType Type Type Type Pointer )
            value.XmlAttributes                             = GetObject<XmlAttributes>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlAttributes.FromPointer); // 0x28 XmlAttributes               ( ModelClassType XmlAttributes XmlAttributes XmlAttributes Pointer )
            value.DeclaringType                             = GetObject<Type>(new IntPtr(p + 0x030), ReversePrism.DataModels.Type.FromPointer); // 0x30 DeclaringType               ( ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
