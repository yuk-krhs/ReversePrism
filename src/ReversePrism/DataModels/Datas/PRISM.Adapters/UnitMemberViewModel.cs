using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SortIndex                                ModelPrimitiveType int int int Int32
    // 018 Icon                                     ModelClassType FIdolIcon FIdolIcon FIdolIcon Pointer
    // 020 SkillId                                  ModelPrimitiveType int int int Int32
    // 024 IdolSkillLv                              ModelPrimitiveType int int int Int32
    // 028 IdolSkillIconId                          ModelPrimitiveType int int int Int32
    // 030 AttachedIdolSkillDetailValueList         ModelClassListType IReadOnlyList`1<IIdolSkillActionEffectStatus> IReadOnlyList`1<IIdolSkillActionEffectStatus> List<IIdolSkillActionEffectStatus> Pointer
    // 038 Cost                                     ModelPrimitiveType int int int Int32
    // 040 AppealTypeList                           ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 048 Parameter                                ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer
    // 050 LiveSkillViewModel                       ModelClassType LiveSkillViewModel LiveSkillViewModel LiveSkillViewModel Pointer
    // 058 IdolSkillActionCondition                 ModelClassType IIdolSkillActionConditionStatus IIdolSkillActionConditionStatus IIdolSkillActionConditionStatus Pointer
    // 060 ParameterDetailViewModel                 ModelClassType PFIdolParameterDetailPopupViewModel PFIdolParameterDetailPopupViewModel PFIdolParameterDetailPopupViewModel Pointer
    public partial class UnitMemberViewModel : DataModel
    {
        public int                                      SortIndex                               { get; set; }
        public FIdolIcon?                               Icon                                    { get; set; }
        public int                                      SkillId                                 { get; set; }
        public int                                      IdolSkillLv                             { get; set; }
        public int                                      IdolSkillIconId                         { get; set; }
        public List<IIdolSkillActionEffectStatus>?      AttachedIdolSkillDetailValueList        { get; set; }
        public int                                      Cost                                    { get; set; }
        public List<int>?                               AppealTypeList                          { get; set; }
        public IProduceParameterStatus?                 Parameter                               { get; set; }
        public LiveSkillViewModel?                      LiveSkillViewModel                      { get; set; }
        public IIdolSkillActionConditionStatus?         IdolSkillActionCondition                { get; set; }
        public PFIdolParameterDetailPopupViewModel?     ParameterDetailViewModel                { get; set; }

        public static UnitMemberViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnitMemberViewModel() { Pointer= p0 };

            value.SortIndex                                 = GetInt32(new IntPtr(p + 0x010)); // 0x10 SortIndex                   ( ModelPrimitiveType int int int Int32 )
            value.Icon                                      = GetObject<FIdolIcon>(new IntPtr(p + 0x018), ReversePrism.DataModels.FIdolIcon.FromPointer); // 0x18 Icon                        ( ModelClassType FIdolIcon FIdolIcon FIdolIcon Pointer )
            value.SkillId                                   = GetInt32(new IntPtr(p + 0x020)); // 0x20 SkillId                     ( ModelPrimitiveType int int int Int32 )
            value.IdolSkillLv                               = GetInt32(new IntPtr(p + 0x024)); // 0x24 IdolSkillLv                 ( ModelPrimitiveType int int int Int32 )
            value.IdolSkillIconId                           = GetInt32(new IntPtr(p + 0x028)); // 0x28 IdolSkillIconId             ( ModelPrimitiveType int int int Int32 )
            value.AttachedIdolSkillDetailValueList          = GetObjectList<IIdolSkillActionEffectStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IIdolSkillActionEffectStatus.FromPointer); // 0x30 AttachedIdolSkillDetailValueList ( ModelClassListType IReadOnlyList`1<IIdolSkillActionEffectStatus> IReadOnlyList`1<IIdolSkillActionEffectStatus> List<IIdolSkillActionEffectStatus> Pointer )
            value.Cost                                      = GetInt32(new IntPtr(p + 0x038)); // 0x38 Cost                        ( ModelPrimitiveType int int int Int32 )
            value.AppealTypeList                            = GetInt32List(new IntPtr(p + 0x040)); // 0x40 AppealTypeList              ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.Parameter                                 = GetObject<IProduceParameterStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.IProduceParameterStatus.FromPointer); // 0x48 Parameter                   ( ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer )
            value.LiveSkillViewModel                        = GetObject<LiveSkillViewModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.LiveSkillViewModel.FromPointer); // 0x50 LiveSkillViewModel          ( ModelClassType LiveSkillViewModel LiveSkillViewModel LiveSkillViewModel Pointer )
            value.IdolSkillActionCondition                  = GetObject<IIdolSkillActionConditionStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.IIdolSkillActionConditionStatus.FromPointer); // 0x58 IdolSkillActionCondition    ( ModelClassType IIdolSkillActionConditionStatus IIdolSkillActionConditionStatus IIdolSkillActionConditionStatus Pointer )
            value.ParameterDetailViewModel                  = GetObject<PFIdolParameterDetailPopupViewModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.PFIdolParameterDetailPopupViewModel.FromPointer); // 0x60 ParameterDetailViewModel    ( ModelClassType PFIdolParameterDetailPopupViewModel PFIdolParameterDetailPopupViewModel PFIdolParameterDetailPopupViewModel Pointer )

            return value;
        }
    }
}
