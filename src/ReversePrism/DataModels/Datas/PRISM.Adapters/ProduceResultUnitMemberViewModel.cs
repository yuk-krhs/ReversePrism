using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OriginalLiveSkillViewModel               ModelClassType LiveSkillViewModel LiveSkillViewModel LiveSkillViewModel Pointer
    // 018 SortIndex                                ModelPrimitiveType int int int Int32
    // 020 Icon                                     ModelClassType FIdolIcon FIdolIcon FIdolIcon Pointer
    // 028 SkillId                                  ModelPrimitiveType int int int Int32
    // 02C IdolSkillLv                              ModelPrimitiveType int int int Int32
    // 030 IdolSkillIconId                          ModelPrimitiveType int int int Int32
    // 038 AttachedIdolSkillDetailValueList         ModelClassListType IReadOnlyList`1<IIdolSkillActionEffectStatus> IReadOnlyList`1<IIdolSkillActionEffectStatus> List<IIdolSkillActionEffectStatus> Pointer
    // 040 Cost                                     ModelPrimitiveType int int int Int32
    // 048 AppealTypeList                           ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 050 Parameter                                ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer
    // 058 LiveSkillViewModel                       ModelClassType LiveSkillViewModel LiveSkillViewModel LiveSkillViewModel Pointer
    // 060 IdolSkillActionCondition                 ModelClassType IIdolSkillActionConditionStatus IIdolSkillActionConditionStatus IIdolSkillActionConditionStatus Pointer
    public partial class ProduceResultUnitMemberViewModel : DataModel
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
            var value   = new ProduceResultUnitMemberViewModel() { Pointer= p0 };

            value.OriginalLiveSkillViewModel                = GetObject<LiveSkillViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.LiveSkillViewModel.FromPointer); // 0x10 OriginalLiveSkillViewModel  ( ModelClassType LiveSkillViewModel LiveSkillViewModel LiveSkillViewModel Pointer )
            value.SortIndex                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 SortIndex                   ( ModelPrimitiveType int int int Int32 )
            value.Icon                                      = GetObject<FIdolIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.FIdolIcon.FromPointer); // 0x20 Icon                        ( ModelClassType FIdolIcon FIdolIcon FIdolIcon Pointer )
            value.SkillId                                   = GetInt32(new IntPtr(p + 0x028)); // 0x28 SkillId                     ( ModelPrimitiveType int int int Int32 )
            value.IdolSkillLv                               = GetInt32(new IntPtr(p + 0x02C)); // 0x2C IdolSkillLv                 ( ModelPrimitiveType int int int Int32 )
            value.IdolSkillIconId                           = GetInt32(new IntPtr(p + 0x030)); // 0x30 IdolSkillIconId             ( ModelPrimitiveType int int int Int32 )
            value.AttachedIdolSkillDetailValueList          = GetObjectList<IIdolSkillActionEffectStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IIdolSkillActionEffectStatus.FromPointer); // 0x38 AttachedIdolSkillDetailValueList ( ModelClassListType IReadOnlyList`1<IIdolSkillActionEffectStatus> IReadOnlyList`1<IIdolSkillActionEffectStatus> List<IIdolSkillActionEffectStatus> Pointer )
            value.Cost                                      = GetInt32(new IntPtr(p + 0x040)); // 0x40 Cost                        ( ModelPrimitiveType int int int Int32 )
            value.AppealTypeList                            = GetInt32List(new IntPtr(p + 0x048)); // 0x48 AppealTypeList              ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.Parameter                                 = GetObject<IProduceParameterStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.IProduceParameterStatus.FromPointer); // 0x50 Parameter                   ( ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer )
            value.LiveSkillViewModel                        = GetObject<LiveSkillViewModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.LiveSkillViewModel.FromPointer); // 0x58 LiveSkillViewModel          ( ModelClassType LiveSkillViewModel LiveSkillViewModel LiveSkillViewModel Pointer )
            value.IdolSkillActionCondition                  = GetObject<IIdolSkillActionConditionStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.IIdolSkillActionConditionStatus.FromPointer); // 0x60 IdolSkillActionCondition    ( ModelClassType IIdolSkillActionConditionStatus IIdolSkillActionConditionStatus IIdolSkillActionConditionStatus Pointer )

            return value;
        }
    }
}
