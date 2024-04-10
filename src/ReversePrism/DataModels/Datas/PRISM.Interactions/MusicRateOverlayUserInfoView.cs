using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ProduceIdolIcon                          0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 028 UserNameText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 RateView                                 0001866716D0 ModelClassType MusicRateView MusicRateView MusicRateView Pointer
    public partial class MusicRateOverlayUserInfoView : DataModel
    {
        public UIRawImage?                              ProduceIdolIcon                         { get; set; }
        public UITextMeshProUGUI?                       UserNameText                            { get; set; }
        public MusicRateView?                           RateView                                { get; set; }

        public static MusicRateOverlayUserInfoView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicRateOverlayUserInfoView() { Pointer= p0 };

            value.ProduceIdolIcon                           = GetObject<UIRawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIRawImage.FromPointer); // 02466B46CC10 0x20 ProduceIdolIcon             ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.UserNameText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B46CC30 0x28 UserNameText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RateView                                  = GetObject<MusicRateView>(new IntPtr(p + 0x030), ReversePrism.DataModels.MusicRateView.FromPointer); // 02466B46CC50 0x30 RateView                    ( 0001866716D0 ModelClassType MusicRateView MusicRateView MusicRateView Pointer )

            return value;
        }
    }
}
