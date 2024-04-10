using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstIdolSkillId                           0001865F4260 ModelPrimitiveType int int int Int32
    // 014 IconId                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 018 Pp                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 020 AppealTypeList                           000185D18D28 ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer
    // 028 Level                                    0001865F4260 ModelPrimitiveType int int int Int32
    // 030 SkillActionEffectList                    000185CFDCC8 ModelClassListType IReadOnlyList`1<IIdolSkillActionEffectStatus> IReadOnlyList`1<IIdolSkillActionEffectStatus> List<IIdolSkillActionEffectStatus> Pointer
    // 038 ActionCondition                          000186576720 ModelClassType IIdolSkillActionConditionStatus IIdolSkillActionConditionStatus IIdolSkillActionConditionStatus Pointer
    public partial class IdolSkillSingleDetailPopupViewModel : DataModel
    {
        public int                                      MstIdolSkillId                          { get; set; }
        public int                                      IconId                                  { get; set; }
        public int                                      Pp                                      { get; set; }
        public List<ProduceParameterType>?              AppealTypeList                          { get; set; }
        public int                                      Level                                   { get; set; }
        public List<IIdolSkillActionEffectStatus>?      SkillActionEffectList                   { get; set; }
        public IIdolSkillActionConditionStatus?         ActionCondition                         { get; set; }

        public static IdolSkillSingleDetailPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolSkillSingleDetailPopupViewModel() { Pointer= p0 };

            value.MstIdolSkillId                            = GetInt32(new IntPtr(p + 0x010)); // 024666249020 0x10 MstIdolSkillId              ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.IconId                                    = GetInt32(new IntPtr(p + 0x014)); // 024666249040 0x14 IconId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Pp                                        = GetInt32(new IntPtr(p + 0x018)); // 024666249060 0x18 Pp                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.AppealTypeList                            = GetEnumList<ProduceParameterType>(new IntPtr(p + 0x020)); // 024666249080 0x20 AppealTypeList              ( 000185D18D28 ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer )
            value.Level                                     = GetInt32(new IntPtr(p + 0x028)); // 0246662490A0 0x28 Level                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.SkillActionEffectList                     = GetObjectList<IIdolSkillActionEffectStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IIdolSkillActionEffectStatus.FromPointer); // 0246662490C0 0x30 SkillActionEffectList       ( 000185CFDCC8 ModelClassListType IReadOnlyList`1<IIdolSkillActionEffectStatus> IReadOnlyList`1<IIdolSkillActionEffectStatus> List<IIdolSkillActionEffectStatus> Pointer )
            value.ActionCondition                           = GetObject<IIdolSkillActionConditionStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IIdolSkillActionConditionStatus.FromPointer); // 0246662490E0 0x38 ActionCondition             ( 000186576720 ModelClassType IIdolSkillActionConditionStatus IIdolSkillActionConditionStatus IIdolSkillActionConditionStatus Pointer )

            return value;
        }
    }
}
