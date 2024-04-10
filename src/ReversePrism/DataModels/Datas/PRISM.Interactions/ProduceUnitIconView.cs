using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 FadeDuration                             float IL2CPP_TYPE_R4
    // 020 BackgroundButton                         0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 BackgroundImage                          0001866CCDB0 ModelClassType Image Image Image Pointer
    // 030 UiGradient                               0001866E9F60 ModelClassType UIGradient UIGradient UIGradient Pointer
    // 038 FesUnitIdolPositioning                   000186568DD0 ModelClassType FesUnitIdolPositioning FesUnitIdolPositioning FesUnitIdolPositioning Pointer
    // 040 FavoriteMarkImage                        000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 048 FavoriteMarkCanvasGroup                  000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 050 RankImage                                000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 058 RankFrameImage                           0001866CCDB0 ModelClassType Image Image Image Pointer
    // 060 RankEffectAnimator                       00018671A280 ModelClassType ParamRememberableAnimator ParamRememberableAnimator ParamRememberableAnimator Pointer
    // 068 InheritanceCanvasGroup                   000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 070 InheritanceCountText                     0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 GameObjectParameter                      0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 080 ParameterText                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 TextOutlineColor                         0001865D3210 ModelClassType ColorToOutlineForTextMeshProUGUI ColorToOutlineForTextMeshProUGUI ColorToOutlineForTextMeshProUGUI Pointer
    // 090 LabelFavoriteCanvasGroup                 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 098 FadeCanvasGroup                          000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 0A0 Gradients                                000185B82DC0 ModelClassListType Gradient[] Gradient[] List<Gradient> Pointer
    // 0A8 GrayOutController                        0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 0B0 CgSelectedCursor                         000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 0B8 Ct                                       00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 0C0 IsAwakeCompleted                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0C8 onClickSubject                           Subject`1<ValueTuple`2<int, GameObject>> IL2CPP_TYPE_GENERICINST
    // 0D0 onLongPressSubject                       Subject`1<ValueTuple`2<int, GameObject>> IL2CPP_TYPE_GENERICINST
    // 0D8 Index                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0DC OrderType                                00018668A7E0 ModelEnumType OrderType OrderType OrderType Int32
    // 0E0 UnitName                                 000186671910 ModelPrimitiveType string string string String
    // 0E8 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class ProduceUnitIconView : DataModel
    {
        public UIButton?                                BackgroundButton                        { get; set; }
        public Image?                                   BackgroundImage                         { get; set; }
        public UIGradient?                              UiGradient                              { get; set; }
        public FesUnitIdolPositioning?                  FesUnitIdolPositioning                  { get; set; }
        public RawImage?                                FavoriteMarkImage                       { get; set; }
        public CanvasGroup?                             FavoriteMarkCanvasGroup                 { get; set; }
        public RawImage?                                RankImage                               { get; set; }
        public Image?                                   RankFrameImage                          { get; set; }
        public ParamRememberableAnimator?               RankEffectAnimator                      { get; set; }
        public CanvasGroup?                             InheritanceCanvasGroup                  { get; set; }
        public UITextMeshProUGUI?                       InheritanceCountText                    { get; set; }
        public GameObject?                              GameObjectParameter                     { get; set; }
        public UITextMeshProUGUI?                       ParameterText                           { get; set; }
        public ColorToOutlineForTextMeshProUGUI?        TextOutlineColor                        { get; set; }
        public CanvasGroup?                             LabelFavoriteCanvasGroup                { get; set; }
        public CanvasGroup?                             FadeCanvasGroup                         { get; set; }
        public List<Gradient>?                          Gradients                               { get; set; }
        public UIGrayOutController?                     GrayOutController                       { get; set; }
        public CanvasGroup?                             CgSelectedCursor                        { get; set; }
        public CancellationToken                        Ct                                      { get; set; }
        public bool                                     IsAwakeCompleted                        { get; set; }
        public int                                      Index                                   { get; set; }
        public OrderType                                OrderType                               { get; set; }
        public string                                   UnitName                                { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static ProduceUnitIconView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceUnitIconView() { Pointer= p0 };

            value.BackgroundButton                          = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 02466A3F18D0 0x20 BackgroundButton            ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BackgroundImage                           = GetObject<Image>(new IntPtr(p + 0x028), ReversePrism.DataModels.Image.FromPointer); // 02466A3F18F0 0x28 BackgroundImage             ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.UiGradient                                = GetObject<UIGradient>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIGradient.FromPointer); // 02466A3F1910 0x30 UiGradient                  ( 0001866E9F60 ModelClassType UIGradient UIGradient UIGradient Pointer )
            value.FesUnitIdolPositioning                    = GetObject<FesUnitIdolPositioning>(new IntPtr(p + 0x038), ReversePrism.DataModels.FesUnitIdolPositioning.FromPointer); // 02466A3F1930 0x38 FesUnitIdolPositioning      ( 000186568DD0 ModelClassType FesUnitIdolPositioning FesUnitIdolPositioning FesUnitIdolPositioning Pointer )
            value.FavoriteMarkImage                         = GetObject<RawImage>(new IntPtr(p + 0x040), ReversePrism.DataModels.RawImage.FromPointer); // 02466A3F1950 0x40 FavoriteMarkImage           ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.FavoriteMarkCanvasGroup                   = GetObject<CanvasGroup>(new IntPtr(p + 0x048), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A3F1970 0x48 FavoriteMarkCanvasGroup     ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.RankImage                                 = GetObject<RawImage>(new IntPtr(p + 0x050), ReversePrism.DataModels.RawImage.FromPointer); // 02466A3F1990 0x50 RankImage                   ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.RankFrameImage                            = GetObject<Image>(new IntPtr(p + 0x058), ReversePrism.DataModels.Image.FromPointer); // 02466A3F19B0 0x58 RankFrameImage              ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.RankEffectAnimator                        = GetObject<ParamRememberableAnimator>(new IntPtr(p + 0x060), ReversePrism.DataModels.ParamRememberableAnimator.FromPointer); // 02466A3F19D0 0x60 RankEffectAnimator          ( 00018671A280 ModelClassType ParamRememberableAnimator ParamRememberableAnimator ParamRememberableAnimator Pointer )
            value.InheritanceCanvasGroup                    = GetObject<CanvasGroup>(new IntPtr(p + 0x068), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A3F19F0 0x68 InheritanceCanvasGroup      ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.InheritanceCountText                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A3F1A10 0x70 InheritanceCountText        ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GameObjectParameter                       = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 02466A3F1A30 0x78 GameObjectParameter         ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ParameterText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A3F1A50 0x80 ParameterText               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TextOutlineColor                          = GetObject<ColorToOutlineForTextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.ColorToOutlineForTextMeshProUGUI.FromPointer); // 02466A3F1A70 0x88 TextOutlineColor            ( 0001865D3210 ModelClassType ColorToOutlineForTextMeshProUGUI ColorToOutlineForTextMeshProUGUI ColorToOutlineForTextMeshProUGUI Pointer )
            value.LabelFavoriteCanvasGroup                  = GetObject<CanvasGroup>(new IntPtr(p + 0x090), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A3F1A90 0x90 LabelFavoriteCanvasGroup    ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.FadeCanvasGroup                           = GetObject<CanvasGroup>(new IntPtr(p + 0x098), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A3F1AB0 0x98 FadeCanvasGroup             ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.Gradients                                 = GetObjectList<Gradient>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Gradient.FromPointer); // 02466A3F1AD0 0xA0 Gradients                   ( 000185B82DC0 ModelClassListType Gradient[] Gradient[] List<Gradient> Pointer )
            value.GrayOutController                         = GetObject<UIGrayOutController>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 02466A3F1AF0 0xA8 GrayOutController           ( 0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.CgSelectedCursor                          = GetObject<CanvasGroup>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A3F1B10 0xB0 CgSelectedCursor            ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.Ct                                        = (CancellationToken)GetInt32(new IntPtr(p + 0x0B8)); // 02466A3F1B30 0xB8 Ct                          ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.IsAwakeCompleted                          = GetBool(new IntPtr(p + 0x0C0)); // 02466A3F1B50 0xC0 IsAwakeCompleted            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Index                                     = GetInt32(new IntPtr(p + 0x0D8)); // 02466A3F1BB0 0xD8 Index                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OrderType                                 = (OrderType)GetInt32(new IntPtr(p + 0x0DC)); // 02466A3F1BD0 0xDC OrderType                   ( 00018668A7E0 ModelEnumType OrderType OrderType OrderType Int32 )
            value.UnitName                                  = GetString(new IntPtr(p + 0x0E0)); // 02466A3F1BF0 0xE0 UnitName                    ( 000186671910 ModelPrimitiveType string string string String )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 02466A3F1C10 0xE8 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
