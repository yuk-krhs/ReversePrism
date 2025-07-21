using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ImgUnitIcon                              ModelClassType RawImage RawImage RawImage Pointer
    // 028 FUnitIconView                            ModelClassType FUnitIconView FUnitIconView FUnitIconView Pointer
    // 030 TxtUnitName                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 ImgTotalRank                             ModelClassType RawImage RawImage RawImage Pointer
    // 040 RankEffectAnimator                       ModelClassType ParamRememberableAnimator ParamRememberableAnimator ParamRememberableAnimator Pointer
    // 048 TxtTotal                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 VoDaViMeRankView                         ModelClassType VoDaViMeRankView VoDaViMeRankView VoDaViMeRankView Pointer
    // 058 BtnEditUnitName                          ModelClassType UIButton UIButton UIButton Pointer
    // 060 ImgFavoriteMark                          ModelClassType RawImage RawImage RawImage Pointer
    // 068 BtnFavoriteMark                          ModelClassType UIButton UIButton UIButton Pointer
    // 070 Ct                                       ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 078 onEditName                               Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 080 onChangeFavoriteMark                     Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class FUnitDetailFUnitInfoView : DataModel
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
        public CancellationToken                        Ct                                      { get; set; }

        public static FUnitDetailFUnitInfoView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FUnitDetailFUnitInfoView() { Pointer= p0 };

            value.ImgUnitIcon                               = GetObject<RawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.RawImage.FromPointer); // 0x20 ImgUnitIcon                 ( ModelClassType RawImage RawImage RawImage Pointer )
            value.FUnitIconView                             = GetObject<FUnitIconView>(new IntPtr(p + 0x028), ReversePrism.DataModels.FUnitIconView.FromPointer); // 0x28 FUnitIconView               ( ModelClassType FUnitIconView FUnitIconView FUnitIconView Pointer )
            value.TxtUnitName                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 TxtUnitName                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ImgTotalRank                              = GetObject<RawImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.RawImage.FromPointer); // 0x38 ImgTotalRank                ( ModelClassType RawImage RawImage RawImage Pointer )
            value.RankEffectAnimator                        = GetObject<ParamRememberableAnimator>(new IntPtr(p + 0x040), ReversePrism.DataModels.ParamRememberableAnimator.FromPointer); // 0x40 RankEffectAnimator          ( ModelClassType ParamRememberableAnimator ParamRememberableAnimator ParamRememberableAnimator Pointer )
            value.TxtTotal                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 TxtTotal                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.VoDaViMeRankView                          = GetObject<VoDaViMeRankView>(new IntPtr(p + 0x050), ReversePrism.DataModels.VoDaViMeRankView.FromPointer); // 0x50 VoDaViMeRankView            ( ModelClassType VoDaViMeRankView VoDaViMeRankView VoDaViMeRankView Pointer )
            value.BtnEditUnitName                           = GetObject<UIButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIButton.FromPointer); // 0x58 BtnEditUnitName             ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ImgFavoriteMark                           = GetObject<RawImage>(new IntPtr(p + 0x060), ReversePrism.DataModels.RawImage.FromPointer); // 0x60 ImgFavoriteMark             ( ModelClassType RawImage RawImage RawImage Pointer )
            value.BtnFavoriteMark                           = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 0x68 BtnFavoriteMark             ( ModelClassType UIButton UIButton UIButton Pointer )
            value.Ct                                        = (CancellationToken)GetInt32(new IntPtr(p + 0x070)); // 0x70 Ct                          ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )

            return value;
        }
    }
}
