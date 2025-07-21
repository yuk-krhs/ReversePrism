using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 Animator                                 ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer
    // 030 SkipTextImage                            ModelClassType UIImage UIImage UIImage Pointer
    // 038 ChoiceSkipTextImage                      ModelClassType UIImage UIImage UIImage Pointer
    // 040 FadeDurationSeconds                      ModelPrimitiveType float float float Single
    // 044 FadeStartSeconds                         ModelPrimitiveType float float float Single
    // 048 AnimatorHashLongTapped                   ModelPrimitiveType int int int Int32
    // 050 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 058 FadeHandler                              ModelClassType FadeHandler FadeHandler FadeHandler Pointer
    // 060 onLongTap                                Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 068 IsLongTapEnabled                         ModelPrimitiveType bool bool bool Bool
    public partial class AdvSkipGaugeView : DataModel
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public AnimatorWithEvent?                       Animator                                { get; set; }
        public UIImage?                                 SkipTextImage                           { get; set; }
        public UIImage?                                 ChoiceSkipTextImage                     { get; set; }
        public float                                    FadeDurationSeconds                     { get; set; }
        public float                                    FadeStartSeconds                        { get; set; }
        public int                                      AnimatorHashLongTapped                  { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public FadeHandler?                             FadeHandler                             { get; set; }
        public bool                                     IsLongTapEnabled                        { get; set; }

        public static AdvSkipGaugeView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdvSkipGaugeView() { Pointer= p0 };

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x20 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.Animator                                  = GetObject<AnimatorWithEvent>(new IntPtr(p + 0x028), ReversePrism.DataModels.AnimatorWithEvent.FromPointer); // 0x28 Animator                    ( ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer )
            value.SkipTextImage                             = GetObject<UIImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIImage.FromPointer); // 0x30 SkipTextImage               ( ModelClassType UIImage UIImage UIImage Pointer )
            value.ChoiceSkipTextImage                       = GetObject<UIImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIImage.FromPointer); // 0x38 ChoiceSkipTextImage         ( ModelClassType UIImage UIImage UIImage Pointer )
            value.FadeDurationSeconds                       = GetSingle(new IntPtr(p + 0x040)); // 0x40 FadeDurationSeconds         ( ModelPrimitiveType float float float Single )
            value.FadeStartSeconds                          = GetSingle(new IntPtr(p + 0x044)); // 0x44 FadeStartSeconds            ( ModelPrimitiveType float float float Single )
            value.AnimatorHashLongTapped                    = GetInt32(new IntPtr(p + 0x048)); // 0x48 AnimatorHashLongTapped      ( ModelPrimitiveType int int int Int32 )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x050), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x50 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.FadeHandler                               = GetObject<FadeHandler>(new IntPtr(p + 0x058), ReversePrism.DataModels.FadeHandler.FromPointer); // 0x58 FadeHandler                 ( ModelClassType FadeHandler FadeHandler FadeHandler Pointer )
            value.IsLongTapEnabled                          = GetBool(new IntPtr(p + 0x068)); // 0x68 IsLongTapEnabled            ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
