using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FesIdolAttachedIdolSkillStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstIdolSkillIdFieldNumber                int IL2CPP_TYPE_I4
    // 018 MstIdolSkillId                           ModelPrimitiveType int int int Int32
    // 000 LevelFieldNumber                         int IL2CPP_TYPE_I4
    // 01C Level                                    ModelPrimitiveType int int int Int32
    // 000 PpFieldNumber                            int IL2CPP_TYPE_I4
    // 020 Pp                                       ModelPrimitiveType int int int Int32
    // 000 AppealTypeListFieldNumber                int IL2CPP_TYPE_I4
    // 008 _repeated_appealTypeList_codec           FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 028 AppealTypeList                           ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 ActionEffectListFieldNumber              int IL2CPP_TYPE_I4
    // 010 _repeated_actionEffectList_codec         FieldCodec`1<IdolSkillActionEffectStatus> IL2CPP_TYPE_GENERICINST
    // 030 ActionEffectList                         ModelClassListType RepeatedField`1<IdolSkillActionEffectStatus> RepeatedField`1<IdolSkillActionEffectStatus> List<IdolSkillActionEffectStatus> Pointer
    // 000 ActionConditionFieldNumber               int IL2CPP_TYPE_I4
    // 038 ActionCondition                          ModelClassType IdolSkillActionConditionStatus IdolSkillActionConditionStatus IdolSkillActionConditionStatus Pointer
    public partial class FesIdolAttachedIdolSkillStatus : DataModel
    {
        public int                                      MstIdolSkillId                          { get; set; }
        public int                                      Level                                   { get; set; }
        public int                                      Pp                                      { get; set; }
        public List<int>?                               AppealTypeList                          { get; set; }
        public List<IdolSkillActionEffectStatus>?       ActionEffectList                        { get; set; }
        public IdolSkillActionConditionStatus?          ActionCondition                         { get; set; }

        public static FesIdolAttachedIdolSkillStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FesIdolAttachedIdolSkillStatus() { Pointer= p0 };

            value.MstIdolSkillId                            = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstIdolSkillId              ( ModelPrimitiveType int int int Int32 )
            value.Level                                     = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Level                       ( ModelPrimitiveType int int int Int32 )
            value.Pp                                        = GetInt32(new IntPtr(p + 0x020)); // 0x20 Pp                          ( ModelPrimitiveType int int int Int32 )
            value.AppealTypeList                            = GetInt32List(new IntPtr(p + 0x028)); // 0x28 AppealTypeList              ( ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.ActionEffectList                          = GetObjectList<IdolSkillActionEffectStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IdolSkillActionEffectStatus.FromPointer); // 0x30 ActionEffectList            ( ModelClassListType RepeatedField`1<IdolSkillActionEffectStatus> RepeatedField`1<IdolSkillActionEffectStatus> List<IdolSkillActionEffectStatus> Pointer )
            value.ActionCondition                           = GetObject<IdolSkillActionConditionStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IdolSkillActionConditionStatus.FromPointer); // 0x38 ActionCondition             ( ModelClassType IdolSkillActionConditionStatus IdolSkillActionConditionStatus IdolSkillActionConditionStatus Pointer )

            return value;
        }
    }
}
