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
    public partial class FIdolDetailFIdolInfoView : DataModel
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
            var value   = new FIdolDetailFIdolInfoView() { Pointer= p0 };

            value.TxtAlias                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A3011E0 0x20 TxtAlias                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtName                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A301200 0x28 TxtName                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ImgFavoriteMark                           = GetObject<UIRawImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIRawImage.FromPointer); // 02466A301220 0x30 ImgFavoriteMark             ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.BtnFavorite                               = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 02466A301240 0x38 BtnFavorite                 ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.IconView                                  = GetObject<PFIdolIconRectView>(new IntPtr(p + 0x040), ReversePrism.DataModels.PFIdolIconRectView.FromPointer); // 02466A301260 0x40 IconView                    ( 000186703B70 ModelClassType PFIdolIconRectView PFIdolIconRectView PFIdolIconRectView Pointer )
            value.VoDaViMeRankView                          = GetObject<VoDaViMeRankView>(new IntPtr(p + 0x048), ReversePrism.DataModels.VoDaViMeRankView.FromPointer); // 02466A301280 0x48 VoDaViMeRankView            ( 000186530E30 ModelClassType VoDaViMeRankView VoDaViMeRankView VoDaViMeRankView Pointer )
            value.BaseParameterView                         = GetObject<VoDaViMeView>(new IntPtr(p + 0x050), ReversePrism.DataModels.VoDaViMeView.FromPointer); // 02466A3012A0 0x50 BaseParameterView           ( 000186531810 ModelClassType VoDaViMeView VoDaViMeView VoDaViMeView Pointer )

            return value;
        }
    }
}
