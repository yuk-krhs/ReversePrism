using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ResourceTagName                          string IL2CPP_TYPE_STRING
    // 020 SlotPanelViews                           000185B9E0A0 ModelClassListType ProfileAchievementSlotPanelView[] ProfileAchievementSlotPanelView[] List<ProfileAchievementSlotPanelView> Pointer
    // 028 GridView                                 0001865A76B0 ModelClassType ProfileAchievementSelectGridView ProfileAchievementSelectGridView ProfileAchievementSelectGridView Pointer
    // 030 SortFilterView                           000186580020 ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer
    // 038 UiTabGroup                               0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 040 TabBadgeObjects                          000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 048 achievementDetailPopupFactory            PopupViewFactory`1<IAchievementDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 050 achievementSortFilterPopupFactory        PopupViewFactory`1<IProfileAchievementSortFilterPopupView> IL2CPP_TYPE_GENERICINST
    // 058 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 060 onDecide                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 068 onClickTab                               Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 070 onClickSlot                              Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 078 ViewModel                                0001865A8D00 ModelClassType ProfileAchievementSelectViewModel ProfileAchievementSelectViewModel ProfileAchievementSelectViewModel Pointer
    // 080 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProfileAchievementSelectPopupView : DataModel
    {
        public List<ProfileAchievementSlotPanelView>?   SlotPanelViews                          { get; set; }
        public ProfileAchievementSelectGridView?        GridView                                { get; set; }
        public FilterAndSortView?                       SortFilterView                          { get; set; }
        public UITabGroup?                              UiTabGroup                              { get; set; }
        public List<GameObject>?                        TabBadgeObjects                         { get; set; }
        public ProfileAchievementSelectViewModel?       ViewModel                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ProfileAchievementSelectPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileAchievementSelectPopupView() { Pointer= p0 };

            value.SlotPanelViews                            = GetObjectList<ProfileAchievementSlotPanelView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProfileAchievementSlotPanelView.FromPointer); // 02466B787340 0x20 SlotPanelViews              ( 000185B9E0A0 ModelClassListType ProfileAchievementSlotPanelView[] ProfileAchievementSlotPanelView[] List<ProfileAchievementSlotPanelView> Pointer )
            value.GridView                                  = GetObject<ProfileAchievementSelectGridView>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProfileAchievementSelectGridView.FromPointer); // 02466B787360 0x28 GridView                    ( 0001865A76B0 ModelClassType ProfileAchievementSelectGridView ProfileAchievementSelectGridView ProfileAchievementSelectGridView Pointer )
            value.SortFilterView                            = GetObject<FilterAndSortView>(new IntPtr(p + 0x030), ReversePrism.DataModels.FilterAndSortView.FromPointer); // 02466B787380 0x30 SortFilterView              ( 000186580020 ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer )
            value.UiTabGroup                                = GetObject<UITabGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITabGroup.FromPointer); // 02466B7873A0 0x38 UiTabGroup                  ( 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.TabBadgeObjects                           = GetObjectList<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 02466B7873C0 0x40 TabBadgeObjects             ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.ViewModel                                 = GetObject<ProfileAchievementSelectViewModel>(new IntPtr(p + 0x078), ReversePrism.DataModels.ProfileAchievementSelectViewModel.FromPointer); // 02466B7874A0 0x78 ViewModel                   ( 0001865A8D00 ModelClassType ProfileAchievementSelectViewModel ProfileAchievementSelectViewModel ProfileAchievementSelectViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x080), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466B7874C0 0x80 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
