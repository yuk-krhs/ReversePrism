using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TxtAlias                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 TxtName                                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 ImgFavoriteMark                          0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 038 BtnFavorite                              0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 IconView                                 000186703B70 ModelClassType PFIdolIconRectView PFIdolIconRectView PFIdolIconRectView Pointer
    // 048 VoDaViMeRankView                         000186530E30 ModelClassType VoDaViMeRankView VoDaViMeRankView VoDaViMeRankView Pointer
    // 050 BaseParameterView                        000186531810 ModelClassType VoDaViMeView VoDaViMeView VoDaViMeView Pointer
    // 058 onFavorite                               Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class FIdolDetailFIdolInfoView
    {
        public UITextMeshProUGUI?                       TxtAlias                                { get; set; }
        public UITextMeshProUGUI?                       TxtName                                 { get; set; }
        public UIRawImage?                              ImgFavoriteMark                         { get; set; }
        public UIButton?                                BtnFavorite                             { get; set; }
        public PFIdolIconRectView?                      IconView                                { get; set; }
        public VoDaViMeRankView?                        VoDaViMeRankView                        { get; set; }
        public VoDaViMeView?                            BaseParameterView                       { get; set; }

        public static FIdolDetailFIdolInfoView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FIdolDetailFIdolInfoView();

            value.TxtAlias                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA2ADBF8 0x20 TxtAlias                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtName                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA2ADC18 0x28 TxtName                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ImgFavoriteMark                           = GetObject<UIRawImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIRawImage.FromPointer); // 0270DA2ADC38 0x30 ImgFavoriteMark             ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.BtnFavorite                               = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA2ADC58 0x38 BtnFavorite                 ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.IconView                                  = GetObject<PFIdolIconRectView>(new IntPtr(p + 0x040), ReversePrism.DataModels.PFIdolIconRectView.FromPointer); // 0270DA2ADC78 0x40 IconView                    ( 000186703B70 ModelClassType PFIdolIconRectView PFIdolIconRectView PFIdolIconRectView Pointer )
            value.VoDaViMeRankView                          = GetObject<VoDaViMeRankView>(new IntPtr(p + 0x048), ReversePrism.DataModels.VoDaViMeRankView.FromPointer); // 0270DA2ADC98 0x48 VoDaViMeRankView            ( 000186530E30 ModelClassType VoDaViMeRankView VoDaViMeRankView VoDaViMeRankView Pointer )
            value.BaseParameterView                         = GetObject<VoDaViMeView>(new IntPtr(p + 0x050), ReversePrism.DataModels.VoDaViMeView.FromPointer); // 0270DA2ADCB8 0x50 BaseParameterView           ( 000186531810 ModelClassType VoDaViMeView VoDaViMeView VoDaViMeView Pointer )

            return value;
        }
    }
}
