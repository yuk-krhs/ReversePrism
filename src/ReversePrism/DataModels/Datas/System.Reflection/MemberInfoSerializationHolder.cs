using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_memberName                             000186671910 ModelPrimitiveType string string string String
    // 018 M_reflectedType                          00018669F180 ModelClassType RuntimeType RuntimeType RuntimeType Pointer
    // 020 M_signature                              000186671910 ModelPrimitiveType string string string String
    // 028 M_signature2                             000186671910 ModelPrimitiveType string string string String
    // 030 M_memberType                             0001865F4980 ModelEnumType MemberTypes MemberTypes MemberTypes Int32
    // 038 M_info                                   0001866636F0 ModelClassType SerializationInfo SerializationInfo SerializationInfo Pointer
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

            value.M_memberName                              = GetString(new IntPtr(p + 0x010)); // 024666D3D2B0 0x10 M_memberName                ( 000186671910 ModelPrimitiveType string string string String )
            value.M_reflectedType                           = GetObject<RuntimeType>(new IntPtr(p + 0x018), ReversePrism.DataModels.RuntimeType.FromPointer); // 024666D3D2D0 0x18 M_reflectedType             ( 00018669F180 ModelClassType RuntimeType RuntimeType RuntimeType Pointer )
            value.M_signature                               = GetString(new IntPtr(p + 0x020)); // 024666D3D2F0 0x20 M_signature                 ( 000186671910 ModelPrimitiveType string string string String )
            value.M_signature2                              = GetString(new IntPtr(p + 0x028)); // 024666D3D310 0x28 M_signature2                ( 000186671910 ModelPrimitiveType string string string String )
            value.M_memberType                              = (MemberTypes)GetInt32(new IntPtr(p + 0x030)); // 024666D3D330 0x30 M_memberType                ( 0001865F4980 ModelEnumType MemberTypes MemberTypes MemberTypes Int32 )
            value.M_info                                    = GetObject<SerializationInfo>(new IntPtr(p + 0x038), ReversePrism.DataModels.SerializationInfo.FromPointer); // 024666D3D350 0x38 M_info                      ( 0001866636F0 ModelClassType SerializationInfo SerializationInfo SerializationInfo Pointer )

            return value;
        }
    }
}
