using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AchievedCheckBoxes                       000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 028 CategoryCheckBoxes                       000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 030 FilterResetButton                        0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 038 onClosed                                 Subject`1<SortFilterSettings> IL2CPP_TYPE_GENERICINST
    // 040 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class SeasonMissionFilterPopupView
    {
        public List<ToggleButton>?                      AchievedCheckBoxes                      { get; set; }
        public List<ToggleButton>?                      CategoryCheckBoxes                      { get; set; }
        public UIButton?                                FilterResetButton                       { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static SeasonMissionFilterPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SeasonMissionFilterPopupView();

            value.AchievedCheckBoxes                        = GetObjectList<ToggleButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButton.FromPointer); // 0270DBD26780 0x20 AchievedCheckBoxes          ( 000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.CategoryCheckBoxes                        = GetObjectList<ToggleButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.ToggleButton.FromPointer); // 0270DBD267A0 0x28 CategoryCheckBoxes          ( 000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.FilterResetButton                         = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0270DBD267C0 0x30 FilterResetButton           ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DBD26800 0x40 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
