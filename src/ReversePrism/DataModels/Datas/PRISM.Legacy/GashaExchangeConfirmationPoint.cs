using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TxtLabel                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 ImgPoint                                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 GashaProductItem                         000186610A30 ModelClassType GashaProductItemPresenter GashaProductItemPresenter GashaProductItemPresenter Pointer
    // 038 TxtLeft                                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 TxtRight                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 GoArrow                                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class GashaExchangeConfirmationPoint
    {
        public UITextMeshProUGUI?                       TxtLabel                                { get; set; }
        public GameObject?                              ImgPoint                                { get; set; }
        public GashaProductItemPresenter?               GashaProductItem                        { get; set; }
        public UITextMeshProUGUI?                       TxtLeft                                 { get; set; }
        public UITextMeshProUGUI?                       TxtRight                                { get; set; }
        public GameObject?                              GoArrow                                 { get; set; }

        public static GashaExchangeConfirmationPoint? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaExchangeConfirmationPoint();

            value.TxtLabel                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5DF97C0 0x20 TxtLabel                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ImgPoint                                  = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5DF97E0 0x28 ImgPoint                    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GashaProductItem                          = GetObject<GashaProductItemPresenter>(new IntPtr(p + 0x030), ReversePrism.DataModels.GashaProductItemPresenter.FromPointer); // 0270D5DF9800 0x30 GashaProductItem            ( 000186610A30 ModelClassType GashaProductItemPresenter GashaProductItemPresenter GashaProductItemPresenter Pointer )
            value.TxtLeft                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5DF9820 0x38 TxtLeft                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtRight                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5DF9840 0x40 TxtRight                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoArrow                                   = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5DF9860 0x48 GoArrow                     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
