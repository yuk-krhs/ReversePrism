using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SlotPanelViews                           ModelClassListType ProfileAchievementSlotPanelView[] ProfileAchievementSlotPanelView[] List<ProfileAchievementSlotPanelView> Pointer
    // 028 GridView                                 ModelClassType ProfileAchievementSelectGridView ProfileAchievementSelectGridView ProfileAchievementSelectGridView Pointer
    // 030 SortFilterView                           ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer
    // 038 UiTabGroup                               ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 040 TabBadgeObjects                          ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 048 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 050 onDecide                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 058 onClickTab                               Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 060 onClickSlot                              Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 068 ViewModel                                ModelClassType ProfileAchievementSelectViewModel ProfileAchievementSelectViewModel ProfileAchievementSelectViewModel Pointer
    // 070 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 078 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProfileAchievementSelectPopupView : DataModel
    {
        public List<ProfileAchievementSlotPanelView>?   SlotPanelViews                          { get; set; }
        public ProfileAchievementSelectGridView?        GridView                                { get; set; }
        public FilterAndSortView?                       SortFilterView                          { get; set; }
        public UITabGroup?                              UiTabGroup                              { get; set; }
        public List<GameObject>?                        TabBadgeObjects                         { get; set; }
        public ProfileAchievementSelectViewModel?       ViewModel                               { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ProfileAchievementSelectPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileAchievementSelectPopupView() { Pointer= p0 };

            value.SlotPanelViews                            = GetObjectList<ProfileAchievementSlotPanelView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProfileAchievementSlotPanelView.FromPointer); // 0x20 SlotPanelViews              ( ModelClassListType ProfileAchievementSlotPanelView[] ProfileAchievementSlotPanelView[] List<ProfileAchievementSlotPanelView> Pointer )
            value.GridView                                  = GetObject<ProfileAchievementSelectGridView>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProfileAchievementSelectGridView.FromPointer); // 0x28 GridView                    ( ModelClassType ProfileAchievementSelectGridView ProfileAchievementSelectGridView ProfileAchievementSelectGridView Pointer )
            value.SortFilterView                            = GetObject<FilterAndSortView>(new IntPtr(p + 0x030), ReversePrism.DataModels.FilterAndSortView.FromPointer); // 0x30 SortFilterView              ( ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer )
            value.UiTabGroup                                = GetObject<UITabGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITabGroup.FromPointer); // 0x38 UiTabGroup                  ( ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.TabBadgeObjects                           = GetObjectList<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 TabBadgeObjects             ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.ViewModel                                 = GetObject<ProfileAchievementSelectViewModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.ProfileAchievementSelectViewModel.FromPointer); // 0x68 ViewModel                   ( ModelClassType ProfileAchievementSelectViewModel ProfileAchievementSelectViewModel ProfileAchievementSelectViewModel Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x070), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x70 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x078), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x78 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
