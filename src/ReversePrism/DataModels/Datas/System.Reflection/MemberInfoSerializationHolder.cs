using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_memberName                             ModelPrimitiveType string string string String
    // 018 M_reflectedType                          ModelClassType RuntimeType RuntimeType RuntimeType Pointer
    // 020 M_signature                              ModelPrimitiveType string string string String
    // 028 M_signature2                             ModelPrimitiveType string string string String
    // 030 M_memberType                             ModelEnumType MemberTypes MemberTypes MemberTypes Int32
    // 038 M_info                                   ModelClassType SerializationInfo SerializationInfo SerializationInfo Pointer
    public partial class MemberInfoSerializationHolder : DataModel
    {
        public string                                   M_memberName                            { get; set; }
        public RuntimeType?                             M_reflectedType                         { get; set; }
        public string                                   M_signature                             { get; set; }
        public string                                   M_signature2                            { get; set; }
        public MemberTypes                              M_memberType                            { get; set; }
        public SerializationInfo?                       M_info                                  { get; set; }

        public static MemberInfoSerializationHolder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MemberInfoSerializationHolder() { Pointer= p0 };

            value.M_memberName                              = GetString(new IntPtr(p + 0x010)); // 0x10 M_memberName                ( ModelPrimitiveType string string string String )
            value.M_reflectedType                           = GetObject<RuntimeType>(new IntPtr(p + 0x018), ReversePrism.DataModels.RuntimeType.FromPointer); // 0x18 M_reflectedType             ( ModelClassType RuntimeType RuntimeType RuntimeType Pointer )
            value.M_signature                               = GetString(new IntPtr(p + 0x020)); // 0x20 M_signature                 ( ModelPrimitiveType string string string String )
            value.M_signature2                              = GetString(new IntPtr(p + 0x028)); // 0x28 M_signature2                ( ModelPrimitiveType string string string String )
            value.M_memberType                              = (MemberTypes)GetInt32(new IntPtr(p + 0x030)); // 0x30 M_memberType                ( ModelEnumType MemberTypes MemberTypes MemberTypes Int32 )
            value.M_info                                    = GetObject<SerializationInfo>(new IntPtr(p + 0x038), ReversePrism.DataModels.SerializationInfo.FromPointer); // 0x38 M_info                      ( ModelClassType SerializationInfo SerializationInfo SerializationInfo Pointer )

            return value;
        }
    }
}
