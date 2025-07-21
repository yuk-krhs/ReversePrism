using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MaxStarLv                                ModelPrimitiveType int int int Int32
    // 018 idolSkillLevels                          Dictionary`2<int, int> IL2CPP_TYPE_GENERICINST
    // 020 DressUnlockPremiseStarList               ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 028 changeIdolSkillLvSubject                 Subject`1<ValueTuple`2<int, int>> IL2CPP_TYPE_GENERICINST
    // 030 changeLiveSkillLvSubject                 Subject`1<ValueTuple`2<int, int>> IL2CPP_TYPE_GENERICINST
    // 038 changeReleaseCostumeSubject              Subject`1<int[]> IL2CPP_TYPE_GENERICINST
    // 040 changeMaxStarLvSubject                   Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 048 changeDressOrderTicketSubject            Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 050 UpgradingBonusTypes                      ModelEnumListType IReadOnlyList`1<PIdolUpgradingBonusType> IReadOnlyList`1<PIdolUpgradingBonusType> List<PIdolUpgradingBonusType> Pointer
    // 058 LiveOnly                                 ModelPrimitiveType bool bool bool Bool
    // 05C BeforeIdolSkillLv                        ModelPrimitiveType int int int Int32
    // 060 AfterIdolSkillLv                         ModelPrimitiveType int int int Int32
    // 064 BeforeLiveSkillLv                        ModelPrimitiveType int int int Int32
    // 068 AfterLiveSkillLv                         ModelPrimitiveType int int int Int32
    // 070 NewDressReleaseTrainingLv                ModelPrimitiveListType int[] int[] List<int> Pointer
    // 078 IsMaxStarLv                              ModelPrimitiveType bool bool bool Bool
    // 079 AcquireDressOrderTicket                  ModelPrimitiveType bool bool bool Bool
    public partial class OtherBonusViewModel : DataModel
    {
        public int                                      MaxStarLv                               { get; set; }
        public List<int>?                               DressUnlockPremiseStarList              { get; set; }
        public List<PIdolUpgradingBonusType>?           UpgradingBonusTypes                     { get; set; }
        public bool                                     LiveOnly                                { get; set; }
        public int                                      BeforeIdolSkillLv                       { get; set; }
        public int                                      AfterIdolSkillLv                        { get; set; }
        public int                                      BeforeLiveSkillLv                       { get; set; }
        public int                                      AfterLiveSkillLv                        { get; set; }
        public List<int>?                               NewDressReleaseTrainingLv               { get; set; }
        public bool                                     IsMaxStarLv                             { get; set; }
        public bool                                     AcquireDressOrderTicket                 { get; set; }

        public static OtherBonusViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OtherBonusViewModel() { Pointer= p0 };

            value.MaxStarLv                                 = GetInt32(new IntPtr(p + 0x010)); // 0x10 MaxStarLv                   ( ModelPrimitiveType int int int Int32 )
            value.DressUnlockPremiseStarList                = GetInt32List(new IntPtr(p + 0x020)); // 0x20 DressUnlockPremiseStarList  ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.UpgradingBonusTypes                       = GetEnumList<PIdolUpgradingBonusType>(new IntPtr(p + 0x050)); // 0x50 UpgradingBonusTypes         ( ModelEnumListType IReadOnlyList`1<PIdolUpgradingBonusType> IReadOnlyList`1<PIdolUpgradingBonusType> List<PIdolUpgradingBonusType> Pointer )
            value.LiveOnly                                  = GetBool(new IntPtr(p + 0x058)); // 0x58 LiveOnly                    ( ModelPrimitiveType bool bool bool Bool )
            value.BeforeIdolSkillLv                         = GetInt32(new IntPtr(p + 0x05C)); // 0x5C BeforeIdolSkillLv           ( ModelPrimitiveType int int int Int32 )
            value.AfterIdolSkillLv                          = GetInt32(new IntPtr(p + 0x060)); // 0x60 AfterIdolSkillLv            ( ModelPrimitiveType int int int Int32 )
            value.BeforeLiveSkillLv                         = GetInt32(new IntPtr(p + 0x064)); // 0x64 BeforeLiveSkillLv           ( ModelPrimitiveType int int int Int32 )
            value.AfterLiveSkillLv                          = GetInt32(new IntPtr(p + 0x068)); // 0x68 AfterLiveSkillLv            ( ModelPrimitiveType int int int Int32 )
            value.NewDressReleaseTrainingLv                 = GetInt32List(new IntPtr(p + 0x070)); // 0x70 NewDressReleaseTrainingLv   ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.IsMaxStarLv                               = GetBool(new IntPtr(p + 0x078)); // 0x78 IsMaxStarLv                 ( ModelPrimitiveType bool bool bool Bool )
            value.AcquireDressOrderTicket                   = GetBool(new IntPtr(p + 0x079)); // 0x79 AcquireDressOrderTicket     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
