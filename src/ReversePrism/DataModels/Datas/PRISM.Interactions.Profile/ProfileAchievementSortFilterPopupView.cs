using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AchievementFilterCheckBoxes              000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 028 FilterResetButton                        0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 030 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 038 onChangeFilter                           Subject`1<SortFilterSettings> IL2CPP_TYPE_GENERICINST
    // 040 SortFilterSettings                       0001865300A0 ModelClassType SortFilterSettings SortFilterSettings SortFilterSettings Pointer
    // 048 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
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

            value.AchievementFilterCheckBoxes               = GetObjectList<ToggleButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButton.FromPointer); // 02466B797398 0x20 AchievementFilterCheckBoxes ( 000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.FilterResetButton                         = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 02466B7973B8 0x28 FilterResetButton           ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.SortFilterSettings                        = GetObject<SortFilterSettings>(new IntPtr(p + 0x040), ReversePrism.DataModels.SortFilterSettings.FromPointer); // 02466B797418 0x40 SortFilterSettings          ( 0001865300A0 ModelClassType SortFilterSettings SortFilterSettings SortFilterSettings Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x048), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466B797438 0x48 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
