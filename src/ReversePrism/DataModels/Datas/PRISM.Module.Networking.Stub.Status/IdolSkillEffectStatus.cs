using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<IdolSkillEffectStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 LevelFieldNumber                         int IL2CPP_TYPE_I4
    // 018 Level                                    ModelPrimitiveType int int int Int32
    // 000 UnlockPremiseStarFieldNumber             int IL2CPP_TYPE_I4
    // 01C UnlockPremiseStar                        ModelPrimitiveType int int int Int32
    // 000 PpFieldNumber                            int IL2CPP_TYPE_I4
    // 020 Pp                                       ModelPrimitiveType int int int Int32
    // 000 CostFieldNumber                          int IL2CPP_TYPE_I4
    // 024 Cost                                     ModelPrimitiveType int int int Int32
    // 000 ProductRecipeListFieldNumber             int IL2CPP_TYPE_I4
    // 008 _repeated_productRecipeList_codec        FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 028 ProductRecipeList                        ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    // 000 MoneyFieldNumber                         int IL2CPP_TYPE_I4
    // 030 Money                                    ModelPrimitiveType int int int Int32
    // 000 ActionEffectListFieldNumber              int IL2CPP_TYPE_I4
    // 010 _repeated_actionEffectList_codec         FieldCodec`1<IdolSkillActionEffectStatus> IL2CPP_TYPE_GENERICINST
    // 038 ActionEffectList                         ModelClassListType RepeatedField`1<IdolSkillActionEffectStatus> RepeatedField`1<IdolSkillActionEffectStatus> List<IdolSkillActionEffectStatus> Pointer
    // 000 ActionConditionFieldNumber               int IL2CPP_TYPE_I4
    // 040 ActionCondition                          ModelClassType IdolSkillActionConditionStatus IdolSkillActionConditionStatus IdolSkillActionConditionStatus Pointer
    public partial class IdolSkillEffectStatus : DataModel
    {
        public int                                      Level                                   { get; set; }
        public int                                      UnlockPremiseStar                       { get; set; }
        public int                                      Pp                                      { get; set; }
        public int                                      Cost                                    { get; set; }
        public List<ProductWithAmountStatus>?           ProductRecipeList                       { get; set; }
        public int                                      Money                                   { get; set; }
        public List<IdolSkillActionEffectStatus>?       ActionEffectList                        { get; set; }
        public IdolSkillActionConditionStatus?          ActionCondition                         { get; set; }

        public static IdolSkillEffectStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolSkillEffectStatus() { Pointer= p0 };

            value.Level                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 Level                       ( ModelPrimitiveType int int int Int32 )
            value.UnlockPremiseStar                         = GetInt32(new IntPtr(p + 0x01C)); // 0x1C UnlockPremiseStar           ( ModelPrimitiveType int int int Int32 )
            value.Pp                                        = GetInt32(new IntPtr(p + 0x020)); // 0x20 Pp                          ( ModelPrimitiveType int int int Int32 )
            value.Cost                                      = GetInt32(new IntPtr(p + 0x024)); // 0x24 Cost                        ( ModelPrimitiveType int int int Int32 )
            value.ProductRecipeList                         = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0x28 ProductRecipeList           ( ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )
            value.Money                                     = GetInt32(new IntPtr(p + 0x030)); // 0x30 Money                       ( ModelPrimitiveType int int int Int32 )
            value.ActionEffectList                          = GetObjectList<IdolSkillActionEffectStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IdolSkillActionEffectStatus.FromPointer); // 0x38 ActionEffectList            ( ModelClassListType RepeatedField`1<IdolSkillActionEffectStatus> RepeatedField`1<IdolSkillActionEffectStatus> List<IdolSkillActionEffectStatus> Pointer )
            value.ActionCondition                           = GetObject<IdolSkillActionConditionStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IdolSkillActionConditionStatus.FromPointer); // 0x40 ActionCondition             ( ModelClassType IdolSkillActionConditionStatus IdolSkillActionConditionStatus IdolSkillActionConditionStatus Pointer )

            return value;
        }
    }
}
