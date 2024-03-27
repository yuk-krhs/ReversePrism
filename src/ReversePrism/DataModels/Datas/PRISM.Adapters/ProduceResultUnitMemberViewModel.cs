using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OriginalLiveSkillViewModel               000186580190 ModelClassType LiveSkillViewModel LiveSkillViewModel LiveSkillViewModel Pointer
    // 018 SortIndex                                0001865F4260 ModelPrimitiveType int int int Int32
    // 020 Icon                                     0001865452F0 ModelClassType FIdolIcon FIdolIcon FIdolIcon Pointer
    // 028 SkillId                                  0001865F4260 ModelPrimitiveType int int int Int32
    // 02C IdolSkillLv                              0001865F4260 ModelPrimitiveType int int int Int32
    // 030 IdolSkillIconId                          0001865F4260 ModelPrimitiveType int int int Int32
    // 038 AttachedIdolSkillDetailValueList         000185CFDCC8 ModelClassListType IReadOnlyList`1<IIdolSkillActionEffectStatus> IReadOnlyList`1<IIdolSkillActionEffectStatus> List<IIdolSkillActionEffectStatus> Pointer
    // 040 Cost                                     0001865F4260 ModelPrimitiveType int int int Int32
    // 048 AppealTypeList                           000185CED1B8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 050 Parameter                                0001865EF590 ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer
    // 058 LiveSkillViewModel                       00018657FCC0 ModelClassType LiveSkillViewModel LiveSkillViewModel LiveSkillViewModel Pointer
    // 060 IdolSkillActionCondition                 000186576720 ModelClassType IIdolSkillActionConditionStatus IIdolSkillActionConditionStatus IIdolSkillActionConditionStatus Pointer
    public partial class ProduceResultUnitMemberViewModel
    {
        public LiveSkillViewModel?                      OriginalLiveSkillViewModel              { get; set; }
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

        public static ProduceResultUnitMemberViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceResultUnitMemberViewModel();

            value.OriginalLiveSkillViewModel                = GetObject<LiveSkillViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.LiveSkillViewModel.FromPointer); // 0270D5F49EA0 0x10 OriginalLiveSkillViewModel  ( 000186580190 ModelClassType LiveSkillViewModel LiveSkillViewModel LiveSkillViewModel Pointer )
            value.SortIndex                                 = GetInt32(new IntPtr(p + 0x018)); // 0270D5F49EC0 0x18 SortIndex                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Icon                                      = GetObject<FIdolIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.FIdolIcon.FromPointer); // 0270D5F49EE0 0x20 Icon                        ( 0001865452F0 ModelClassType FIdolIcon FIdolIcon FIdolIcon Pointer )
            value.SkillId                                   = GetInt32(new IntPtr(p + 0x028)); // 0270D5F49F00 0x28 SkillId                     ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.IdolSkillLv                               = GetInt32(new IntPtr(p + 0x02C)); // 0270D5F49F20 0x2C IdolSkillLv                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.IdolSkillIconId                           = GetInt32(new IntPtr(p + 0x030)); // 0270D5F49F40 0x30 IdolSkillIconId             ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.AttachedIdolSkillDetailValueList          = GetObjectList<IIdolSkillActionEffectStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IIdolSkillActionEffectStatus.FromPointer); // 0270D5F49F60 0x38 AttachedIdolSkillDetailValueList ( 000185CFDCC8 ModelClassListType IReadOnlyList`1<IIdolSkillActionEffectStatus> IReadOnlyList`1<IIdolSkillActionEffectStatus> List<IIdolSkillActionEffectStatus> Pointer )
            value.Cost                                      = GetInt32(new IntPtr(p + 0x040)); // 0270D5F49F80 0x40 Cost                        ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.AppealTypeList                            = GetInt32List(new IntPtr(p + 0x048)); // 0270D5F49FA0 0x48 AppealTypeList              ( 000185CED1B8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.Parameter                                 = GetObject<IProduceParameterStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.IProduceParameterStatus.FromPointer); // 0270D5F49FC0 0x50 Parameter                   ( 0001865EF590 ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer )
            value.LiveSkillViewModel                        = GetObject<LiveSkillViewModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.LiveSkillViewModel.FromPointer); // 0270D5F49FE0 0x58 LiveSkillViewModel          ( 00018657FCC0 ModelClassType LiveSkillViewModel LiveSkillViewModel LiveSkillViewModel Pointer )
            value.IdolSkillActionCondition                  = GetObject<IIdolSkillActionConditionStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.IIdolSkillActionConditionStatus.FromPointer); // 0270D5F4A000 0x60 IdolSkillActionCondition    ( 000186576720 ModelClassType IIdolSkillActionConditionStatus IIdolSkillActionConditionStatus IIdolSkillActionConditionStatus Pointer )

            return value;
        }
    }
}
