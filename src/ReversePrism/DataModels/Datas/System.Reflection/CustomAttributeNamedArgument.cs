using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TypedValue                               ModelEnumType CustomAttributeTypedArgument CustomAttributeTypedArgument CustomAttributeTypedArgument Int32
    // 020 IsField                                  ModelPrimitiveType bool bool bool Bool
    // 028 MemberName                               ModelPrimitiveType string string string String
    // 030 AttributeType                            ModelClassType Type Type Type Pointer
    // 038 LazyMemberInfo                           ModelClassType MemberInfo MemberInfo MemberInfo Pointer
    public partial class CustomAttributeNamedArgument : DataModel
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
            var value   = new CustomAttributeNamedArgument() { Pointer= p0 };

            value.TypedValue                                = (CustomAttributeTypedArgument)GetInt32(new IntPtr(p + 0x010)); // 0x10 TypedValue                  ( ModelEnumType CustomAttributeTypedArgument CustomAttributeTypedArgument CustomAttributeTypedArgument Int32 )
            value.IsField                                   = GetBool(new IntPtr(p + 0x020)); // 0x20 IsField                     ( ModelPrimitiveType bool bool bool Bool )
            value.MemberName                                = GetString(new IntPtr(p + 0x028)); // 0x28 MemberName                  ( ModelPrimitiveType string string string String )
            value.AttributeType                             = GetObject<Type>(new IntPtr(p + 0x030), ReversePrism.DataModels.Type.FromPointer); // 0x30 AttributeType               ( ModelClassType Type Type Type Pointer )
            value.LazyMemberInfo                            = GetObject<MemberInfo>(new IntPtr(p + 0x038), ReversePrism.DataModels.MemberInfo.FromPointer); // 0x38 LazyMemberInfo              ( ModelClassType MemberInfo MemberInfo MemberInfo Pointer )

            return value;
        }
    }
}
