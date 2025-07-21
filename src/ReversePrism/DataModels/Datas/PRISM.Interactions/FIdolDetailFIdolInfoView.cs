using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TxtAlias                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 TxtName                                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 ImgFavoriteMark                          ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 038 BtnFavorite                              ModelClassType UIButton UIButton UIButton Pointer
    // 040 IconView                                 ModelClassType PFIdolIconRectView PFIdolIconRectView PFIdolIconRectView Pointer
    // 048 VoDaViMeRankView                         ModelClassType VoDaViMeRankView VoDaViMeRankView VoDaViMeRankView Pointer
    // 050 BaseParameterView                        ModelClassType VoDaViMeView VoDaViMeView VoDaViMeView Pointer
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

            value.TxtAlias                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 TxtAlias                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtName                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 TxtName                     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ImgFavoriteMark                           = GetObject<UIRawImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x30 ImgFavoriteMark             ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.BtnFavorite                               = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 BtnFavorite                 ( ModelClassType UIButton UIButton UIButton Pointer )
            value.IconView                                  = GetObject<PFIdolIconRectView>(new IntPtr(p + 0x040), ReversePrism.DataModels.PFIdolIconRectView.FromPointer); // 0x40 IconView                    ( ModelClassType PFIdolIconRectView PFIdolIconRectView PFIdolIconRectView Pointer )
            value.VoDaViMeRankView                          = GetObject<VoDaViMeRankView>(new IntPtr(p + 0x048), ReversePrism.DataModels.VoDaViMeRankView.FromPointer); // 0x48 VoDaViMeRankView            ( ModelClassType VoDaViMeRankView VoDaViMeRankView VoDaViMeRankView Pointer )
            value.BaseParameterView                         = GetObject<VoDaViMeView>(new IntPtr(p + 0x050), ReversePrism.DataModels.VoDaViMeView.FromPointer); // 0x50 BaseParameterView           ( ModelClassType VoDaViMeView VoDaViMeView VoDaViMeView Pointer )

            return value;
        }
    }
}
