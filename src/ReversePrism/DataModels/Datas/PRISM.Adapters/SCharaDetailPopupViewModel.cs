using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FavoriteMarkIdRP                         ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer
    // 018 DetailType                               ModelEnumType SCharaDetailType SCharaDetailType SCharaDetailType Int32
    // 01C InitialTabIndex                          ModelPrimitiveType int int int Int32
    // 020 MstSupportCharacterId                    ModelPrimitiveType int int int Int32
    // 024 MstCharacterInfoId                       ModelPrimitiveType int int int Int32
    // 028 Rarity                                   ModelEnumType SupportCharacterRarity SupportCharacterRarity SupportCharacterRarity Int32
    // 02C CurrentDiamondLv                         ModelPrimitiveType int int int Int32
    // 030 CurrentLv                                ModelPrimitiveType int int int Int32
    // 034 CurrentLimitLv                           ModelPrimitiveType int int int Int32
    // 038 GoodScheduleDetailType                   ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 03C CurrentSkillSlot                         ModelPrimitiveType int int int Int32
    // 040 CurrentLimitSkillSlot                    ModelPrimitiveType int int int Int32
    // 044 ExpProgress                              ModelPrimitiveType float float float Single
    // 048 SupportEffectList                        ModelClassListType SupportEffectContentViewModel[] SupportEffectContentViewModel[] List<SupportEffectContentViewModel> Pointer
    // 050 PotentialSupportSkillIdList              ModelPrimitiveListType int[] int[] List<int> Pointer
    // 058 SupportCharacterEventList                ModelClassListType EventModel[] EventModel[] List<EventModel> Pointer
    // 060 IsChangeableFavorite                     ModelPrimitiveType bool bool bool Bool
    // 061 AsMax                                    ModelPrimitiveType bool bool bool Bool
    // 062 UpgradingButtonActive                    ModelPrimitiveType bool bool bool Bool
    public partial class SCharaDetailPopupViewModel : DataModel
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
            var value   = new SCharaDetailPopupViewModel() { Pointer= p0 };

            value.FavoriteMarkIdRP                          = GetObject<IntReactiveProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.IntReactiveProperty.FromPointer); // 0x10 FavoriteMarkIdRP            ( ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer )
            value.DetailType                                = (SCharaDetailType)GetInt32(new IntPtr(p + 0x018)); // 0x18 DetailType                  ( ModelEnumType SCharaDetailType SCharaDetailType SCharaDetailType Int32 )
            value.InitialTabIndex                           = GetInt32(new IntPtr(p + 0x01C)); // 0x1C InitialTabIndex             ( ModelPrimitiveType int int int Int32 )
            value.MstSupportCharacterId                     = GetInt32(new IntPtr(p + 0x020)); // 0x20 MstSupportCharacterId       ( ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x024)); // 0x24 MstCharacterInfoId          ( ModelPrimitiveType int int int Int32 )
            value.Rarity                                    = (SupportCharacterRarity)GetInt32(new IntPtr(p + 0x028)); // 0x28 Rarity                      ( ModelEnumType SupportCharacterRarity SupportCharacterRarity SupportCharacterRarity Int32 )
            value.CurrentDiamondLv                          = GetInt32(new IntPtr(p + 0x02C)); // 0x2C CurrentDiamondLv            ( ModelPrimitiveType int int int Int32 )
            value.CurrentLv                                 = GetInt32(new IntPtr(p + 0x030)); // 0x30 CurrentLv                   ( ModelPrimitiveType int int int Int32 )
            value.CurrentLimitLv                            = GetInt32(new IntPtr(p + 0x034)); // 0x34 CurrentLimitLv              ( ModelPrimitiveType int int int Int32 )
            value.GoodScheduleDetailType                    = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x038)); // 0x38 GoodScheduleDetailType      ( ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.CurrentSkillSlot                          = GetInt32(new IntPtr(p + 0x03C)); // 0x3C CurrentSkillSlot            ( ModelPrimitiveType int int int Int32 )
            value.CurrentLimitSkillSlot                     = GetInt32(new IntPtr(p + 0x040)); // 0x40 CurrentLimitSkillSlot       ( ModelPrimitiveType int int int Int32 )
            value.ExpProgress                               = GetSingle(new IntPtr(p + 0x044)); // 0x44 ExpProgress                 ( ModelPrimitiveType float float float Single )
            value.SupportEffectList                         = GetObjectList<SupportEffectContentViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.SupportEffectContentViewModel.FromPointer); // 0x48 SupportEffectList           ( ModelClassListType SupportEffectContentViewModel[] SupportEffectContentViewModel[] List<SupportEffectContentViewModel> Pointer )
            value.PotentialSupportSkillIdList               = GetInt32List(new IntPtr(p + 0x050)); // 0x50 PotentialSupportSkillIdList ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SupportCharacterEventList                 = GetObjectList<EventModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.EventModel.FromPointer); // 0x58 SupportCharacterEventList   ( ModelClassListType EventModel[] EventModel[] List<EventModel> Pointer )
            value.IsChangeableFavorite                      = GetBool(new IntPtr(p + 0x060)); // 0x60 IsChangeableFavorite        ( ModelPrimitiveType bool bool bool Bool )
            value.AsMax                                     = GetBool(new IntPtr(p + 0x061)); // 0x61 AsMax                       ( ModelPrimitiveType bool bool bool Bool )
            value.UpgradingButtonActive                     = GetBool(new IntPtr(p + 0x062)); // 0x62 UpgradingButtonActive       ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
