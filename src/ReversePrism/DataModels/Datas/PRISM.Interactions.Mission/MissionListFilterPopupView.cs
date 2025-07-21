using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AchievedCheckBoxes                       ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 028 CategoryCheckBoxes                       ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 030 RewardCheckBoxes                         ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 038 FilterResetButton                        ModelClassType UIButton UIButton UIButton Pointer
    // 040 onClosed                                 Subject`1<HashSet`1<int>[]> IL2CPP_TYPE_GENERICINST
    // 048 ViewModel                                ModelClassType MissionFilterPopupViewModel MissionFilterPopupViewModel MissionFilterPopupViewModel Pointer
    // 050 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class MissionListFilterPopupView : DataModel
    {
        public List<ToggleButton>?                      AchievedCheckBoxes                      { get; set; }
        public List<ToggleButton>?                      CategoryCheckBoxes                      { get; set; }
        public List<ToggleButton>?                      RewardCheckBoxes                        { get; set; }
        public UIButton?                                FilterResetButton                       { get; set; }
        public MissionFilterPopupViewModel?             ViewModel                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static MissionListFilterPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionListFilterPopupView() { Pointer= p0 };

            value.AchievedCheckBoxes                        = GetObjectList<ToggleButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x20 AchievedCheckBoxes          ( ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.CategoryCheckBoxes                        = GetObjectList<ToggleButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x28 CategoryCheckBoxes          ( ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.RewardCheckBoxes                          = GetObjectList<ToggleButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x30 RewardCheckBoxes            ( ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.FilterResetButton                         = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 FilterResetButton           ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ViewModel                                 = GetObject<MissionFilterPopupViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.MissionFilterPopupViewModel.FromPointer); // 0x48 ViewModel                   ( ModelClassType MissionFilterPopupViewModel MissionFilterPopupViewModel MissionFilterPopupViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x050), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x50 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
