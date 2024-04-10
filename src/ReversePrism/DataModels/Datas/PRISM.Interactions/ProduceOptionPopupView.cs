using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CommuSkipGroup                           000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 028 IdolSkillSkipGroup                       000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 030 ConfirmSkipGroup                         000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 038 AutoGroup                                000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 040 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 048 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProduceOptionPopupView : DataModel
    {
        public ToggleButtonGroup?                       CommuSkipGroup                          { get; set; }
        public ToggleButtonGroup?                       IdolSkillSkipGroup                      { get; set; }
        public ToggleButtonGroup?                       ConfirmSkipGroup                        { get; set; }
        public ToggleButtonGroup?                       AutoGroup                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ProduceOptionPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceOptionPopupView() { Pointer= p0 };

            value.CommuSkipGroup                            = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 02466A178A60 0x20 CommuSkipGroup              ( 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.IdolSkillSkipGroup                        = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 02466A178A80 0x28 IdolSkillSkipGroup          ( 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.ConfirmSkipGroup                          = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x030), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 02466A178AA0 0x30 ConfirmSkipGroup            ( 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.AutoGroup                                 = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 02466A178AC0 0x38 AutoGroup                   ( 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x048), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466A178B00 0x48 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
