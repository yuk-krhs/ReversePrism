using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Level                                    0001865F4260 ModelPrimitiveType int int int Int32
    // 014 UnlockPremiseStar                        0001865F4260 ModelPrimitiveType int int int Int32
    // 018 Pp                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 01C Cost                                     0001865F4260 ModelPrimitiveType int int int Int32
    // 020 ActionCondition                          000186576720 ModelClassType IIdolSkillActionConditionStatus IIdolSkillActionConditionStatus IIdolSkillActionConditionStatus Pointer
    // 028 EffectList                               000185CFDCC8 ModelClassListType IReadOnlyList`1<IIdolSkillActionEffectStatus> IReadOnlyList`1<IIdolSkillActionEffectStatus> List<IIdolSkillActionEffectStatus> Pointer
    public partial class IdolSkillLevelViewModel : DataModel
    {
        public int                                      Level                                   { get; set; }
        public int                                      UnlockPremiseStar                       { get; set; }
        public int                                      Pp                                      { get; set; }
        public int                                      Cost                                    { get; set; }
        public IIdolSkillActionConditionStatus?         ActionCondition                         { get; set; }
        public List<IIdolSkillActionEffectStatus>?      EffectList                              { get; set; }

        public static IdolSkillLevelViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolSkillLevelViewModel() { Pointer= p0 };

            value.Level                                     = GetInt32(new IntPtr(p + 0x010)); // 024665FEB718 0x10 Level                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.UnlockPremiseStar                         = GetInt32(new IntPtr(p + 0x014)); // 024665FEB738 0x14 UnlockPremiseStar           ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Pp                                        = GetInt32(new IntPtr(p + 0x018)); // 024665FEB758 0x18 Pp                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Cost                                      = GetInt32(new IntPtr(p + 0x01C)); // 024665FEB778 0x1C Cost                        ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ActionCondition                           = GetObject<IIdolSkillActionConditionStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IIdolSkillActionConditionStatus.FromPointer); // 024665FEB798 0x20 ActionCondition             ( 000186576720 ModelClassType IIdolSkillActionConditionStatus IIdolSkillActionConditionStatus IIdolSkillActionConditionStatus Pointer )
            value.EffectList                                = GetObjectList<IIdolSkillActionEffectStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IIdolSkillActionEffectStatus.FromPointer); // 024665FEB7B8 0x28 EffectList                  ( 000185CFDCC8 ModelClassListType IReadOnlyList`1<IIdolSkillActionEffectStatus> IReadOnlyList`1<IIdolSkillActionEffectStatus> List<IIdolSkillActionEffectStatus> Pointer )

            return value;
        }
    }
}
