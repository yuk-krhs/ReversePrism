using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 LastOffsets                              000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 028 ManualAdjustInput                        0001866C3830 ModelClassType NumericInput NumericInput NumericInput Pointer
    // 030 TapButton                                000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 038 onClick                                  Subject`1<ValueTuple`2<bool, float>> IL2CPP_TYPE_GENERICINST
    // 040 Offset                                   0001866656B0 ModelPrimitiveType float float float Single
    // 048 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class LiveAudioOffsetSettingPopupView
    {
        public List<UITextMeshProUGUI>?                 LastOffsets                             { get; set; }
        public NumericInput?                            ManualAdjustInput                       { get; set; }
        public ButtonBase?                              TapButton                               { get; set; }
        public float                                    Offset                                  { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static LiveAudioOffsetSettingPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveAudioOffsetSettingPopupView();

            value.LastOffsets                               = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB40AE40 0x20 LastOffsets                 ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.ManualAdjustInput                         = GetObject<NumericInput>(new IntPtr(p + 0x028), ReversePrism.DataModels.NumericInput.FromPointer); // 0270DB40AE60 0x28 ManualAdjustInput           ( 0001866C3830 ModelClassType NumericInput NumericInput NumericInput Pointer )
            value.TapButton                                 = GetObject<ButtonBase>(new IntPtr(p + 0x030), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270DB40AE80 0x30 TapButton                   ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.Offset                                    = GetSingle(new IntPtr(p + 0x040)); // 0270DB40AEC0 0x40 Offset                      ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x048), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DB40AEE0 0x48 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
