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
    // 030 RewardCheckBoxes                         000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 038 FilterResetButton                        0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 filterResetButtonSelectSubject           Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class MissionFilterView
    {
        public List<ToggleButton>?                      AchievedCheckBoxes                      { get; set; }
        public List<ToggleButton>?                      CategoryCheckBoxes                      { get; set; }
        public List<ToggleButton>?                      RewardCheckBoxes                        { get; set; }
        public UIButton?                                FilterResetButton                       { get; set; }

        public static MissionFilterView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionFilterView();

            value.AchievedCheckBoxes                        = GetObjectList<ToggleButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButton.FromPointer); // 0270D55560A8 0x20 AchievedCheckBoxes          ( 000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.CategoryCheckBoxes                        = GetObjectList<ToggleButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.ToggleButton.FromPointer); // 0270D55560C8 0x28 CategoryCheckBoxes          ( 000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.RewardCheckBoxes                          = GetObjectList<ToggleButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.ToggleButton.FromPointer); // 0270D55560E8 0x30 RewardCheckBoxes            ( 000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.FilterResetButton                         = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0270D5556108 0x38 FilterResetButton           ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )

            return value;
        }
    }
}
