using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 Btn                                      0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 030 ImgBg                                    0001866CCDB0 ModelClassType Image Image Image Pointer
    // 038 ImgIdol                                  000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 040 ImgFrame                                 0001866CCDB0 ModelClassType Image Image Image Pointer
    // 048 ImgUnit                                  000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 050 PIdolDetailPopupCaller                   000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer
    // 058 Ct                                       00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 060 IsSetUp                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class GashaSimpleProduceIco
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
            var value   = new GashaSimpleProduceIco();

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270D536A260 0x20 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.Btn                                       = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0270D536A280 0x28 Btn                         ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ImgBg                                     = GetObject<Image>(new IntPtr(p + 0x030), ReversePrism.DataModels.Image.FromPointer); // 0270D536A2A0 0x30 ImgBg                       ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.ImgIdol                                   = GetObject<RawImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.RawImage.FromPointer); // 0270D536A2C0 0x38 ImgIdol                     ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.ImgFrame                                  = GetObject<Image>(new IntPtr(p + 0x040), ReversePrism.DataModels.Image.FromPointer); // 0270D536A2E0 0x40 ImgFrame                    ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.ImgUnit                                   = GetObject<RawImage>(new IntPtr(p + 0x048), ReversePrism.DataModels.RawImage.FromPointer); // 0270D536A300 0x48 ImgUnit                     ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.PIdolDetailPopupCaller                    = GetObject<PIdolDetailPopupCaller>(new IntPtr(p + 0x050), ReversePrism.DataModels.PIdolDetailPopupCaller.FromPointer); // 0270D536A320 0x50 PIdolDetailPopupCaller      ( 000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer )
            value.Ct                                        = (CancellationToken)GetInt32(new IntPtr(p + 0x058)); // 0270D536A340 0x58 Ct                          ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.IsSetUp                                   = GetBool(new IntPtr(p + 0x060)); // 0270D536A360 0x60 IsSetUp                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
