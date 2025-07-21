using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 CgFade                                   ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 068 FadeDuration                             ModelPrimitiveType float float float Single
    // 070 Btn                                      ModelClassType UIButton UIButton UIButton Pointer
    // 078 ImgChara                                 ModelClassType RawImage RawImage RawImage Pointer
    // 080 ImgFrame                                 ModelClassType RawImage RawImage RawImage Pointer
    // 088 CgBadge                                  ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 090 GrayOutController                        ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 098 onClickSubject                           Subject`1<ValueTuple`2<int, GameObject>> IL2CPP_TYPE_GENERICINST
    // 0A0 onLongPressSubject                       Subject`1<ValueTuple`2<int, GameObject>> IL2CPP_TYPE_GENERICINST
    // 0A8 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 0B0 Index                                    ModelPrimitiveType int int int Int32
    public partial class SCharaIconView : DataModel
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
            var value   = new SCharaIconView() { Pointer= p0 };

            value.CgFade                                    = GetObject<CanvasGroup>(new IntPtr(p + 0x060), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x60 CgFade                      ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.FadeDuration                              = GetSingle(new IntPtr(p + 0x068)); // 0x68 FadeDuration                ( ModelPrimitiveType float float float Single )
            value.Btn                                       = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 0x70 Btn                         ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ImgChara                                  = GetObject<RawImage>(new IntPtr(p + 0x078), ReversePrism.DataModels.RawImage.FromPointer); // 0x78 ImgChara                    ( ModelClassType RawImage RawImage RawImage Pointer )
            value.ImgFrame                                  = GetObject<RawImage>(new IntPtr(p + 0x080), ReversePrism.DataModels.RawImage.FromPointer); // 0x80 ImgFrame                    ( ModelClassType RawImage RawImage RawImage Pointer )
            value.CgBadge                                   = GetObject<CanvasGroup>(new IntPtr(p + 0x088), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x88 CgBadge                     ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.GrayOutController                         = GetObject<UIGrayOutController>(new IntPtr(p + 0x090), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0x90 GrayOutController           ( ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0xA8 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 Index                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
