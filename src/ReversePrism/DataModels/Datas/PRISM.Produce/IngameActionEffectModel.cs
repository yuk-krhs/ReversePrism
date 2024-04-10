using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 produceCardDescription                   string IL2CPP_TYPE_STRING
    // 010 BaseDescription                          000186672F10 ModelPrimitiveType string string string String
    // 018 EffectValues                             000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 020 EffectID                                 0001865F4940 ModelPrimitiveType int int int Int32
    // 024 EffectTypeID                             0001865F4940 ModelPrimitiveType int int int Int32
    // 028 ConditionTypeID                          0001865F4940 ModelPrimitiveType int int int Int32
    // 02C ConditionValue                           0001865F4940 ModelPrimitiveType int int int Int32
    // 030 EffectDisplayIDs                         000185D11FB8 ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer
    // 038 IdAndValues                              ValueTuple`2<int, IReadOnlyList`1<int>> IL2CPP_TYPE_GENERICINST
    // 048 IconID                                   0001865F4940 ModelPrimitiveType int int int Int32
    // 050 SkillBufferDisplay                       000186646FB0 ModelClassType ISkillBufferDisplayStatus ISkillBufferDisplayStatus ISkillBufferDisplayStatus Pointer
    // 058 ActivationTimingTypeId                   0001865F4940 ModelPrimitiveType int int int Int32
    // 05C IsHideConditionEffect                    000186596AF0 ModelPrimitiveType bool bool bool Bool
    // 060 GrantSkillBufferDisplay                  000186646FB0 ModelClassType ISkillBufferDisplayStatus ISkillBufferDisplayStatus ISkillBufferDisplayStatus Pointer
    // 068 AppealTypeList                           000185D18D98 ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer
    public partial class IngameActionEffectModel : DataModel
    {
        public string                                   BaseDescription                         { get; set; }
        public List<int>?                               EffectValues                            { get; set; }
        public int                                      EffectID                                { get; set; }
        public int                                      EffectTypeID                            { get; set; }
        public int                                      ConditionTypeID                         { get; set; }
        public int                                      ConditionValue                          { get; set; }
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

            value.BaseDescription                           = GetString(new IntPtr(p + 0x010)); // 024665A39BF8 0x10 BaseDescription             ( 000186672F10 ModelPrimitiveType string string string String )
            value.EffectValues                              = GetInt32List(new IntPtr(p + 0x018)); // 024665A39C18 0x18 EffectValues                ( 000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.EffectID                                  = GetInt32(new IntPtr(p + 0x020)); // 024665A39C38 0x20 EffectID                    ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.EffectTypeID                              = GetInt32(new IntPtr(p + 0x024)); // 024665A39C58 0x24 EffectTypeID                ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.ConditionTypeID                           = GetInt32(new IntPtr(p + 0x028)); // 024665A39C78 0x28 ConditionTypeID             ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.ConditionValue                            = GetInt32(new IntPtr(p + 0x02C)); // 024665A39C98 0x2C ConditionValue              ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.EffectDisplayIDs                          = GetInt32List(new IntPtr(p + 0x030)); // 024665A39CB8 0x30 EffectDisplayIDs            ( 000185D11FB8 ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer )
            value.IconID                                    = GetInt32(new IntPtr(p + 0x048)); // 024665A39CF8 0x48 IconID                      ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.SkillBufferDisplay                        = GetObject<ISkillBufferDisplayStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.ISkillBufferDisplayStatus.FromPointer); // 024665A39D18 0x50 SkillBufferDisplay          ( 000186646FB0 ModelClassType ISkillBufferDisplayStatus ISkillBufferDisplayStatus ISkillBufferDisplayStatus Pointer )
            value.ActivationTimingTypeId                    = GetInt32(new IntPtr(p + 0x058)); // 024665A39D38 0x58 ActivationTimingTypeId      ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.IsHideConditionEffect                     = GetBool(new IntPtr(p + 0x05C)); // 024665A39D58 0x5C IsHideConditionEffect       ( 000186596AF0 ModelPrimitiveType bool bool bool Bool )
            value.GrantSkillBufferDisplay                   = GetObject<ISkillBufferDisplayStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.ISkillBufferDisplayStatus.FromPointer); // 024665A39D78 0x60 GrantSkillBufferDisplay     ( 000186646FB0 ModelClassType ISkillBufferDisplayStatus ISkillBufferDisplayStatus ISkillBufferDisplayStatus Pointer )
            value.AppealTypeList                            = GetEnumList<ProduceParameterType>(new IntPtr(p + 0x068)); // 024665A39D98 0x68 AppealTypeList              ( 000185D18D98 ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer )

            return value;
        }
    }
}
