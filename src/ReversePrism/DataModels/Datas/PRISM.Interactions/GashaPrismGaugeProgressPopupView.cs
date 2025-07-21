using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PrismGauge                               ModelClassType PrismGauge PrismGauge PrismGauge Pointer
    // 028 TxtOld                                   ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 TxtNew                                   ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 BtnFront                                 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 040 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 048 IsGaugeAnimation                         ModelPrimitiveType bool bool bool Bool
    // 050 onClose                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 058 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class GashaPrismGaugeProgressPopupView : DataModel
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
            var value   = new GashaPrismGaugeProgressPopupView() { Pointer= p0 };

            value.PrismGauge                                = GetObject<PrismGauge>(new IntPtr(p + 0x020), ReversePrism.DataModels.PrismGauge.FromPointer); // 0x20 PrismGauge                  ( ModelClassType PrismGauge PrismGauge PrismGauge Pointer )
            value.TxtOld                                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 TxtOld                      ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtNew                                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 TxtNew                      ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnFront                                  = GetObject<ButtonBase>(new IntPtr(p + 0x038), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x38 BtnFront                    ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x040), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x40 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.IsGaugeAnimation                          = GetBool(new IntPtr(p + 0x048)); // 0x48 IsGaugeAnimation            ( ModelPrimitiveType bool bool bool Bool )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x058), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x58 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
