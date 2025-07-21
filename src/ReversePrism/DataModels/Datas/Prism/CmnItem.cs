using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ImgItem                                  ModelClassType RawImage RawImage RawImage Pointer
    // 028 ImgItemBase                              ModelClassType RawImage RawImage RawImage Pointer
    // 030 ImgItemFrame                             ModelClassType RawImage RawImage RawImage Pointer
    // 038 Btn                                      ModelClassType UIButton UIButton UIButton Pointer
    // 040 Cg                                       ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 048 TxtNum                                   ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 GoBadge                                  ModelClassType GameObject GameObject GameObject Pointer
    // 058 GoNew                                    ModelClassType GameObject GameObject GameObject Pointer
    // 060 GoGlow                                   ModelClassType GameObject GameObject GameObject Pointer
    // 068 GrayOutController                        ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
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

            value.ImgItem                                   = GetObject<RawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.RawImage.FromPointer); // 0x20 ImgItem                     ( ModelClassType RawImage RawImage RawImage Pointer )
            value.ImgItemBase                               = GetObject<RawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.RawImage.FromPointer); // 0x28 ImgItemBase                 ( ModelClassType RawImage RawImage RawImage Pointer )
            value.ImgItemFrame                              = GetObject<RawImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.RawImage.FromPointer); // 0x30 ImgItemFrame                ( ModelClassType RawImage RawImage RawImage Pointer )
            value.Btn                                       = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 Btn                         ( ModelClassType UIButton UIButton UIButton Pointer )
            value.Cg                                        = GetObject<CanvasGroup>(new IntPtr(p + 0x040), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x40 Cg                          ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.TxtNum                                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 TxtNum                      ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoBadge                                   = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 GoBadge                     ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GoNew                                     = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 GoNew                       ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GoGlow                                    = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0x60 GoGlow                      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GrayOutController                         = GetObject<UIGrayOutController>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0x68 GrayOutController           ( ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )

            return value;
        }
    }
}
