using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ImgItem                                  000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 028 ImgItemBase                              000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 030 ImgItemFrame                             000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 038 Btn                                      0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 Cg                                       000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 048 TxtNum                                   0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 GoBadge                                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 058 GoNew                                    0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 060 GoGlow                                   0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 068 GrayOutController                        0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    public partial class CmnItem : DataModel
    {
        public RawImage?                                ImgItem                                 { get; set; }
        public RawImage?                                ImgItemBase                             { get; set; }
        public RawImage?                                ImgItemFrame                            { get; set; }
        public UIButton?                                Btn                                     { get; set; }
        public CanvasGroup?                             Cg                                      { get; set; }
        public UITextMeshProUGUI?                       TxtNum                                  { get; set; }
        public GameObject?                              GoBadge                                 { get; set; }
        public GameObject?                              GoNew                                   { get; set; }
        public GameObject?                              GoGlow                                  { get; set; }
        public UIGrayOutController?                     GrayOutController                       { get; set; }

        public static CmnItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CmnItem() { Pointer= p0 };

            value.ImgItem                                   = GetObject<RawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.RawImage.FromPointer); // 024664F36640 0x20 ImgItem                     ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.ImgItemBase                               = GetObject<RawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.RawImage.FromPointer); // 024664F36660 0x28 ImgItemBase                 ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.ImgItemFrame                              = GetObject<RawImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.RawImage.FromPointer); // 024664F36680 0x30 ImgItemFrame                ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.Btn                                       = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 024664F366A0 0x38 Btn                         ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.Cg                                        = GetObject<CanvasGroup>(new IntPtr(p + 0x040), ReversePrism.DataModels.CanvasGroup.FromPointer); // 024664F366C0 0x40 Cg                          ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.TxtNum                                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024664F366E0 0x48 TxtNum                      ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoBadge                                   = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 024664F36700 0x50 GoBadge                     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoNew                                     = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 024664F36720 0x58 GoNew                       ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoGlow                                    = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 024664F36740 0x60 GoGlow                      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GrayOutController                         = GetObject<UIGrayOutController>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 024664F36760 0x68 GrayOutController           ( 0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )

            return value;
        }
    }
}
