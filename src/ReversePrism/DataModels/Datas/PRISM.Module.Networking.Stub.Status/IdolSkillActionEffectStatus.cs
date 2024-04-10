using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<IdolSkillActionEffectStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstProduceActionEffectIdFieldNumber      int IL2CPP_TYPE_I4
    // 018 MstProduceActionEffectId                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstProduceActionEffectTypeIdFieldNumber  int IL2CPP_TYPE_I4
    // 01C MstProduceActionEffectTypeId             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ValueListFieldNumber                     int IL2CPP_TYPE_I4
    // 008 _repeated_valueList_codec                FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 020 ValueList                                000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 IconIdFieldNumber                        int IL2CPP_TYPE_I4
    // 028 IconId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class IdolSkillActionEffectStatus : DataModel
    {
        public int                                      MstProduceActionEffectId                { get; set; }
        public int                                      MstProduceActionEffectTypeId            { get; set; }
        public List<int>?                               ValueList                               { get; set; }
        public int                                      IconId                                  { get; set; }

        public static IdolSkillActionEffectStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolSkillActionEffectStatus() { Pointer= p0 };

            value.MstProduceActionEffectId                  = GetInt32(new IntPtr(p + 0x018)); // 024660FB5C20 0x18 MstProduceActionEffectId    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstProduceActionEffectTypeId              = GetInt32(new IntPtr(p + 0x01C)); // 024660FB5C60 0x1C MstProduceActionEffectTypeId ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ValueList                                 = GetInt32List(new IntPtr(p + 0x020)); // 024660FB5CC0 0x20 ValueList                   ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.IconId                                    = GetInt32(new IntPtr(p + 0x028)); // 024660FB5D00 0x28 IconId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
