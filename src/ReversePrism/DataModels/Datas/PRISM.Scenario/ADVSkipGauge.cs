using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 Animator                                 0001866BBE80 ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer
    // 030 SkipTextImage                            0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 038 ChoiceSkipTextImage                      0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 040 FadeDuration                             0001866656B0 ModelPrimitiveType float float float Single
    // 044 FadeWaitMiliseconds                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 048 AnimatorHashLongTapped                   0001865F4260 ModelPrimitiveType int int int Int32
    // 050 FadeHandler                              00018667F930 ModelClassType FadeHandler FadeHandler FadeHandler Pointer
    // 058 onLongTap                                Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 060 IsBeginLongTap                           000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ADVSkipGauge
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public AnimatorWithEvent?                       Animator                                { get; set; }
        public UIImage?                                 SkipTextImage                           { get; set; }
        public UIImage?                                 ChoiceSkipTextImage                     { get; set; }
        public float                                    FadeDuration                            { get; set; }
        public int                                      FadeWaitMiliseconds                     { get; set; }
        public int                                      AnimatorHashLongTapped                  { get; set; }
        public FadeHandler?                             FadeHandler                             { get; set; }
        public bool                                     IsBeginLongTap                          { get; set; }

        public static ADVSkipGauge? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ADVSkipGauge();

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270D5DDDB78 0x20 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.Animator                                  = GetObject<AnimatorWithEvent>(new IntPtr(p + 0x028), ReversePrism.DataModels.AnimatorWithEvent.FromPointer); // 0270D5DDDB98 0x28 Animator                    ( 0001866BBE80 ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer )
            value.SkipTextImage                             = GetObject<UIImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIImage.FromPointer); // 0270D5DDDBB8 0x30 SkipTextImage               ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.ChoiceSkipTextImage                       = GetObject<UIImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIImage.FromPointer); // 0270D5DDDBD8 0x38 ChoiceSkipTextImage         ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.FadeDuration                              = GetSingle(new IntPtr(p + 0x040)); // 0270D5DDDBF8 0x40 FadeDuration                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.FadeWaitMiliseconds                       = GetInt32(new IntPtr(p + 0x044)); // 0270D5DDDC18 0x44 FadeWaitMiliseconds         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AnimatorHashLongTapped                    = GetInt32(new IntPtr(p + 0x048)); // 0270D5DDDC38 0x48 AnimatorHashLongTapped      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.FadeHandler                               = GetObject<FadeHandler>(new IntPtr(p + 0x050), ReversePrism.DataModels.FadeHandler.FromPointer); // 0270D5DDDC58 0x50 FadeHandler                 ( 00018667F930 ModelClassType FadeHandler FadeHandler FadeHandler Pointer )
            value.IsBeginLongTap                            = GetBool(new IntPtr(p + 0x060)); // 0270D5DDDC98 0x60 IsBeginLongTap              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
