using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AchievementFilterCheckBoxes              ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 028 FilterResetButton                        ModelClassType UIButton UIButton UIButton Pointer
    // 030 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 038 onChangeFilter                           Subject`1<SortFilterSettings> IL2CPP_TYPE_GENERICINST
    // 040 SortFilterSettings                       ModelClassType SortFilterSettings SortFilterSettings SortFilterSettings Pointer
    // 048 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProfileAchievementSortFilterPopupView : DataModel
    {
        public List<ToggleButton>?                      AchievementFilterCheckBoxes             { get; set; }
        public UIButton?                                FilterResetButton                       { get; set; }
        public SortFilterSettings?                      SortFilterSettings                      { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ProfileAchievementSortFilterPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileAchievementSortFilterPopupView() { Pointer= p0 };

            value.AchievementFilterCheckBoxes               = GetObjectList<ToggleButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x20 AchievementFilterCheckBoxes ( ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.FilterResetButton                         = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0x28 FilterResetButton           ( ModelClassType UIButton UIButton UIButton Pointer )
            value.SortFilterSettings                        = GetObject<SortFilterSettings>(new IntPtr(p + 0x040), ReversePrism.DataModels.SortFilterSettings.FromPointer); // 0x40 SortFilterSettings          ( ModelClassType SortFilterSettings SortFilterSettings SortFilterSettings Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x048), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x48 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
