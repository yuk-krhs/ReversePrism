using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PrismGauge                               000186515A20 ModelClassType PrismGauge PrismGauge PrismGauge Pointer
    // 028 TxtOld                                   0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 TxtNew                                   0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 BtnFront                                 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 040 Cts                                      0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 048 IsGaugeAnimation                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 050 onClose                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 058 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class GashaPrismGaugeProgressPopupView
    {
        public PrismGauge?                              PrismGauge                              { get; set; }
        public UITextMeshProUGUI?                       TxtOld                                  { get; set; }
        public UITextMeshProUGUI?                       TxtNew                                  { get; set; }
        public ButtonBase?                              BtnFront                                { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public bool                                     IsGaugeAnimation                        { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static GashaPrismGaugeProgressPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaPrismGaugeProgressPopupView();

            value.PrismGauge                                = GetObject<PrismGauge>(new IntPtr(p + 0x020), ReversePrism.DataModels.PrismGauge.FromPointer); // 0270DBA128E8 0x20 PrismGauge                  ( 000186515A20 ModelClassType PrismGauge PrismGauge PrismGauge Pointer )
            value.TxtOld                                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DBA12908 0x28 TxtOld                      ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtNew                                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DBA12928 0x30 TxtNew                      ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnFront                                  = GetObject<ButtonBase>(new IntPtr(p + 0x038), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270DBA12948 0x38 BtnFront                    ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x040), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270DBA12968 0x40 Cts                         ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.IsGaugeAnimation                          = GetBool(new IntPtr(p + 0x048)); // 0270DBA12988 0x48 IsGaugeAnimation            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x058), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DBA129C8 0x58 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
