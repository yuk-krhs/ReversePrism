using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SortIndex                                0001865F4260 ModelPrimitiveType int int int Int32
    // 018 Icon                                     0001865452F0 ModelClassType FIdolIcon FIdolIcon FIdolIcon Pointer
    // 020 SkillId                                  0001865F4260 ModelPrimitiveType int int int Int32
    // 024 IdolSkillLv                              0001865F4260 ModelPrimitiveType int int int Int32
    // 028 IdolSkillIconId                          0001865F4260 ModelPrimitiveType int int int Int32
    // 030 AttachedIdolSkillDetailValueList         000185CFDCC8 ModelClassListType IReadOnlyList`1<IIdolSkillActionEffectStatus> IReadOnlyList`1<IIdolSkillActionEffectStatus> List<IIdolSkillActionEffectStatus> Pointer
    // 038 Cost                                     0001865F4260 ModelPrimitiveType int int int Int32
    // 040 AppealTypeList                           000185CED1B8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 048 Parameter                                0001865EF590 ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer
    // 050 LiveSkillViewModel                       000186580190 ModelClassType LiveSkillViewModel LiveSkillViewModel LiveSkillViewModel Pointer
    // 058 IdolSkillActionCondition                 000186576720 ModelClassType IIdolSkillActionConditionStatus IIdolSkillActionConditionStatus IIdolSkillActionConditionStatus Pointer
    // 060 ParameterDetailViewModel                 000186705F00 ModelClassType PFIdolParameterDetailPopupViewModel PFIdolParameterDetailPopupViewModel PFIdolParameterDetailPopupViewModel Pointer
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

            value.SortIndex                                 = GetInt32(new IntPtr(p + 0x010)); // 024665FA0F90 0x10 SortIndex                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Icon                                      = GetObject<FIdolIcon>(new IntPtr(p + 0x018), ReversePrism.DataModels.FIdolIcon.FromPointer); // 024665FA0FB0 0x18 Icon                        ( 0001865452F0 ModelClassType FIdolIcon FIdolIcon FIdolIcon Pointer )
            value.SkillId                                   = GetInt32(new IntPtr(p + 0x020)); // 024665FA0FD0 0x20 SkillId                     ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.IdolSkillLv                               = GetInt32(new IntPtr(p + 0x024)); // 024665FA0FF0 0x24 IdolSkillLv                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.IdolSkillIconId                           = GetInt32(new IntPtr(p + 0x028)); // 024665FA1010 0x28 IdolSkillIconId             ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.AttachedIdolSkillDetailValueList          = GetObjectList<IIdolSkillActionEffectStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IIdolSkillActionEffectStatus.FromPointer); // 024665FA1030 0x30 AttachedIdolSkillDetailValueList ( 000185CFDCC8 ModelClassListType IReadOnlyList`1<IIdolSkillActionEffectStatus> IReadOnlyList`1<IIdolSkillActionEffectStatus> List<IIdolSkillActionEffectStatus> Pointer )
            value.Cost                                      = GetInt32(new IntPtr(p + 0x038)); // 024665FA1050 0x38 Cost                        ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.AppealTypeList                            = GetInt32List(new IntPtr(p + 0x040)); // 024665FA1070 0x40 AppealTypeList              ( 000185CED1B8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.Parameter                                 = GetObject<IProduceParameterStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.IProduceParameterStatus.FromPointer); // 024665FA1090 0x48 Parameter                   ( 0001865EF590 ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer )
            value.LiveSkillViewModel                        = GetObject<LiveSkillViewModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.LiveSkillViewModel.FromPointer); // 024665FA10B0 0x50 LiveSkillViewModel          ( 000186580190 ModelClassType LiveSkillViewModel LiveSkillViewModel LiveSkillViewModel Pointer )
            value.IdolSkillActionCondition                  = GetObject<IIdolSkillActionConditionStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.IIdolSkillActionConditionStatus.FromPointer); // 024665FA10D0 0x58 IdolSkillActionCondition    ( 000186576720 ModelClassType IIdolSkillActionConditionStatus IIdolSkillActionConditionStatus IIdolSkillActionConditionStatus Pointer )
            value.ParameterDetailViewModel                  = GetObject<PFIdolParameterDetailPopupViewModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.PFIdolParameterDetailPopupViewModel.FromPointer); // 024665FA10F0 0x60 ParameterDetailViewModel    ( 000186705F00 ModelClassType PFIdolParameterDetailPopupViewModel PFIdolParameterDetailPopupViewModel PFIdolParameterDetailPopupViewModel Pointer )

            return value;
        }
    }
}
