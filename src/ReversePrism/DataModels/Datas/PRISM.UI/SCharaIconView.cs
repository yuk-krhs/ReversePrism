using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 CgFade                                   000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 068 FadeDuration                             0001866656B0 ModelPrimitiveType float float float Single
    // 070 Btn                                      0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 078 ImgChara                                 000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 080 ImgFrame                                 000186613440 ModelClassType RawImage RawImage RawImage Pointer
    // 088 CgBadge                                  000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 090 GrayOutController                        0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 098 onClickSubject                           Subject`1<ValueTuple`2<int, GameObject>> IL2CPP_TYPE_GENERICINST
    // 0A0 onLongPressSubject                       Subject`1<ValueTuple`2<int, GameObject>> IL2CPP_TYPE_GENERICINST
    // 0A8 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 0B0 Index                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class SCharaIconView
    {
        public CanvasGroup?                             CgFade                                  { get; set; }
        public float                                    FadeDuration                            { get; set; }
        public UIButton?                                Btn                                     { get; set; }
        public RawImage?                                ImgChara                                { get; set; }
        public RawImage?                                ImgFrame                                { get; set; }
        public CanvasGroup?                             CgBadge                                 { get; set; }
        public UIGrayOutController?                     GrayOutController                       { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public int                                      Index                                   { get; set; }

        public static SCharaIconView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SCharaIconView();

            value.CgFade                                    = GetObject<CanvasGroup>(new IntPtr(p + 0x060), ReversePrism.DataModels.CanvasGroup.FromPointer); // 027005B21B50 0x60 CgFade                      ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.FadeDuration                              = GetSingle(new IntPtr(p + 0x068)); // 027005B21B70 0x68 FadeDuration                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Btn                                       = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 027005B21B90 0x70 Btn                         ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ImgChara                                  = GetObject<RawImage>(new IntPtr(p + 0x078), ReversePrism.DataModels.RawImage.FromPointer); // 027005B21BB0 0x78 ImgChara                    ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.ImgFrame                                  = GetObject<RawImage>(new IntPtr(p + 0x080), ReversePrism.DataModels.RawImage.FromPointer); // 027005B21BD0 0x80 ImgFrame                    ( 000186613440 ModelClassType RawImage RawImage RawImage Pointer )
            value.CgBadge                                   = GetObject<CanvasGroup>(new IntPtr(p + 0x088), ReversePrism.DataModels.CanvasGroup.FromPointer); // 027005B21BF0 0x88 CgBadge                     ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.GrayOutController                         = GetObject<UIGrayOutController>(new IntPtr(p + 0x090), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 027005B21C10 0x90 GrayOutController           ( 0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 027005B21C70 0xA8 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x0B0)); // 027005B21C90 0xB0 Index                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
