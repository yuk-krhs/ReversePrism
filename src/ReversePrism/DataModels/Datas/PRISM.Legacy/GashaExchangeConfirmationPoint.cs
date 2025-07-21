using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TxtLabel                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 ImgPoint                                 ModelClassType GameObject GameObject GameObject Pointer
    // 030 GashaProductItem                         ModelClassType GashaProductItemPresenter GashaProductItemPresenter GashaProductItemPresenter Pointer
    // 038 TxtLeft                                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 TxtRight                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 GoArrow                                  ModelClassType GameObject GameObject GameObject Pointer
    public partial class GashaExchangeConfirmationPoint : DataModel
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
            var value   = new GashaExchangeConfirmationPoint() { Pointer= p0 };

            value.TxtLabel                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 TxtLabel                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ImgPoint                                  = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 ImgPoint                    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GashaProductItem                          = GetObject<GashaProductItemPresenter>(new IntPtr(p + 0x030), ReversePrism.DataModels.GashaProductItemPresenter.FromPointer); // 0x30 GashaProductItem            ( ModelClassType GashaProductItemPresenter GashaProductItemPresenter GashaProductItemPresenter Pointer )
            value.TxtLeft                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 TxtLeft                     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtRight                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 TxtRight                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoArrow                                   = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 GoArrow                     ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
