using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Btn                                      ModelClassType UIButton UIButton UIButton Pointer
    // 028 ImgBg                                    ModelClassType Image Image Image Pointer
    // 030 UiGradient                               ModelClassType UIGradient UIGradient UIGradient Pointer
    // 038 FesUnitIdolPositioning                   ModelClassType FesUnitIdolPositioning FesUnitIdolPositioning FesUnitIdolPositioning Pointer
    // 040 ImgFavoriteMark                          ModelClassType RawImage RawImage RawImage Pointer
    // 048 CgFavoriteMark                           ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 050 ImgRank                                  ModelClassType RawImage RawImage RawImage Pointer
    // 058 ImgRankFrame                             ModelClassType Image Image Image Pointer
    // 060 RankEffectAnimator                       ModelClassType ParamRememberableAnimator ParamRememberableAnimator ParamRememberableAnimator Pointer
    // 068 CgInheritance                            ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 070 TxtInheritanceCount                      ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 GoParameter                              ModelClassType GameObject GameObject GameObject Pointer
    // 080 TxtParameter                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 TxtOutlineColor                          ModelClassType ColorToOutlineForTextMeshProUGUI ColorToOutlineForTextMeshProUGUI ColorToOutlineForTextMeshProUGUI Pointer
    // 090 CgStatusLabel                            ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 098 TxtStatusLabel                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A0 CgFade                                   ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 0A8 FadeDuration                             ModelPrimitiveType float float float Single
    // 0B0 Gradients                                ModelClassListType Gradient[] Gradient[] List<Gradient> Pointer
    // 0B8 GrayOutController                        ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 0C0 CgSelectedCursor                         ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 0C8 Ct                                       ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 0D0 IsAwakeCompleted                         ModelPrimitiveType bool bool bool Bool
    // 0D8 onClickSubject                           Subject`1<ValueTuple`2<int, GameObject>> IL2CPP_TYPE_GENERICINST
    // 0E0 onLongPressSubject                       Subject`1<ValueTuple`2<int, GameObject>> IL2CPP_TYPE_GENERICINST
    // 0E8 Index                                    ModelPrimitiveType int int int Int32
    // 0EC OrderType                                ModelEnumType OrderType OrderType OrderType Int32
    // 0F0 UnitName                                 ModelPrimitiveType string string string String
    // 0F8 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 100 StatusLabelList                          ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 108 NextStatusIndex                          ModelPrimitiveType int int int Int32
    // 110 StatusLabelBlinkDisposable               ModelClassType IDisposable IDisposable IDisposable Pointer
    // 118 ReplaceStatusLabelDisposable             ModelClassType IDisposable IDisposable IDisposable Pointer
    // 120 replaceLabelSubject                      Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class FUnitIconView : DataModel
    {
        public UIButton?                                Btn                                     { get; set; }
        public Image?                                   ImgBg                                   { get; set; }
        public UIGradient?                              UiGradient                              { get; set; }
        public FesUnitIdolPositioning?                  FesUnitIdolPositioning                  { get; set; }
        public RawImage?                                ImgFavoriteMark                         { get; set; }
        public CanvasGroup?                             CgFavoriteMark                          { get; set; }
        public RawImage?                                ImgRank                                 { get; set; }
        public Image?                                   ImgRankFrame                            { get; set; }
        public ParamRememberableAnimator?               RankEffectAnimator                      { get; set; }
        public CanvasGroup?                             CgInheritance                           { get; set; }
        public UITextMeshProUGUI?                       TxtInheritanceCount                     { get; set; }
        public GameObject?                              GoParameter                             { get; set; }
        public UITextMeshProUGUI?                       TxtParameter                            { get; set; }
        public ColorToOutlineForTextMeshProUGUI?        TxtOutlineColor                         { get; set; }
        public CanvasGroup?                             CgStatusLabel                           { get; set; }
        public UITextMeshProUGUI?                       TxtStatusLabel                          { get; set; }
        public CanvasGroup?                             CgFade                                  { get; set; }
        public float                                    FadeDuration                            { get; set; }
        public List<Gradient>?                          Gradients                               { get; set; }
        public UIGrayOutController?                     GrayOutController                       { get; set; }
        public CanvasGroup?                             CgSelectedCursor                        { get; set; }
        public CancellationToken                        Ct                                      { get; set; }
        public bool                                     IsAwakeCompleted                        { get; set; }
        public int                                      Index                                   { get; set; }
        public OrderType                                OrderType                               { get; set; }
        public string                                   UnitName                                { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public List<string>?                            StatusLabelList                         { get; set; }
        public int                                      NextStatusIndex                         { get; set; }
        public IDisposable?                             StatusLabelBlinkDisposable              { get; set; }
        public IDisposable?                             ReplaceStatusLabelDisposable            { get; set; }

        public static FUnitIconView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FUnitIconView() { Pointer= p0 };

            value.Btn                                       = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0x20 Btn                         ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ImgBg                                     = GetObject<Image>(new IntPtr(p + 0x028), ReversePrism.DataModels.Image.FromPointer); // 0x28 ImgBg                       ( ModelClassType Image Image Image Pointer )
            value.UiGradient                                = GetObject<UIGradient>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIGradient.FromPointer); // 0x30 UiGradient                  ( ModelClassType UIGradient UIGradient UIGradient Pointer )
            value.FesUnitIdolPositioning                    = GetObject<FesUnitIdolPositioning>(new IntPtr(p + 0x038), ReversePrism.DataModels.FesUnitIdolPositioning.FromPointer); // 0x38 FesUnitIdolPositioning      ( ModelClassType FesUnitIdolPositioning FesUnitIdolPositioning FesUnitIdolPositioning Pointer )
            value.ImgFavoriteMark                           = GetObject<RawImage>(new IntPtr(p + 0x040), ReversePrism.DataModels.RawImage.FromPointer); // 0x40 ImgFavoriteMark             ( ModelClassType RawImage RawImage RawImage Pointer )
            value.CgFavoriteMark                            = GetObject<CanvasGroup>(new IntPtr(p + 0x048), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x48 CgFavoriteMark              ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.ImgRank                                   = GetObject<RawImage>(new IntPtr(p + 0x050), ReversePrism.DataModels.RawImage.FromPointer); // 0x50 ImgRank                     ( ModelClassType RawImage RawImage RawImage Pointer )
            value.ImgRankFrame                              = GetObject<Image>(new IntPtr(p + 0x058), ReversePrism.DataModels.Image.FromPointer); // 0x58 ImgRankFrame                ( ModelClassType Image Image Image Pointer )
            value.RankEffectAnimator                        = GetObject<ParamRememberableAnimator>(new IntPtr(p + 0x060), ReversePrism.DataModels.ParamRememberableAnimator.FromPointer); // 0x60 RankEffectAnimator          ( ModelClassType ParamRememberableAnimator ParamRememberableAnimator ParamRememberableAnimator Pointer )
            value.CgInheritance                             = GetObject<CanvasGroup>(new IntPtr(p + 0x068), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x68 CgInheritance               ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.TxtInheritanceCount                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x70 TxtInheritanceCount         ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoParameter                               = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0x78 GoParameter                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TxtParameter                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x80 TxtParameter                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtOutlineColor                           = GetObject<ColorToOutlineForTextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.ColorToOutlineForTextMeshProUGUI.FromPointer); // 0x88 TxtOutlineColor             ( ModelClassType ColorToOutlineForTextMeshProUGUI ColorToOutlineForTextMeshProUGUI ColorToOutlineForTextMeshProUGUI Pointer )
            value.CgStatusLabel                             = GetObject<CanvasGroup>(new IntPtr(p + 0x090), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x90 CgStatusLabel               ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.TxtStatusLabel                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x098), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x98 TxtStatusLabel              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CgFade                                    = GetObject<CanvasGroup>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0xA0 CgFade                      ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.FadeDuration                              = GetSingle(new IntPtr(p + 0x0A8)); // 0xA8 FadeDuration                ( ModelPrimitiveType float float float Single )
            value.Gradients                                 = GetObjectList<Gradient>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Gradient.FromPointer); // 0xB0 Gradients                   ( ModelClassListType Gradient[] Gradient[] List<Gradient> Pointer )
            value.GrayOutController                         = GetObject<UIGrayOutController>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0xB8 GrayOutController           ( ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.CgSelectedCursor                          = GetObject<CanvasGroup>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0xC0 CgSelectedCursor            ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.Ct                                        = (CancellationToken)GetInt32(new IntPtr(p + 0x0C8)); // 0xC8 Ct                          ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.IsAwakeCompleted                          = GetBool(new IntPtr(p + 0x0D0)); // 0xD0 IsAwakeCompleted            ( ModelPrimitiveType bool bool bool Bool )
            value.Index                                     = GetInt32(new IntPtr(p + 0x0E8)); // 0xE8 Index                       ( ModelPrimitiveType int int int Int32 )
            value.OrderType                                 = (OrderType)GetInt32(new IntPtr(p + 0x0EC)); // 0xEC OrderType                   ( ModelEnumType OrderType OrderType OrderType Int32 )
            value.UnitName                                  = GetString(new IntPtr(p + 0x0F0)); // 0xF0 UnitName                    ( ModelPrimitiveType string string string String )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0xF8 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.StatusLabelList                           = GetStringList(new IntPtr(p + 0x100)); // 0x100 StatusLabelList             ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.NextStatusIndex                           = GetInt32(new IntPtr(p + 0x108)); // 0x108 NextStatusIndex             ( ModelPrimitiveType int int int Int32 )
            value.StatusLabelBlinkDisposable                = GetObject<IDisposable>(new IntPtr(p + 0x110), ReversePrism.DataModels.IDisposable.FromPointer); // 0x110 StatusLabelBlinkDisposable  ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.ReplaceStatusLabelDisposable              = GetObject<IDisposable>(new IntPtr(p + 0x118), ReversePrism.DataModels.IDisposable.FromPointer); // 0x118 ReplaceStatusLabelDisposable ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
