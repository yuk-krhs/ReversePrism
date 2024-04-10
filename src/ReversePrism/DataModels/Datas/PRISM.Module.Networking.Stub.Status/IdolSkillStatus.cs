using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AppealTypeList                           000185D18C38 ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer
    // 000 _parser                                  MessageParser`1<IdolSkillStatus> IL2CPP_TYPE_GENERICINST
    // 018 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstIdolSkillIdFieldNumber                int IL2CPP_TYPE_I4
    // 020 MstIdolSkillId                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 LevelFieldNumber                         int IL2CPP_TYPE_I4
    // 028 Level                                    00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    // 000 UnlockPremiseEvolutionLevelFieldNumber   int IL2CPP_TYPE_I4
    // 030 UnlockPremiseEvolutionLevel              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 AppealTypeListFieldNumber                int IL2CPP_TYPE_I4
    // 008 _repeated_appealTypeList_codec           FieldCodec`1<ProduceParameterType> IL2CPP_TYPE_GENERICINST
    // 038 AppealTypeList                           000185CEC248 ModelEnumListType RepeatedField`1<ProduceParameterType> RepeatedField`1<ProduceParameterType> List<ProduceParameterType> Pointer
    // 000 IdolSkillActionEffectListFieldNumber     int IL2CPP_TYPE_I4
    // 010 _repeated_idolSkillActionEffectList_codec FieldCodec`1<IdolSkillEffectStatus> IL2CPP_TYPE_GENERICINST
    // 040 IdolSkillActionEffectList                000185CE01E8 ModelClassListType RepeatedField`1<IdolSkillEffectStatus> RepeatedField`1<IdolSkillEffectStatus> List<IdolSkillEffectStatus> Pointer
    public partial class IdolSkillStatus : DataModel
    {
        public List<ProduceParameterType>?              AppealTypeList                          { get; set; }
        public int                                      MstIdolSkillId                          { get; set; }
        public LimitedValueStatus?                      Level                                   { get; set; }
        public int                                      UnlockPremiseEvolutionLevel             { get; set; }
        public List<IdolSkillEffectStatus>?             IdolSkillActionEffectList               { get; set; }

        public static IdolSkillStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolSkillStatus() { Pointer= p0 };

            value.AppealTypeList                            = GetEnumList<ProduceParameterType>(new IntPtr(p + 0x038)); // 024660FBACC0 0x38 AppealTypeList              ( 000185CEC248 ModelEnumListType RepeatedField`1<ProduceParameterType> RepeatedField`1<ProduceParameterType> List<ProduceParameterType> Pointer )
            value.MstIdolSkillId                            = GetInt32(new IntPtr(p + 0x020)); // 024660FBABE0 0x20 MstIdolSkillId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Level                                     = GetObject<LimitedValueStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 024660FBAC20 0x28 Level                       ( 00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )
            value.UnlockPremiseEvolutionLevel               = GetInt32(new IntPtr(p + 0x030)); // 024660FBAC60 0x30 UnlockPremiseEvolutionLevel ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IdolSkillActionEffectList                 = GetObjectList<IdolSkillEffectStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IdolSkillEffectStatus.FromPointer); // 024660FBAD20 0x40 IdolSkillActionEffectList   ( 000185CE01E8 ModelClassListType RepeatedField`1<IdolSkillEffectStatus> RepeatedField`1<IdolSkillEffectStatus> List<IdolSkillEffectStatus> Pointer )

            return value;
        }
    }
}
