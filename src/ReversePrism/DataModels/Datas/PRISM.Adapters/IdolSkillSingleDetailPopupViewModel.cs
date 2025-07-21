using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstIdolSkillId                           ModelPrimitiveType int int int Int32
    // 014 IconId                                   ModelPrimitiveType int int int Int32
    // 018 Pp                                       ModelPrimitiveType int int int Int32
    // 020 AppealTypeList                           ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer
    // 028 Level                                    ModelPrimitiveType int int int Int32
    // 030 SkillActionEffectList                    ModelClassListType IReadOnlyList`1<IIdolSkillActionEffectStatus> IReadOnlyList`1<IIdolSkillActionEffectStatus> List<IIdolSkillActionEffectStatus> Pointer
    // 038 ActionCondition                          ModelClassType IIdolSkillActionConditionStatus IIdolSkillActionConditionStatus IIdolSkillActionConditionStatus Pointer
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

            value.MstIdolSkillId                            = GetInt32(new IntPtr(p + 0x010)); // 0x10 MstIdolSkillId              ( ModelPrimitiveType int int int Int32 )
            value.IconId                                    = GetInt32(new IntPtr(p + 0x014)); // 0x14 IconId                      ( ModelPrimitiveType int int int Int32 )
            value.Pp                                        = GetInt32(new IntPtr(p + 0x018)); // 0x18 Pp                          ( ModelPrimitiveType int int int Int32 )
            value.AppealTypeList                            = GetEnumList<ProduceParameterType>(new IntPtr(p + 0x020)); // 0x20 AppealTypeList              ( ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer )
            value.Level                                     = GetInt32(new IntPtr(p + 0x028)); // 0x28 Level                       ( ModelPrimitiveType int int int Int32 )
            value.SkillActionEffectList                     = GetObjectList<IIdolSkillActionEffectStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IIdolSkillActionEffectStatus.FromPointer); // 0x30 SkillActionEffectList       ( ModelClassListType IReadOnlyList`1<IIdolSkillActionEffectStatus> IReadOnlyList`1<IIdolSkillActionEffectStatus> List<IIdolSkillActionEffectStatus> Pointer )
            value.ActionCondition                           = GetObject<IIdolSkillActionConditionStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IIdolSkillActionConditionStatus.FromPointer); // 0x38 ActionCondition             ( ModelClassType IIdolSkillActionConditionStatus IIdolSkillActionConditionStatus IIdolSkillActionConditionStatus Pointer )

            return value;
        }
    }
}
