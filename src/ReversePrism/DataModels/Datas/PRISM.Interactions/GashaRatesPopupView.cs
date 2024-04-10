using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GashaRateView                            0001866139E0 ModelClassType GashaRateView GashaRateView GashaRateView Pointer
    // 028 IconTapInfoText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 onNeedGashaRate                          Func`2<string, UniTask`1<IGetGashaRateReply>> IL2CPP_TYPE_GENERICINST
    // 038 GashaId                                  000186671910 ModelPrimitiveType string string string String
    // 040 ResourceId                               000186671910 ModelPrimitiveType string string string String
    // 048 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 050 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class GashaRatesPopupView : DataModel
    {
        public GashaRateView?                           GashaRateView                           { get; set; }
        public UITextMeshProUGUI?                       IconTapInfoText                         { get; set; }
        public string                                   GashaId                                 { get; set; }
        public string                                   ResourceId                              { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static GashaRatesPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaRatesPopupView() { Pointer= p0 };

            value.GashaRateView                             = GetObject<GashaRateView>(new IntPtr(p + 0x020), ReversePrism.DataModels.GashaRateView.FromPointer); // 02466BA9A0A8 0x20 GashaRateView               ( 0001866139E0 ModelClassType GashaRateView GashaRateView GashaRateView Pointer )
            value.IconTapInfoText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BA9A0C8 0x28 IconTapInfoText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GashaId                                   = GetString(new IntPtr(p + 0x038)); // 02466BA9A108 0x38 GashaId                     ( 000186671910 ModelPrimitiveType string string string String )
            value.ResourceId                                = GetString(new IntPtr(p + 0x040)); // 02466BA9A128 0x40 ResourceId                  ( 000186671910 ModelPrimitiveType string string string String )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x050), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466BA9A168 0x50 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
