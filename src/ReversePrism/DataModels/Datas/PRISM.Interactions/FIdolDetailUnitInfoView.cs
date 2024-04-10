using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 ImgUnit                                  0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 030 TxtUnitName                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 BtnUnitDetail                            0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 ImgTotal                                 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 048 TxtTotal                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 VoDaViMeRankView                         000186530E30 ModelClassType VoDaViMeRankView VoDaViMeRankView VoDaViMeRankView Pointer
    // 058 IdolIconPrefab                           000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 060 IconParent                               000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
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

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A301648 0x20 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.ImgUnit                                   = GetObject<UIRawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIRawImage.FromPointer); // 02466A301668 0x28 ImgUnit                     ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.TxtUnitName                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A301688 0x30 TxtUnitName                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnUnitDetail                             = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 02466A3016A8 0x38 BtnUnitDetail               ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ImgTotal                                  = GetObject<UIRawImage>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIRawImage.FromPointer); // 02466A3016C8 0x40 ImgTotal                    ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.TxtTotal                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A3016E8 0x48 TxtTotal                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.VoDaViMeRankView                          = GetObject<VoDaViMeRankView>(new IntPtr(p + 0x050), ReversePrism.DataModels.VoDaViMeRankView.FromPointer); // 02466A301708 0x50 VoDaViMeRankView            ( 000186530E30 ModelClassType VoDaViMeRankView VoDaViMeRankView VoDaViMeRankView Pointer )
            value.IdolIconPrefab                            = GetObject<PFIdolIconView>(new IntPtr(p + 0x058), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 02466A301728 0x58 IdolIconPrefab              ( 000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.IconParent                                = GetObject<RectTransform>(new IntPtr(p + 0x060), ReversePrism.DataModels.RectTransform.FromPointer); // 02466A301748 0x60 IconParent                  ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )

            return value;
        }
    }
}
