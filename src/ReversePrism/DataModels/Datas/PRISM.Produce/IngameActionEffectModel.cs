using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 produceCardDescription                   string IL2CPP_TYPE_STRING
    // 010 BaseDescription                          ModelPrimitiveType string string string String
    // 018 EffectValues                             ModelPrimitiveListType int[] int[] List<int> Pointer
    // 020 EffectID                                 ModelPrimitiveType int int int Int32
    // 024 EffectTypeID                             ModelPrimitiveType int int int Int32
    // 028 ConditionTypeID                          ModelPrimitiveType int int int Int32
    // 02C ConditionValue                           ModelPrimitiveType int int int Int32
    // 030 SubConditionTypeID                       ModelPrimitiveType int int int Int32
    // 034 SubConditionValue                        ModelPrimitiveType int int int Int32
    // 038 EffectDisplayIDs                         ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer
    // 040 IdAndValues                              ValueTuple`2<int, IReadOnlyList`1<int>> IL2CPP_TYPE_GENERICINST
    // 050 IconID                                   ModelPrimitiveType int int int Int32
    // 058 SkillBufferDisplay                       ModelClassType ISkillBufferDisplayStatus ISkillBufferDisplayStatus ISkillBufferDisplayStatus Pointer
    // 060 ActivationTimingTypeId                   ModelPrimitiveType int int int Int32
    // 064 IsHideConditionEffect                    ModelPrimitiveType bool bool bool Bool
    // 068 GrantSkillBufferDisplay                  ModelClassType ISkillBufferDisplayStatus ISkillBufferDisplayStatus ISkillBufferDisplayStatus Pointer
    // 070 AppealTypeList                           ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer
    public partial class IngameActionEffectModel : DataModel
    {
        public string                                   BaseDescription                         { get; set; }
        public List<int>?                               EffectValues                            { get; set; }
        public int                                      EffectID                                { get; set; }
        public int                                      EffectTypeID                            { get; set; }
        public int                                      ConditionTypeID                         { get; set; }
        public int                                      ConditionValue                          { get; set; }
        public int                                      SubConditionTypeID                      { get; set; }
        public int                                      SubConditionValue                       { get; set; }
        public List<int>?                               EffectDisplayIDs                        { get; set; }
        public int                                      IconID                                  { get; set; }
        public ISkillBufferDisplayStatus?               SkillBufferDisplay                      { get; set; }
        public int                                      ActivationTimingTypeId                  { get; set; }
        public bool                                     IsHideConditionEffect                   { get; set; }
        public ISkillBufferDisplayStatus?               GrantSkillBufferDisplay                 { get; set; }
        public List<ProduceParameterType>?              AppealTypeList                          { get; set; }

        public static IngameActionEffectModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IngameActionEffectModel() { Pointer= p0 };

            value.BaseDescription                           = GetString(new IntPtr(p + 0x010)); // 0x10 BaseDescription             ( ModelPrimitiveType string string string String )
            value.EffectValues                              = GetInt32List(new IntPtr(p + 0x018)); // 0x18 EffectValues                ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.EffectID                                  = GetInt32(new IntPtr(p + 0x020)); // 0x20 EffectID                    ( ModelPrimitiveType int int int Int32 )
            value.EffectTypeID                              = GetInt32(new IntPtr(p + 0x024)); // 0x24 EffectTypeID                ( ModelPrimitiveType int int int Int32 )
            value.ConditionTypeID                           = GetInt32(new IntPtr(p + 0x028)); // 0x28 ConditionTypeID             ( ModelPrimitiveType int int int Int32 )
            value.ConditionValue                            = GetInt32(new IntPtr(p + 0x02C)); // 0x2C ConditionValue              ( ModelPrimitiveType int int int Int32 )
            value.SubConditionTypeID                        = GetInt32(new IntPtr(p + 0x030)); // 0x30 SubConditionTypeID          ( ModelPrimitiveType int int int Int32 )
            value.SubConditionValue                         = GetInt32(new IntPtr(p + 0x034)); // 0x34 SubConditionValue           ( ModelPrimitiveType int int int Int32 )
            value.EffectDisplayIDs                          = GetInt32List(new IntPtr(p + 0x038)); // 0x38 EffectDisplayIDs            ( ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer )
            value.IconID                                    = GetInt32(new IntPtr(p + 0x050)); // 0x50 IconID                      ( ModelPrimitiveType int int int Int32 )
            value.SkillBufferDisplay                        = GetObject<ISkillBufferDisplayStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.ISkillBufferDisplayStatus.FromPointer); // 0x58 SkillBufferDisplay          ( ModelClassType ISkillBufferDisplayStatus ISkillBufferDisplayStatus ISkillBufferDisplayStatus Pointer )
            value.ActivationTimingTypeId                    = GetInt32(new IntPtr(p + 0x060)); // 0x60 ActivationTimingTypeId      ( ModelPrimitiveType int int int Int32 )
            value.IsHideConditionEffect                     = GetBool(new IntPtr(p + 0x064)); // 0x64 IsHideConditionEffect       ( ModelPrimitiveType bool bool bool Bool )
            value.GrantSkillBufferDisplay                   = GetObject<ISkillBufferDisplayStatus>(new IntPtr(p + 0x068), ReversePrism.DataModels.ISkillBufferDisplayStatus.FromPointer); // 0x68 GrantSkillBufferDisplay     ( ModelClassType ISkillBufferDisplayStatus ISkillBufferDisplayStatus ISkillBufferDisplayStatus Pointer )
            value.AppealTypeList                            = GetEnumList<ProduceParameterType>(new IntPtr(p + 0x070)); // 0x70 AppealTypeList              ( ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer )

            return value;
        }
    }
}
