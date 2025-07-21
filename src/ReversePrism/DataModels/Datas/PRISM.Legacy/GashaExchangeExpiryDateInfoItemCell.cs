using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ImgBanner                                ModelClassType Image Image Image Pointer
    // 028 TxtNm                                    ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 TxtLimit                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 BtnGotoGasha                             ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 040 TxtHavePoint                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 TxtExpiryDate                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class GashaExchangeExpiryDateInfoItemCell : DataModel
    {
        public Image?                                   ImgBanner                               { get; set; }
        public UITextMeshProUGUI?                       TxtNm                                   { get; set; }
        public UITextMeshProUGUI?                       TxtLimit                                { get; set; }
        public ButtonBase?                              BtnGotoGasha                            { get; set; }
        public UITextMeshProUGUI?                       TxtHavePoint                            { get; set; }
        public UITextMeshProUGUI?                       TxtExpiryDate                           { get; set; }

        public static GashaExchangeExpiryDateInfoItemCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaExchangeExpiryDateInfoItemCell() { Pointer= p0 };

            value.ImgBanner                                 = GetObject<Image>(new IntPtr(p + 0x020), ReversePrism.DataModels.Image.FromPointer); // 0x20 ImgBanner                   ( ModelClassType Image Image Image Pointer )
            value.TxtNm                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 TxtNm                       ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtLimit                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 TxtLimit                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnGotoGasha                              = GetObject<ButtonBase>(new IntPtr(p + 0x038), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x38 BtnGotoGasha                ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.TxtHavePoint                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 TxtHavePoint                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtExpiryDate                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 TxtExpiryDate               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
