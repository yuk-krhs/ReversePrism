using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 MstProduceActionEffectTypeId             0001865F4260 ModelPrimitiveType int int int Int32
    // 018 ValueList                                000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 020 MstProduceActionEffectConditionTypeId    0001865F4260 ModelPrimitiveType int int int Int32
    // 024 ConditionValue                           0001865F4260 ModelPrimitiveType int int int Int32
    // 028 IsHideConditionEffect                    0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 02C MstProduceActionEffectActivationTimingTypeId 0001865F4260 ModelPrimitiveType int int int Int32
    // 030 MstSkillBufferDisplayId                  0001865F4260 ModelPrimitiveType int int int Int32
    // 034 GrantMstSkillBufferDisplayId             0001865F4260 ModelPrimitiveType int int int Int32
    // 038 MstProduceActionEffectDisplayIdList      000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 040 IconId                                   0001865F4260 ModelPrimitiveType int int int Int32
    public partial class MstProduceActionEffect : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstProduceActionEffectTypeId            { get; set; }
        public List<int>?                               ValueList                               { get; set; }
        public int                                      MstProduceActionEffectConditionTypeId   { get; set; }
        public int                                      ConditionValue                          { get; set; }
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

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0245A46ABA48 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstProduceActionEffectTypeId              = GetInt32(new IntPtr(p + 0x014)); // 0245A46ABA68 0x14 MstProduceActionEffectTypeId ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ValueList                                 = GetInt32List(new IntPtr(p + 0x018)); // 0245A46ABA88 0x18 ValueList                   ( 000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.MstProduceActionEffectConditionTypeId     = GetInt32(new IntPtr(p + 0x020)); // 0245A46ABAA8 0x20 MstProduceActionEffectConditionTypeId ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ConditionValue                            = GetInt32(new IntPtr(p + 0x024)); // 0245A46ABAC8 0x24 ConditionValue              ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.IsHideConditionEffect                     = GetBool(new IntPtr(p + 0x028)); // 0245A46ABAE8 0x28 IsHideConditionEffect       ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.MstProduceActionEffectActivationTimingTypeId = GetInt32(new IntPtr(p + 0x02C)); // 0245A46ABB08 0x2C MstProduceActionEffectActivationTimingTypeId ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstSkillBufferDisplayId                   = GetInt32(new IntPtr(p + 0x030)); // 0245A46ABB28 0x30 MstSkillBufferDisplayId     ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.GrantMstSkillBufferDisplayId              = GetInt32(new IntPtr(p + 0x034)); // 0245A46ABB48 0x34 GrantMstSkillBufferDisplayId ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstProduceActionEffectDisplayIdList       = GetInt32List(new IntPtr(p + 0x038)); // 0245A46ABB68 0x38 MstProduceActionEffectDisplayIdList ( 000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.IconId                                    = GetInt32(new IntPtr(p + 0x040)); // 0245A46ABB88 0x40 IconId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
