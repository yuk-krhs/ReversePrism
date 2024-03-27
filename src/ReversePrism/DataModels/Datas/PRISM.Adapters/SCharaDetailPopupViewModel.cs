using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FavoriteMarkIdRP                         000186714310 ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer
    // 018 DetailType                               0001866A6520 ModelEnumType SCharaDetailType SCharaDetailType SCharaDetailType Int32
    // 01C InitialTabIndex                          0001865F4260 ModelPrimitiveType int int int Int32
    // 020 MstSupportCharacterId                    0001865F4260 ModelPrimitiveType int int int Int32
    // 024 MstCharacterInfoId                       0001865F4260 ModelPrimitiveType int int int Int32
    // 028 Rarity                                   0001866201C0 ModelEnumType SupportCharacterRarity SupportCharacterRarity SupportCharacterRarity Int32
    // 02C CurrentDiamondLv                         0001865F4260 ModelPrimitiveType int int int Int32
    // 030 CurrentLv                                0001865F4260 ModelPrimitiveType int int int Int32
    // 034 CurrentLimitLv                           0001865F4260 ModelPrimitiveType int int int Int32
    // 038 GoodScheduleDetailType                   0001866152C0 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 03C CurrentSkillSlot                         0001865F4260 ModelPrimitiveType int int int Int32
    // 040 CurrentLimitSkillSlot                    0001865F4260 ModelPrimitiveType int int int Int32
    // 044 ExpProgress                              000186666CB0 ModelPrimitiveType float float float Single
    // 048 SupportEffectList                        000185CA8568 ModelClassListType SupportEffectContentViewModel[] SupportEffectContentViewModel[] List<SupportEffectContentViewModel> Pointer
    // 050 PotentialSupportSkillIdList              000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 058 SupportCharacterEventList                000185B7CB20 ModelClassListType EventModel[] EventModel[] List<EventModel> Pointer
    // 060 IsChangeableFavorite                     0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 061 AsMax                                    0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 062 UpgradingButtonActive                    000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class SCharaDetailPopupViewModel
    {
        public IntReactiveProperty?                     FavoriteMarkIdRP                        { get; set; }
        public SCharaDetailType                         DetailType                              { get; set; }
        public int                                      InitialTabIndex                         { get; set; }
        public int                                      MstSupportCharacterId                   { get; set; }
        public int                                      MstCharacterInfoId                      { get; set; }
        public SupportCharacterRarity                   Rarity                                  { get; set; }
        public int                                      CurrentDiamondLv                        { get; set; }
        public int                                      CurrentLv                               { get; set; }
        public int                                      CurrentLimitLv                          { get; set; }
        public ScheduleDetailType                       GoodScheduleDetailType                  { get; set; }
        public int                                      CurrentSkillSlot                        { get; set; }
        public int                                      CurrentLimitSkillSlot                   { get; set; }
        public float                                    ExpProgress                             { get; set; }
        public List<SupportEffectContentViewModel>?     SupportEffectList                       { get; set; }
        public List<int>?                               PotentialSupportSkillIdList             { get; set; }
        public List<EventModel>?                        SupportCharacterEventList               { get; set; }
        public bool                                     IsChangeableFavorite                    { get; set; }
        public bool                                     AsMax                                   { get; set; }
        public bool                                     UpgradingButtonActive                   { get; set; }

        public static SCharaDetailPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SCharaDetailPopupViewModel();

            value.FavoriteMarkIdRP                          = GetObject<IntReactiveProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.IntReactiveProperty.FromPointer); // 0270D5F764E0 0x10 FavoriteMarkIdRP            ( 000186714310 ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer )
            value.DetailType                                = (SCharaDetailType)GetInt32(new IntPtr(p + 0x018)); // 0270D5F76500 0x18 DetailType                  ( 0001866A6520 ModelEnumType SCharaDetailType SCharaDetailType SCharaDetailType Int32 )
            value.InitialTabIndex                           = GetInt32(new IntPtr(p + 0x01C)); // 0270D5F76520 0x1C InitialTabIndex             ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstSupportCharacterId                     = GetInt32(new IntPtr(p + 0x020)); // 0270D5F76540 0x20 MstSupportCharacterId       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x024)); // 0270D5F76560 0x24 MstCharacterInfoId          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Rarity                                    = (SupportCharacterRarity)GetInt32(new IntPtr(p + 0x028)); // 0270D5F76580 0x28 Rarity                      ( 0001866201C0 ModelEnumType SupportCharacterRarity SupportCharacterRarity SupportCharacterRarity Int32 )
            value.CurrentDiamondLv                          = GetInt32(new IntPtr(p + 0x02C)); // 0270D5F765A0 0x2C CurrentDiamondLv            ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.CurrentLv                                 = GetInt32(new IntPtr(p + 0x030)); // 0270D5F765C0 0x30 CurrentLv                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.CurrentLimitLv                            = GetInt32(new IntPtr(p + 0x034)); // 0270D5F765E0 0x34 CurrentLimitLv              ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.GoodScheduleDetailType                    = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x038)); // 0270D5F76600 0x38 GoodScheduleDetailType      ( 0001866152C0 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.CurrentSkillSlot                          = GetInt32(new IntPtr(p + 0x03C)); // 0270D5F76620 0x3C CurrentSkillSlot            ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.CurrentLimitSkillSlot                     = GetInt32(new IntPtr(p + 0x040)); // 0270D5F76640 0x40 CurrentLimitSkillSlot       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ExpProgress                               = GetSingle(new IntPtr(p + 0x044)); // 0270D5F76660 0x44 ExpProgress                 ( 000186666CB0 ModelPrimitiveType float float float Single )
            value.SupportEffectList                         = GetObjectList<SupportEffectContentViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.SupportEffectContentViewModel.FromPointer); // 0270D5F76680 0x48 SupportEffectList           ( 000185CA8568 ModelClassListType SupportEffectContentViewModel[] SupportEffectContentViewModel[] List<SupportEffectContentViewModel> Pointer )
            value.PotentialSupportSkillIdList               = GetInt32List(new IntPtr(p + 0x050)); // 0270D5F766A0 0x50 PotentialSupportSkillIdList ( 000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SupportCharacterEventList                 = GetObjectList<EventModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.EventModel.FromPointer); // 0270D5F766C0 0x58 SupportCharacterEventList   ( 000185B7CB20 ModelClassListType EventModel[] EventModel[] List<EventModel> Pointer )
            value.IsChangeableFavorite                      = GetBool(new IntPtr(p + 0x060)); // 0270D5F766E0 0x60 IsChangeableFavorite        ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.AsMax                                     = GetBool(new IntPtr(p + 0x061)); // 0270D5F76700 0x61 AsMax                       ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.UpgradingButtonActive                     = GetBool(new IntPtr(p + 0x062)); // 0270D5F76720 0x62 UpgradingButtonActive       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
