using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UnitIdols                                ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 018 CutSceneUnitIdols                        ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 020 UnitIdolMotionViewModels                 ModelClassListType HomeMotionViewModel[] HomeMotionViewModel[] List<HomeMotionViewModel> Pointer
    // 028 BackgroundViewModel                      ModelClassType HomeBackgroundViewModel HomeBackgroundViewModel HomeBackgroundViewModel Pointer
    // 030 MessageViewModel                         ModelClassType HomeCharacterMessageViewModel HomeCharacterMessageViewModel HomeCharacterMessageViewModel Pointer
    // 038 SettingsViewModel                        ModelClassType HomeSettingsViewModel HomeSettingsViewModel HomeSettingsViewModel Pointer
    // 040 RemindItemViewModel                      ModelClassType HomeRemindItemViewModel HomeRemindItemViewModel HomeRemindItemViewModel Pointer
    // 048 LoginBonusViewModels                     ModelClassListType HomeLoginBonusViewModel[] HomeLoginBonusViewModel[] List<HomeLoginBonusViewModel> Pointer
    // 050 ShopViewModel                            ModelClassType ShopViewModel ShopViewModel ShopViewModel Pointer
    // 058 LoginBonusPassRewardViewModel            ModelClassType ShopLoginBonusPassRewardPopupViewModel ShopLoginBonusPassRewardPopupViewModel ShopLoginBonusPassRewardPopupViewModel Pointer
    // 060 NotificationManageViewModel              ModelClassType NotificationManageViewModel NotificationManageViewModel NotificationManageViewModel Pointer
    // 068 LimitedSaleViewModel                     ModelClassType LimitedSaleViewModel LimitedSaleViewModel LimitedSaleViewModel Pointer
    public partial class HomeViewModel : DataModel
    {
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

            value.UnitIdols                                 = GetObjectList<UnitIdol>(new IntPtr(p + 0x010), ReversePrism.DataModels.UnitIdol.FromPointer); // 0x10 UnitIdols                   ( ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.CutSceneUnitIdols                         = GetObjectList<UnitIdol>(new IntPtr(p + 0x018), ReversePrism.DataModels.UnitIdol.FromPointer); // 0x18 CutSceneUnitIdols           ( ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.UnitIdolMotionViewModels                  = GetObjectList<HomeMotionViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.HomeMotionViewModel.FromPointer); // 0x20 UnitIdolMotionViewModels    ( ModelClassListType HomeMotionViewModel[] HomeMotionViewModel[] List<HomeMotionViewModel> Pointer )
            value.BackgroundViewModel                       = GetObject<HomeBackgroundViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.HomeBackgroundViewModel.FromPointer); // 0x28 BackgroundViewModel         ( ModelClassType HomeBackgroundViewModel HomeBackgroundViewModel HomeBackgroundViewModel Pointer )
            value.MessageViewModel                          = GetObject<HomeCharacterMessageViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.HomeCharacterMessageViewModel.FromPointer); // 0x30 MessageViewModel            ( ModelClassType HomeCharacterMessageViewModel HomeCharacterMessageViewModel HomeCharacterMessageViewModel Pointer )
            value.SettingsViewModel                         = GetObject<HomeSettingsViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.HomeSettingsViewModel.FromPointer); // 0x38 SettingsViewModel           ( ModelClassType HomeSettingsViewModel HomeSettingsViewModel HomeSettingsViewModel Pointer )
            value.RemindItemViewModel                       = GetObject<HomeRemindItemViewModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.HomeRemindItemViewModel.FromPointer); // 0x40 RemindItemViewModel         ( ModelClassType HomeRemindItemViewModel HomeRemindItemViewModel HomeRemindItemViewModel Pointer )
            value.LoginBonusViewModels                      = GetObjectList<HomeLoginBonusViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.HomeLoginBonusViewModel.FromPointer); // 0x48 LoginBonusViewModels        ( ModelClassListType HomeLoginBonusViewModel[] HomeLoginBonusViewModel[] List<HomeLoginBonusViewModel> Pointer )
            value.ShopViewModel                             = GetObject<ShopViewModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.ShopViewModel.FromPointer); // 0x50 ShopViewModel               ( ModelClassType ShopViewModel ShopViewModel ShopViewModel Pointer )
            value.LoginBonusPassRewardViewModel             = GetObject<ShopLoginBonusPassRewardPopupViewModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.ShopLoginBonusPassRewardPopupViewModel.FromPointer); // 0x58 LoginBonusPassRewardViewModel ( ModelClassType ShopLoginBonusPassRewardPopupViewModel ShopLoginBonusPassRewardPopupViewModel ShopLoginBonusPassRewardPopupViewModel Pointer )
            value.NotificationManageViewModel               = GetObject<NotificationManageViewModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.NotificationManageViewModel.FromPointer); // 0x60 NotificationManageViewModel ( ModelClassType NotificationManageViewModel NotificationManageViewModel NotificationManageViewModel Pointer )
            value.LimitedSaleViewModel                      = GetObject<LimitedSaleViewModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.LimitedSaleViewModel.FromPointer); // 0x68 LimitedSaleViewModel        ( ModelClassType LimitedSaleViewModel LimitedSaleViewModel LimitedSaleViewModel Pointer )

            return value;
        }
    }
}
