using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AttrsImpl                                ModelEnumType ParameterAttributes ParameterAttributes ParameterAttributes Int32
    // 018 ClassImpl                                ModelClassType Type Type Type Pointer
    // 020 DefaultValueImpl                         <object> IL2CPP_TYPE_OBJECT
    // 028 MemberImpl                               ModelClassType MemberInfo MemberInfo MemberInfo Pointer
    // 030 NameImpl                                 ModelPrimitiveType string string string String
    // 038 PositionImpl                             ModelPrimitiveType int int int Int32
    // 000 MetadataToken_ParamDef                   int IL2CPP_TYPE_I4
    public partial class ParameterInfo : DataModel
    {
        public ParameterAttributes                      AttrsImpl                               { get; set; }
        public Type?                                    ClassImpl                               { get; set; }
        public MemberInfo?                              MemberImpl                              { get; set; }
        public string                                   NameImpl                                { get; set; }
        public int                                      PositionImpl                            { get; set; }

        public static ParameterInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ParameterInfo() { Pointer= p0 };

            value.AttrsImpl                                 = (ParameterAttributes)GetInt32(new IntPtr(p + 0x010)); // 0x10 AttrsImpl                   ( ModelEnumType ParameterAttributes ParameterAttributes ParameterAttributes Int32 )
            value.ClassImpl                                 = GetObject<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 0x18 ClassImpl                   ( ModelClassType Type Type Type Pointer )
            value.MemberImpl                                = GetObject<MemberInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.MemberInfo.FromPointer); // 0x28 MemberImpl                  ( ModelClassType MemberInfo MemberInfo MemberInfo Pointer )
            value.NameImpl                                  = GetString(new IntPtr(p + 0x030)); // 0x30 NameImpl                    ( ModelPrimitiveType string string string String )
            value.PositionImpl                              = GetInt32(new IntPtr(p + 0x038)); // 0x38 PositionImpl                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
