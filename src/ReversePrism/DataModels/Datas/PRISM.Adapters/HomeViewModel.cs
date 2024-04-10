using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Model                                    0001866C5F40 ModelClassType HomeModel HomeModel HomeModel Pointer
    // 018 UnitIdols                                000185CAF1A8 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 020 CutSceneUnitIdols                        000185CAF1A8 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 028 UnitIdolMotionViewModels                 000185B84E20 ModelClassListType HomeMotionViewModel[] HomeMotionViewModel[] List<HomeMotionViewModel> Pointer
    // 030 BackgroundViewModel                      0001866BA240 ModelClassType HomeBackgroundViewModel HomeBackgroundViewModel HomeBackgroundViewModel Pointer
    // 038 MessageViewModel                         0001866BE2A0 ModelClassType HomeCharacterMessageViewModel HomeCharacterMessageViewModel HomeCharacterMessageViewModel Pointer
    // 040 SettingsViewModel                        0001866D0370 ModelClassType HomeSettingsViewModel HomeSettingsViewModel HomeSettingsViewModel Pointer
    // 048 RemindItemViewModel                      0001866C99D0 ModelClassType HomeRemindItemViewModel HomeRemindItemViewModel HomeRemindItemViewModel Pointer
    // 050 LoginBonusViewModels                     000185B84BD0 ModelClassListType HomeLoginBonusViewModel[] HomeLoginBonusViewModel[] List<HomeLoginBonusViewModel> Pointer
    // 058 ShopViewModel                            000186774A10 ModelClassType ShopViewModel ShopViewModel ShopViewModel Pointer
    // 060 LoginBonusPassRewardViewModel            000186763AC0 ModelClassType ShopLoginBonusPassRewardPopupViewModel ShopLoginBonusPassRewardPopupViewModel ShopLoginBonusPassRewardPopupViewModel Pointer
    // 068 NotificationManageViewModel              0001866B2CF0 ModelClassType NotificationManageViewModel NotificationManageViewModel NotificationManageViewModel Pointer
    // 070 LimitedSaleViewModel                     00018652E250 ModelClassType LimitedSaleViewModel LimitedSaleViewModel LimitedSaleViewModel Pointer
    public partial class HomeViewModel : DataModel
    {
        public HomeModel?                               Model                                   { get; set; }
        public List<UnitIdol>?                          UnitIdols                               { get; set; }
        public List<UnitIdol>?                          CutSceneUnitIdols                       { get; set; }
        public List<HomeMotionViewModel>?               UnitIdolMotionViewModels                { get; set; }
        public HomeBackgroundViewModel?                 BackgroundViewModel                     { get; set; }
        public HomeCharacterMessageViewModel?           MessageViewModel                        { get; set; }
        public HomeSettingsViewModel?                   SettingsViewModel                       { get; set; }
        public HomeRemindItemViewModel?                 RemindItemViewModel                     { get; set; }
        public List<HomeLoginBonusViewModel>?           LoginBonusViewModels                    { get; set; }
        public ShopViewModel?                           ShopViewModel                           { get; set; }
        public ShopLoginBonusPassRewardPopupViewModel?  LoginBonusPassRewardViewModel           { get; set; }
        public NotificationManageViewModel?             NotificationManageViewModel             { get; set; }
        public LimitedSaleViewModel?                    LimitedSaleViewModel                    { get; set; }

        public static HomeViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeViewModel() { Pointer= p0 };

            value.Model                                     = GetObject<HomeModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.HomeModel.FromPointer); // 0245A5B3DA90 0x10 Model                       ( 0001866C5F40 ModelClassType HomeModel HomeModel HomeModel Pointer )
            value.UnitIdols                                 = GetObjectList<UnitIdol>(new IntPtr(p + 0x018), ReversePrism.DataModels.UnitIdol.FromPointer); // 0245A5B3DAB0 0x18 UnitIdols                   ( 000185CAF1A8 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.CutSceneUnitIdols                         = GetObjectList<UnitIdol>(new IntPtr(p + 0x020), ReversePrism.DataModels.UnitIdol.FromPointer); // 0245A5B3DAD0 0x20 CutSceneUnitIdols           ( 000185CAF1A8 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.UnitIdolMotionViewModels                  = GetObjectList<HomeMotionViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.HomeMotionViewModel.FromPointer); // 0245A5B3DAF0 0x28 UnitIdolMotionViewModels    ( 000185B84E20 ModelClassListType HomeMotionViewModel[] HomeMotionViewModel[] List<HomeMotionViewModel> Pointer )
            value.BackgroundViewModel                       = GetObject<HomeBackgroundViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.HomeBackgroundViewModel.FromPointer); // 0245A5B3DB10 0x30 BackgroundViewModel         ( 0001866BA240 ModelClassType HomeBackgroundViewModel HomeBackgroundViewModel HomeBackgroundViewModel Pointer )
            value.MessageViewModel                          = GetObject<HomeCharacterMessageViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.HomeCharacterMessageViewModel.FromPointer); // 0245A5B3DB30 0x38 MessageViewModel            ( 0001866BE2A0 ModelClassType HomeCharacterMessageViewModel HomeCharacterMessageViewModel HomeCharacterMessageViewModel Pointer )
            value.SettingsViewModel                         = GetObject<HomeSettingsViewModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.HomeSettingsViewModel.FromPointer); // 0245A5B3DB50 0x40 SettingsViewModel           ( 0001866D0370 ModelClassType HomeSettingsViewModel HomeSettingsViewModel HomeSettingsViewModel Pointer )
            value.RemindItemViewModel                       = GetObject<HomeRemindItemViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.HomeRemindItemViewModel.FromPointer); // 0245A5B3DB70 0x48 RemindItemViewModel         ( 0001866C99D0 ModelClassType HomeRemindItemViewModel HomeRemindItemViewModel HomeRemindItemViewModel Pointer )
            value.LoginBonusViewModels                      = GetObjectList<HomeLoginBonusViewModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.HomeLoginBonusViewModel.FromPointer); // 0245A5B3DB90 0x50 LoginBonusViewModels        ( 000185B84BD0 ModelClassListType HomeLoginBonusViewModel[] HomeLoginBonusViewModel[] List<HomeLoginBonusViewModel> Pointer )
            value.ShopViewModel                             = GetObject<ShopViewModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.ShopViewModel.FromPointer); // 0245A5B3DBB0 0x58 ShopViewModel               ( 000186774A10 ModelClassType ShopViewModel ShopViewModel ShopViewModel Pointer )
            value.LoginBonusPassRewardViewModel             = GetObject<ShopLoginBonusPassRewardPopupViewModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.ShopLoginBonusPassRewardPopupViewModel.FromPointer); // 0245A5B3DBD0 0x60 LoginBonusPassRewardViewModel ( 000186763AC0 ModelClassType ShopLoginBonusPassRewardPopupViewModel ShopLoginBonusPassRewardPopupViewModel ShopLoginBonusPassRewardPopupViewModel Pointer )
            value.NotificationManageViewModel               = GetObject<NotificationManageViewModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.NotificationManageViewModel.FromPointer); // 0245A5B3DBF0 0x68 NotificationManageViewModel ( 0001866B2CF0 ModelClassType NotificationManageViewModel NotificationManageViewModel NotificationManageViewModel Pointer )
            value.LimitedSaleViewModel                      = GetObject<LimitedSaleViewModel>(new IntPtr(p + 0x070), ReversePrism.DataModels.LimitedSaleViewModel.FromPointer); // 0245A5B3DC10 0x70 LimitedSaleViewModel        ( 00018652E250 ModelClassType LimitedSaleViewModel LimitedSaleViewModel LimitedSaleViewModel Pointer )

            return value;
        }
    }
}
