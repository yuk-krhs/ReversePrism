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
    public partial class IdolSkillContentViewModel : DataModel
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
            var value   = new IdolSkillContentViewModel() { Pointer= p0 };

            value.CurrentLvRP                               = GetObject<IntReactiveProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.IntReactiveProperty.FromPointer); // 024665FE4B60 0x10 CurrentLvRP                 ( 000186714660 ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer )
            value.LimitLvRP                                 = GetObject<IntReactiveProperty>(new IntPtr(p + 0x018), ReversePrism.DataModels.IntReactiveProperty.FromPointer); // 024665FE4B80 0x18 LimitLvRP                   ( 000186714660 ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer )
            value.UnlockedRP                                = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x020), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 024665FE4BA0 0x20 UnlockedRP                  ( 0001867695E0 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.SkillId                                   = GetInt32(new IntPtr(p + 0x028)); // 024665FE4BC0 0x28 SkillId                     ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.IconId                                    = GetInt32(new IntPtr(p + 0x02C)); // 024665FE4BE0 0x2C IconId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Cost                                      = GetInt32(new IntPtr(p + 0x030)); // 024665FE4C00 0x30 Cost                        ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.AppealTypeList                            = GetEnumList<ProduceParameterType>(new IntPtr(p + 0x040)); // 024665FE4C40 0x40 AppealTypeList              ( 000185D18D28 ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer )
            value.UnlockLv                                  = GetInt32(new IntPtr(p + 0x050)); // 024665FE4C80 0x50 UnlockLv                    ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
