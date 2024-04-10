using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Btn                                      0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 ImgBg                                    0001866CCDB0 ModelClassType Image Image Image Pointer
    // 030 UiGradient                               0001866E9F60 ModelClassType UIGradient UIGradient UIGradient Pointer
    // 038 FesUnitIdolPositioning                   000186568DD0 ModelClassType FesUnitIdolPositioning FesUnitIdolPositioning FesUnitIdolPositioning Pointer
    // 040 ImgFavoriteMark                          000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 048 CgFavoriteMark                           000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 050 ImgRank                                  000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 058 ImgRankFrame                             0001866CCDB0 ModelClassType Image Image Image Pointer
    // 060 RankEffectAnimator                       00018671A280 ModelClassType ParamRememberableAnimator ParamRememberableAnimator ParamRememberableAnimator Pointer
    // 068 CgInheritance                            000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 070 TxtInheritanceCount                      0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 GoParameter                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 080 TxtParameter                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 TxtOutlineColor                          0001865D3210 ModelClassType ColorToOutlineForTextMeshProUGUI ColorToOutlineForTextMeshProUGUI ColorToOutlineForTextMeshProUGUI Pointer
    // 090 CgStatusLabel                            000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 098 TxtStatusLabel                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A0 CgFade                                   000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 0A8 FadeDuration                             0001866656B0 ModelPrimitiveType float float float Single
    // 0B0 Gradients                                000185B82DC0 ModelClassListType Gradient[] Gradient[] List<Gradient> Pointer
    // 0B8 GrayOutController                        0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 0C0 CgSelectedCursor                         000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 0C8 Ct                                       00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 0D0 IsAwakeCompleted                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0D8 onClickSubject                           Subject`1<ValueTuple`2<int, GameObject>> IL2CPP_TYPE_GENERICINST
    // 0E0 onLongPressSubject                       Subject`1<ValueTuple`2<int, GameObject>> IL2CPP_TYPE_GENERICINST
    // 0E8 Index                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0EC OrderType                                00018668A7E0 ModelEnumType OrderType OrderType OrderType Int32
    // 0F0 UnitName                                 000186671910 ModelPrimitiveType string string string String
    // 0F8 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 100 StatusLabelList                          000185D0D798 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 108 NextStatusIndex                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 110 StatusLabelBlinkDisposable               0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 118 ReplaceStatusLabelDisposable             0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
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

            value.Btn                                       = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0245A5B23BC0 0x20 Btn                         ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ImgBg                                     = GetObject<Image>(new IntPtr(p + 0x028), ReversePrism.DataModels.Image.FromPointer); // 0245A5B23BE0 0x28 ImgBg                       ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.UiGradient                                = GetObject<UIGradient>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIGradient.FromPointer); // 0245A5B23C00 0x30 UiGradient                  ( 0001866E9F60 ModelClassType UIGradient UIGradient UIGradient Pointer )
            value.FesUnitIdolPositioning                    = GetObject<FesUnitIdolPositioning>(new IntPtr(p + 0x038), ReversePrism.DataModels.FesUnitIdolPositioning.FromPointer); // 0245A5B23C20 0x38 FesUnitIdolPositioning      ( 000186568DD0 ModelClassType FesUnitIdolPositioning FesUnitIdolPositioning FesUnitIdolPositioning Pointer )
            value.ImgFavoriteMark                           = GetObject<RawImage>(new IntPtr(p + 0x040), ReversePrism.DataModels.RawImage.FromPointer); // 0245A5B23C40 0x40 ImgFavoriteMark             ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.CgFavoriteMark                            = GetObject<CanvasGroup>(new IntPtr(p + 0x048), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0245A5B23C60 0x48 CgFavoriteMark              ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.ImgRank                                   = GetObject<RawImage>(new IntPtr(p + 0x050), ReversePrism.DataModels.RawImage.FromPointer); // 0245A5B23C80 0x50 ImgRank                     ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.ImgRankFrame                              = GetObject<Image>(new IntPtr(p + 0x058), ReversePrism.DataModels.Image.FromPointer); // 0245A5B23CA0 0x58 ImgRankFrame                ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.RankEffectAnimator                        = GetObject<ParamRememberableAnimator>(new IntPtr(p + 0x060), ReversePrism.DataModels.ParamRememberableAnimator.FromPointer); // 0245A5B23CC0 0x60 RankEffectAnimator          ( 00018671A280 ModelClassType ParamRememberableAnimator ParamRememberableAnimator ParamRememberableAnimator Pointer )
            value.CgInheritance                             = GetObject<CanvasGroup>(new IntPtr(p + 0x068), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0245A5B23CE0 0x68 CgInheritance               ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.TxtInheritanceCount                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0245A5B23D00 0x70 TxtInheritanceCount         ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoParameter                               = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0245A5B23D20 0x78 GoParameter                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TxtParameter                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0245A5B23D40 0x80 TxtParameter                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtOutlineColor                           = GetObject<ColorToOutlineForTextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.ColorToOutlineForTextMeshProUGUI.FromPointer); // 0245A5B23D60 0x88 TxtOutlineColor             ( 0001865D3210 ModelClassType ColorToOutlineForTextMeshProUGUI ColorToOutlineForTextMeshProUGUI ColorToOutlineForTextMeshProUGUI Pointer )
            value.CgStatusLabel                             = GetObject<CanvasGroup>(new IntPtr(p + 0x090), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0245A5B23D80 0x90 CgStatusLabel               ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.TxtStatusLabel                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x098), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0245A5B23DA0 0x98 TxtStatusLabel              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CgFade                                    = GetObject<CanvasGroup>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0245A5B23DC0 0xA0 CgFade                      ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.FadeDuration                              = GetSingle(new IntPtr(p + 0x0A8)); // 0245A5B23DE0 0xA8 FadeDuration                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Gradients                                 = GetObjectList<Gradient>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Gradient.FromPointer); // 0245A5B23E00 0xB0 Gradients                   ( 000185B82DC0 ModelClassListType Gradient[] Gradient[] List<Gradient> Pointer )
            value.GrayOutController                         = GetObject<UIGrayOutController>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0245A5B23E20 0xB8 GrayOutController           ( 0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.CgSelectedCursor                          = GetObject<CanvasGroup>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0245A5B23E40 0xC0 CgSelectedCursor            ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.Ct                                        = (CancellationToken)GetInt32(new IntPtr(p + 0x0C8)); // 0245A5B23E60 0xC8 Ct                          ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.IsAwakeCompleted                          = GetBool(new IntPtr(p + 0x0D0)); // 0245A5B23E80 0xD0 IsAwakeCompleted            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Index                                     = GetInt32(new IntPtr(p + 0x0E8)); // 0245A5B23EE0 0xE8 Index                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OrderType                                 = (OrderType)GetInt32(new IntPtr(p + 0x0EC)); // 0245A5B23F00 0xEC OrderType                   ( 00018668A7E0 ModelEnumType OrderType OrderType OrderType Int32 )
            value.UnitName                                  = GetString(new IntPtr(p + 0x0F0)); // 0245A5B23F20 0xF0 UnitName                    ( 000186671910 ModelPrimitiveType string string string String )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0245A5B23F40 0xF8 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.StatusLabelList                           = GetStringList(new IntPtr(p + 0x100)); // 0245A5B23F60 0x100 StatusLabelList             ( 000185D0D798 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.NextStatusIndex                           = GetInt32(new IntPtr(p + 0x108)); // 0245A5B23F80 0x108 NextStatusIndex             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.StatusLabelBlinkDisposable                = GetObject<IDisposable>(new IntPtr(p + 0x110), ReversePrism.DataModels.IDisposable.FromPointer); // 0245A5B23FA0 0x110 StatusLabelBlinkDisposable  ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.ReplaceStatusLabelDisposable              = GetObject<IDisposable>(new IntPtr(p + 0x118), ReversePrism.DataModels.IDisposable.FromPointer); // 0245A5B23FC0 0x118 ReplaceStatusLabelDisposable ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
