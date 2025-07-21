using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 MstProduceActionEffectTypeId             ModelPrimitiveType int int int Int32
    // 018 ValueList                                ModelPrimitiveListType int[] int[] List<int> Pointer
    // 020 MstProduceActionEffectConditionTypeId    ModelPrimitiveType int int int Int32
    // 024 ConditionValue                           ModelPrimitiveType int int int Int32
    // 028 SubMstProduceActionEffectConditionTypeId ModelPrimitiveType int int int Int32
    // 02C SubConditionValue                        ModelPrimitiveType int int int Int32
    // 030 IsHideConditionEffect                    ModelPrimitiveType bool bool bool Bool
    // 034 MstProduceActionEffectActivationTimingTypeId ModelPrimitiveType int int int Int32
    // 038 MstSkillBufferDisplayId                  ModelPrimitiveType int int int Int32
    // 03C GrantMstSkillBufferDisplayId             ModelPrimitiveType int int int Int32
    // 040 MstProduceActionEffectDisplayIdList      ModelPrimitiveListType int[] int[] List<int> Pointer
    // 048 IconId                                   ModelPrimitiveType int int int Int32
    public partial class MstProduceActionEffect : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstProduceActionEffectTypeId            { get; set; }
        public List<int>?                               ValueList                               { get; set; }
        public int                                      MstProduceActionEffectConditionTypeId   { get; set; }
        public int                                      ConditionValue                          { get; set; }
        public int                                      SubMstProduceActionEffectConditionTypeId { get; set; }
        public int                                      SubConditionValue                       { get; set; }
        public bool                                     IsHideConditionEffect                   { get; set; }
        public int                                      MstProduceActionEffectActivationTimingTypeId { get; set; }
        public int                                      MstSkillBufferDisplayId                 { get; set; }
        public int                                      GrantMstSkillBufferDisplayId            { get; set; }
        public List<int>?                               MstProduceActionEffectDisplayIdList     { get; set; }
        public int                                      IconId                                  { get; set; }

        public static MstProduceActionEffect? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstProduceActionEffect() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.MstProduceActionEffectTypeId              = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstProduceActionEffectTypeId ( ModelPrimitiveType int int int Int32 )
            value.ValueList                                 = GetInt32List(new IntPtr(p + 0x018)); // 0x18 ValueList                   ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.MstProduceActionEffectConditionTypeId     = GetInt32(new IntPtr(p + 0x020)); // 0x20 MstProduceActionEffectConditionTypeId ( ModelPrimitiveType int int int Int32 )
            value.ConditionValue                            = GetInt32(new IntPtr(p + 0x024)); // 0x24 ConditionValue              ( ModelPrimitiveType int int int Int32 )
            value.SubMstProduceActionEffectConditionTypeId  = GetInt32(new IntPtr(p + 0x028)); // 0x28 SubMstProduceActionEffectConditionTypeId ( ModelPrimitiveType int int int Int32 )
            value.SubConditionValue                         = GetInt32(new IntPtr(p + 0x02C)); // 0x2C SubConditionValue           ( ModelPrimitiveType int int int Int32 )
            value.IsHideConditionEffect                     = GetBool(new IntPtr(p + 0x030)); // 0x30 IsHideConditionEffect       ( ModelPrimitiveType bool bool bool Bool )
            value.MstProduceActionEffectActivationTimingTypeId = GetInt32(new IntPtr(p + 0x034)); // 0x34 MstProduceActionEffectActivationTimingTypeId ( ModelPrimitiveType int int int Int32 )
            value.MstSkillBufferDisplayId                   = GetInt32(new IntPtr(p + 0x038)); // 0x38 MstSkillBufferDisplayId     ( ModelPrimitiveType int int int Int32 )
            value.GrantMstSkillBufferDisplayId              = GetInt32(new IntPtr(p + 0x03C)); // 0x3C GrantMstSkillBufferDisplayId ( ModelPrimitiveType int int int Int32 )
            value.MstProduceActionEffectDisplayIdList       = GetInt32List(new IntPtr(p + 0x040)); // 0x40 MstProduceActionEffectDisplayIdList ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.IconId                                    = GetInt32(new IntPtr(p + 0x048)); // 0x48 IconId                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
