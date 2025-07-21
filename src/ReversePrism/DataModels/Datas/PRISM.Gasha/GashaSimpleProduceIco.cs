using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 Btn                                      ModelClassType UIButton UIButton UIButton Pointer
    // 030 ImgBg                                    ModelClassType Image Image Image Pointer
    // 038 ImgIdol                                  ModelClassType RawImage RawImage RawImage Pointer
    // 040 ImgFrame                                 ModelClassType Image Image Image Pointer
    // 048 ImgUnit                                  ModelClassType RawImage RawImage RawImage Pointer
    // 050 PIdolDetailPopupCaller                   ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer
    // 058 Ct                                       ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 060 IsSetUp                                  ModelPrimitiveType bool bool bool Bool
    public partial class GashaSimpleProduceIco : DataModel
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public UIButton?                                Btn                                     { get; set; }
        public Image?                                   ImgBg                                   { get; set; }
        public RawImage?                                ImgIdol                                 { get; set; }
        public Image?                                   ImgFrame                                { get; set; }
        public RawImage?                                ImgUnit                                 { get; set; }
        public PIdolDetailPopupCaller?                  PIdolDetailPopupCaller                  { get; set; }
        public CancellationToken                        Ct                                      { get; set; }
        public bool                                     IsSetUp                                 { get; set; }

        public static GashaSimpleProduceIco? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaSimpleProduceIco() { Pointer= p0 };

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x20 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.Btn                                       = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0x28 Btn                         ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ImgBg                                     = GetObject<Image>(new IntPtr(p + 0x030), ReversePrism.DataModels.Image.FromPointer); // 0x30 ImgBg                       ( ModelClassType Image Image Image Pointer )
            value.ImgIdol                                   = GetObject<RawImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.RawImage.FromPointer); // 0x38 ImgIdol                     ( ModelClassType RawImage RawImage RawImage Pointer )
            value.ImgFrame                                  = GetObject<Image>(new IntPtr(p + 0x040), ReversePrism.DataModels.Image.FromPointer); // 0x40 ImgFrame                    ( ModelClassType Image Image Image Pointer )
            value.ImgUnit                                   = GetObject<RawImage>(new IntPtr(p + 0x048), ReversePrism.DataModels.RawImage.FromPointer); // 0x48 ImgUnit                     ( ModelClassType RawImage RawImage RawImage Pointer )
            value.PIdolDetailPopupCaller                    = GetObject<PIdolDetailPopupCaller>(new IntPtr(p + 0x050), ReversePrism.DataModels.PIdolDetailPopupCaller.FromPointer); // 0x50 PIdolDetailPopupCaller      ( ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer )
            value.Ct                                        = (CancellationToken)GetInt32(new IntPtr(p + 0x058)); // 0x58 Ct                          ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.IsSetUp                                   = GetBool(new IntPtr(p + 0x060)); // 0x60 IsSetUp                     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
