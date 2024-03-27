using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ImgUnitIcon                              000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 028 FUnitIconView                            00018654D050 ModelClassType FUnitIconView FUnitIconView FUnitIconView Pointer
    // 030 TxtUnitName                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 ImgTotalRank                             000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 040 RankEffectAnimator                       00018671A280 ModelClassType ParamRememberableAnimator ParamRememberableAnimator ParamRememberableAnimator Pointer
    // 048 TxtTotal                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 VoDaViMeRankView                         000186530E30 ModelClassType VoDaViMeRankView VoDaViMeRankView VoDaViMeRankView Pointer
    // 058 BtnEditUnitName                          0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 060 ImgFavoriteMark                          000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 068 BtnFavoriteMark                          0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 070 BtnParameterDetail                       0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 078 Ct                                       00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    public partial class FUnitDetailFUnitInfoView
    {
        public RawImage?                                ImgUnitIcon                             { get; set; }
        public FUnitIconView?                           FUnitIconView                           { get; set; }
        public UITextMeshProUGUI?                       TxtUnitName                             { get; set; }
        public RawImage?                                ImgTotalRank                            { get; set; }
        public ParamRememberableAnimator?               RankEffectAnimator                      { get; set; }
        public UITextMeshProUGUI?                       TxtTotal                                { get; set; }
        public VoDaViMeRankView?                        VoDaViMeRankView                        { get; set; }
        public UIButton?                                BtnEditUnitName                         { get; set; }
        public RawImage?                                ImgFavoriteMark                         { get; set; }
        public UIButton?                                BtnFavoriteMark                         { get; set; }
        public UIButton?                                BtnParameterDetail                      { get; set; }
        public CancellationToken                        Ct                                      { get; set; }

        public static FUnitDetailFUnitInfoView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FUnitDetailFUnitInfoView();

            value.ImgUnitIcon                               = GetObject<RawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.RawImage.FromPointer); // 0270DA2C5BB8 0x20 ImgUnitIcon                 ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.FUnitIconView                             = GetObject<FUnitIconView>(new IntPtr(p + 0x028), ReversePrism.DataModels.FUnitIconView.FromPointer); // 0270DA2C5BD8 0x28 FUnitIconView               ( 00018654D050 ModelClassType FUnitIconView FUnitIconView FUnitIconView Pointer )
            value.TxtUnitName                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA2C5BF8 0x30 TxtUnitName                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ImgTotalRank                              = GetObject<RawImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.RawImage.FromPointer); // 0270DA2C5C18 0x38 ImgTotalRank                ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.RankEffectAnimator                        = GetObject<ParamRememberableAnimator>(new IntPtr(p + 0x040), ReversePrism.DataModels.ParamRememberableAnimator.FromPointer); // 0270DA2C5C38 0x40 RankEffectAnimator          ( 00018671A280 ModelClassType ParamRememberableAnimator ParamRememberableAnimator ParamRememberableAnimator Pointer )
            value.TxtTotal                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA2C5C58 0x48 TxtTotal                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.VoDaViMeRankView                          = GetObject<VoDaViMeRankView>(new IntPtr(p + 0x050), ReversePrism.DataModels.VoDaViMeRankView.FromPointer); // 0270DA2C5C78 0x50 VoDaViMeRankView            ( 000186530E30 ModelClassType VoDaViMeRankView VoDaViMeRankView VoDaViMeRankView Pointer )
            value.BtnEditUnitName                           = GetObject<UIButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA2C5C98 0x58 BtnEditUnitName             ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ImgFavoriteMark                           = GetObject<RawImage>(new IntPtr(p + 0x060), ReversePrism.DataModels.RawImage.FromPointer); // 0270DA2C5CB8 0x60 ImgFavoriteMark             ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.BtnFavoriteMark                           = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA2C5CD8 0x68 BtnFavoriteMark             ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnParameterDetail                        = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA2C5CF8 0x70 BtnParameterDetail          ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.Ct                                        = (CancellationToken)GetInt32(new IntPtr(p + 0x078)); // 0270DA2C5D18 0x78 Ct                          ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )

            return value;
        }
    }
}
