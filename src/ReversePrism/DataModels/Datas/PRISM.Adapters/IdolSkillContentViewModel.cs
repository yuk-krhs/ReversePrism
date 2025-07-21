using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CurrentLvRP                              ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer
    // 018 LimitLvRP                                ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer
    // 020 UnlockedRP                               ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 028 SkillId                                  ModelPrimitiveType int int int Int32
    // 02C IconId                                   ModelPrimitiveType int int int Int32
    // 030 Cost                                     ModelPrimitiveType int int int Int32
    // 038 IdolSkillLevelList                       ModelClassListType IReadOnlyList`1<IdolSkillLevelViewModel> IReadOnlyList`1<IdolSkillLevelViewModel> List<IdolSkillLevelViewModel> Pointer
    // 040 AppealTypeList                           ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer
    // 048 <SkillLevelInfoList>k__BackingField      IEnumerable`1<ValueTuple`4<int, int, IReadOnlyList`1<IIdolSkillActionEffectStatus>, IIdolSkillActionConditionStatus>> IL2CPP_TYPE_GENERICINST
    // 050 UnlockLv                                 ModelPrimitiveType int int int Int32
    public partial class IdolSkillContentViewModel : DataModel
    {
        public IntReactiveProperty?                     CurrentLvRP                             { get; set; }
        public IntReactiveProperty?                     LimitLvRP                               { get; set; }
        public BoolReactiveProperty?                    UnlockedRP                              { get; set; }
        public int                                      SkillId                                 { get; set; }
        public int                                      IconId                                  { get; set; }
        public int                                      Cost                                    { get; set; }
        public List<IdolSkillLevelViewModel>?           IdolSkillLevelList                      { get; set; }
        public List<ProduceParameterType>?              AppealTypeList                          { get; set; }
        public int                                      UnlockLv                                { get; set; }

        public static IdolSkillContentViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolSkillContentViewModel() { Pointer= p0 };

            value.CurrentLvRP                               = GetObject<IntReactiveProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.IntReactiveProperty.FromPointer); // 0x10 CurrentLvRP                 ( ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer )
            value.LimitLvRP                                 = GetObject<IntReactiveProperty>(new IntPtr(p + 0x018), ReversePrism.DataModels.IntReactiveProperty.FromPointer); // 0x18 LimitLvRP                   ( ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer )
            value.UnlockedRP                                = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x020), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 0x20 UnlockedRP                  ( ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.SkillId                                   = GetInt32(new IntPtr(p + 0x028)); // 0x28 SkillId                     ( ModelPrimitiveType int int int Int32 )
            value.IconId                                    = GetInt32(new IntPtr(p + 0x02C)); // 0x2C IconId                      ( ModelPrimitiveType int int int Int32 )
            value.Cost                                      = GetInt32(new IntPtr(p + 0x030)); // 0x30 Cost                        ( ModelPrimitiveType int int int Int32 )
            value.IdolSkillLevelList                        = GetObjectList<IdolSkillLevelViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.IdolSkillLevelViewModel.FromPointer); // 0x38 IdolSkillLevelList          ( ModelClassListType IReadOnlyList`1<IdolSkillLevelViewModel> IReadOnlyList`1<IdolSkillLevelViewModel> List<IdolSkillLevelViewModel> Pointer )
            value.AppealTypeList                            = GetEnumList<ProduceParameterType>(new IntPtr(p + 0x040)); // 0x40 AppealTypeList              ( ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer )
            value.UnlockLv                                  = GetInt32(new IntPtr(p + 0x050)); // 0x50 UnlockLv                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
