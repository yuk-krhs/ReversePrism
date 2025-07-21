using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ViewType                                 ModelEnumType LoginBonusViewType LoginBonusViewType LoginBonusViewType Int32
    // 018 LoginBonus                               ModelClassType ILoginBonusStatus ILoginBonusStatus ILoginBonusStatus Pointer
    // 020 RewardItemListViewModels                 ModelClassListType HomeLoginBonusRewardItemIconViewModel[] HomeLoginBonusRewardItemIconViewModel[] List<HomeLoginBonusRewardItemIconViewModel> Pointer
    // 028 NextLoginBonusSheet                      ModelClassType HomeLoginBonusViewModel HomeLoginBonusViewModel HomeLoginBonusViewModel Pointer
    // 030 IsAnnounceNext                           ModelPrimitiveType bool bool bool Bool
    public partial class HomeLoginBonusViewModel : DataModel
    {
        public LoginBonusViewType                       ViewType                                { get; set; }
        public ILoginBonusStatus?                       LoginBonus                              { get; set; }
        public List<HomeLoginBonusRewardItemIconViewModel>? RewardItemListViewModels                { get; set; }
        public HomeLoginBonusViewModel?                 NextLoginBonusSheet                     { get; set; }
        public bool                                     IsAnnounceNext                          { get; set; }

        public static HomeLoginBonusViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeLoginBonusViewModel() { Pointer= p0 };

            value.ViewType                                  = (LoginBonusViewType)GetInt32(new IntPtr(p + 0x010)); // 0x10 ViewType                    ( ModelEnumType LoginBonusViewType LoginBonusViewType LoginBonusViewType Int32 )
            value.LoginBonus                                = GetObject<ILoginBonusStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ILoginBonusStatus.FromPointer); // 0x18 LoginBonus                  ( ModelClassType ILoginBonusStatus ILoginBonusStatus ILoginBonusStatus Pointer )
            value.RewardItemListViewModels                  = GetObjectList<HomeLoginBonusRewardItemIconViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.HomeLoginBonusRewardItemIconViewModel.FromPointer); // 0x20 RewardItemListViewModels    ( ModelClassListType HomeLoginBonusRewardItemIconViewModel[] HomeLoginBonusRewardItemIconViewModel[] List<HomeLoginBonusRewardItemIconViewModel> Pointer )
            value.NextLoginBonusSheet                       = GetObject<HomeLoginBonusViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.HomeLoginBonusViewModel.FromPointer); // 0x28 NextLoginBonusSheet         ( ModelClassType HomeLoginBonusViewModel HomeLoginBonusViewModel HomeLoginBonusViewModel Pointer )
            value.IsAnnounceNext                            = GetBool(new IntPtr(p + 0x030)); // 0x30 IsAnnounceNext              ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
