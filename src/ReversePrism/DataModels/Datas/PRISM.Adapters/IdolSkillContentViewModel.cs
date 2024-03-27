using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CurrentLvRP                              000186714660 ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer
    // 018 LimitLvRP                                000186714660 ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer
    // 020 UnlockedRP                               0001867695E0 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 028 SkillId                                  0001865F4260 ModelPrimitiveType int int int Int32
    // 02C IconId                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 030 Cost                                     0001865F4260 ModelPrimitiveType int int int Int32
    // 038 <IdolSkillLevelList>k__BackingField      IEnumerable`1<IdolSkillLevelViewModel> IL2CPP_TYPE_GENERICINST
    // 040 AppealTypeList                           000185D18D28 ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer
    // 048 <SkillLevelInfoList>k__BackingField      IEnumerable`1<ValueTuple`4<int, int, IReadOnlyList`1<IIdolSkillActionEffectStatus>, IIdolSkillActionConditionStatus>> IL2CPP_TYPE_GENERICINST
    // 050 UnlockLv                                 0001865F4260 ModelPrimitiveType int int int Int32
    public partial class IdolSkillContentViewModel
    {
        public IntReactiveProperty?                     CurrentLvRP                             { get; set; }
        public IntReactiveProperty?                     LimitLvRP                               { get; set; }
        public BoolReactiveProperty?                    UnlockedRP                              { get; set; }
        public int                                      SkillId                                 { get; set; }
        public int                                      IconId                                  { get; set; }
        public int                                      Cost                                    { get; set; }
        public List<ProduceParameterType>?              AppealTypeList                          { get; set; }
        public int                                      UnlockLv                                { get; set; }

        public static IdolSkillContentViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolSkillContentViewModel();

            value.CurrentLvRP                               = GetObject<IntReactiveProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.IntReactiveProperty.FromPointer); // 0270D5F74330 0x10 CurrentLvRP                 ( 000186714660 ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer )
            value.LimitLvRP                                 = GetObject<IntReactiveProperty>(new IntPtr(p + 0x018), ReversePrism.DataModels.IntReactiveProperty.FromPointer); // 0270D5F74350 0x18 LimitLvRP                   ( 000186714660 ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer )
            value.UnlockedRP                                = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x020), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 0270D5F74370 0x20 UnlockedRP                  ( 0001867695E0 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.SkillId                                   = GetInt32(new IntPtr(p + 0x028)); // 0270D5F74390 0x28 SkillId                     ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.IconId                                    = GetInt32(new IntPtr(p + 0x02C)); // 0270D5F743B0 0x2C IconId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Cost                                      = GetInt32(new IntPtr(p + 0x030)); // 0270D5F743D0 0x30 Cost                        ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.AppealTypeList                            = GetEnumList<ProduceParameterType>(new IntPtr(p + 0x040)); // 0270D5F74410 0x40 AppealTypeList              ( 000185D18D28 ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer )
            value.UnlockLv                                  = GetInt32(new IntPtr(p + 0x050)); // 0270D5F74450 0x50 UnlockLv                    ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
