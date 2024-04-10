using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AttrsImpl                                00018671B140 ModelEnumType ParameterAttributes ParameterAttributes ParameterAttributes Int32
    // 018 ClassImpl                                000186692D10 ModelClassType Type Type Type Pointer
    // 020 DefaultValueImpl                         <object> IL2CPP_TYPE_OBJECT
    // 028 MemberImpl                               0001865F1D20 ModelClassType MemberInfo MemberInfo MemberInfo Pointer
    // 030 NameImpl                                 000186671E00 ModelPrimitiveType string string string String
    // 038 PositionImpl                             0001865F3220 ModelPrimitiveType int int int Int32
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

            value.AttrsImpl                                 = (ParameterAttributes)GetInt32(new IntPtr(p + 0x010)); // 0245A0283BC0 0x10 AttrsImpl                   ( 00018671B140 ModelEnumType ParameterAttributes ParameterAttributes ParameterAttributes Int32 )
            value.ClassImpl                                 = GetObject<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 0245A0283BE0 0x18 ClassImpl                   ( 000186692D10 ModelClassType Type Type Type Pointer )
            value.MemberImpl                                = GetObject<MemberInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.MemberInfo.FromPointer); // 0245A0283C20 0x28 MemberImpl                  ( 0001865F1D20 ModelClassType MemberInfo MemberInfo MemberInfo Pointer )
            value.NameImpl                                  = GetString(new IntPtr(p + 0x030)); // 0245A0283C40 0x30 NameImpl                    ( 000186671E00 ModelPrimitiveType string string string String )
            value.PositionImpl                              = GetInt32(new IntPtr(p + 0x038)); // 0245A0283C60 0x38 PositionImpl                ( 0001865F3220 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
