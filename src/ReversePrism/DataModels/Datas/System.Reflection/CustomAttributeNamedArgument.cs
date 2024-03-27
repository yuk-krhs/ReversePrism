using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TypedValue                               00018666A500 ModelEnumType CustomAttributeTypedArgument CustomAttributeTypedArgument CustomAttributeTypedArgument Int32
    // 020 IsField                                  0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 028 MemberName                               000186672F10 ModelPrimitiveType string string string String
    // 030 AttributeType                            0001866936B0 ModelClassType Type Type Type Pointer
    // 038 LazyMemberInfo                           0001865F1B00 ModelClassType MemberInfo MemberInfo MemberInfo Pointer
    public partial class CustomAttributeNamedArgument
    {
        public CustomAttributeTypedArgument             TypedValue                              { get; set; }
        public bool                                     IsField                                 { get; set; }
        public string                                   MemberName                              { get; set; }
        public Type?                                    AttributeType                           { get; set; }
        public MemberInfo?                              LazyMemberInfo                          { get; set; }

        public static CustomAttributeNamedArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CustomAttributeNamedArgument();

            value.TypedValue                                = (CustomAttributeTypedArgument)GetInt32(new IntPtr(p + 0x010)); // 027003DAB0E8 0x10 TypedValue                  ( 00018666A500 ModelEnumType CustomAttributeTypedArgument CustomAttributeTypedArgument CustomAttributeTypedArgument Int32 )
            value.IsField                                   = GetBool(new IntPtr(p + 0x020)); // 027003DAB108 0x20 IsField                     ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.MemberName                                = GetString(new IntPtr(p + 0x028)); // 027003DAB128 0x28 MemberName                  ( 000186672F10 ModelPrimitiveType string string string String )
            value.AttributeType                             = GetObject<Type>(new IntPtr(p + 0x030), ReversePrism.DataModels.Type.FromPointer); // 027003DAB148 0x30 AttributeType               ( 0001866936B0 ModelClassType Type Type Type Pointer )
            value.LazyMemberInfo                            = GetObject<MemberInfo>(new IntPtr(p + 0x038), ReversePrism.DataModels.MemberInfo.FromPointer); // 027003DAB168 0x38 LazyMemberInfo              ( 0001865F1B00 ModelClassType MemberInfo MemberInfo MemberInfo Pointer )

            return value;
        }
    }
}
