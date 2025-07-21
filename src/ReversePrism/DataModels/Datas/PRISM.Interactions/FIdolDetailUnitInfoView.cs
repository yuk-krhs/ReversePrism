using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 ImgUnit                                  ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 030 TxtUnitName                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 BtnUnitDetail                            ModelClassType UIButton UIButton UIButton Pointer
    // 040 ImgTotal                                 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 048 TxtTotal                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 VoDaViMeRankView                         ModelClassType VoDaViMeRankView VoDaViMeRankView VoDaViMeRankView Pointer
    // 058 IdolIconPrefab                           ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 060 IconParent                               ModelClassType RectTransform RectTransform RectTransform Pointer
    // 068 onUnitDetail                             Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 070 onMemberDetail                           Subject`1<string> IL2CPP_TYPE_GENERICINST
    public partial class FIdolDetailUnitInfoView : DataModel
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public UIRawImage?                              ImgUnit                                 { get; set; }
        public UITextMeshProUGUI?                       TxtUnitName                             { get; set; }
        public UIButton?                                BtnUnitDetail                           { get; set; }
        public UIRawImage?                              ImgTotal                                { get; set; }
        public UITextMeshProUGUI?                       TxtTotal                                { get; set; }
        public VoDaViMeRankView?                        VoDaViMeRankView                        { get; set; }
        public PFIdolIconView?                          IdolIconPrefab                          { get; set; }
        public RectTransform?                           IconParent                              { get; set; }

        public static FIdolDetailUnitInfoView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FIdolDetailUnitInfoView() { Pointer= p0 };

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x20 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.ImgUnit                                   = GetObject<UIRawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x28 ImgUnit                     ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.TxtUnitName                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 TxtUnitName                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnUnitDetail                             = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 BtnUnitDetail               ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ImgTotal                                  = GetObject<UIRawImage>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x40 ImgTotal                    ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.TxtTotal                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 TxtTotal                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.VoDaViMeRankView                          = GetObject<VoDaViMeRankView>(new IntPtr(p + 0x050), ReversePrism.DataModels.VoDaViMeRankView.FromPointer); // 0x50 VoDaViMeRankView            ( ModelClassType VoDaViMeRankView VoDaViMeRankView VoDaViMeRankView Pointer )
            value.IdolIconPrefab                            = GetObject<PFIdolIconView>(new IntPtr(p + 0x058), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0x58 IdolIconPrefab              ( ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.IconParent                                = GetObject<RectTransform>(new IntPtr(p + 0x060), ReversePrism.DataModels.RectTransform.FromPointer); // 0x60 IconParent                  ( ModelClassType RectTransform RectTransform RectTransform Pointer )

            return value;
        }
    }
}
