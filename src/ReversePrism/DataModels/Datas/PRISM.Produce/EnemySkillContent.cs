using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 078 EnemyIcon                                0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 080 SkillIcon                                00018669EBE0 ModelClassType TrainerSkillIconView TrainerSkillIconView TrainerSkillIconView Pointer
    // 088 SkillBalloonObject                       0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 090 SkillBalloonImage                        0001866920B0 ModelClassType Graphic Graphic Graphic Pointer
    // 098 SkillNameText                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A0 ShowSkillBalloonTime                     0001866656B0 ModelPrimitiveType float float float Single
    // 0A4 VoLessonColor                            0001865AA8E0 ModelEnumType Color Color Color Int32
    // 0B4 DaLessonColor                            0001865AA8E0 ModelEnumType Color Color Color Int32
    // 0C4 ViLessonColor                            0001865AA8E0 ModelEnumType Color Color Color Int32
    // 0D4 OtherColor                               0001865AA8E0 ModelEnumType Color Color Color Int32
    // 0E8 Animator                                 0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 0F0 AnimationSpeed                           0001866656B0 ModelPrimitiveType float float float Single
    // 0F4 IsShowSkillBalloon                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0F8 TokenSource                              0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 100 WaitDurationTask                         0001865409D0 ModelClassType WaitDurationTask WaitDurationTask WaitDurationTask Pointer
    public partial class EnemySkillContent : DataModel
    {
        public UIRawImage?                              EnemyIcon                               { get; set; }
        public TrainerSkillIconView?                    SkillIcon                               { get; set; }
        public GameObject?                              SkillBalloonObject                      { get; set; }
        public Graphic?                                 SkillBalloonImage                       { get; set; }
        public UITextMeshProUGUI?                       SkillNameText                           { get; set; }
        public float                                    ShowSkillBalloonTime                    { get; set; }
        public Color                                    VoLessonColor                           { get; set; }
        public Color                                    DaLessonColor                           { get; set; }
        public Color                                    ViLessonColor                           { get; set; }
        public Color                                    OtherColor                              { get; set; }
        public Animator?                                Animator                                { get; set; }
        public float                                    AnimationSpeed                          { get; set; }
        public bool                                     IsShowSkillBalloon                      { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }
        public WaitDurationTask?                        WaitDurationTask                        { get; set; }

        public static EnemySkillContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnemySkillContent() { Pointer= p0 };

            value.EnemyIcon                                 = GetObject<UIRawImage>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIRawImage.FromPointer); // 024665B691B0 0x78 EnemyIcon                   ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.SkillIcon                                 = GetObject<TrainerSkillIconView>(new IntPtr(p + 0x080), ReversePrism.DataModels.TrainerSkillIconView.FromPointer); // 024665B691D0 0x80 SkillIcon                   ( 00018669EBE0 ModelClassType TrainerSkillIconView TrainerSkillIconView TrainerSkillIconView Pointer )
            value.SkillBalloonObject                        = GetObject<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 024665B691F0 0x88 SkillBalloonObject          ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SkillBalloonImage                         = GetObject<Graphic>(new IntPtr(p + 0x090), ReversePrism.DataModels.Graphic.FromPointer); // 024665B69210 0x90 SkillBalloonImage           ( 0001866920B0 ModelClassType Graphic Graphic Graphic Pointer )
            value.SkillNameText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x098), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665B69230 0x98 SkillNameText               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ShowSkillBalloonTime                      = GetSingle(new IntPtr(p + 0x0A0)); // 024665B69250 0xA0 ShowSkillBalloonTime        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.VoLessonColor                             = (Color)GetInt32(new IntPtr(p + 0x0A4)); // 024665B69270 0xA4 VoLessonColor               ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.DaLessonColor                             = (Color)GetInt32(new IntPtr(p + 0x0B4)); // 024665B69290 0xB4 DaLessonColor               ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.ViLessonColor                             = (Color)GetInt32(new IntPtr(p + 0x0C4)); // 024665B692B0 0xC4 ViLessonColor               ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.OtherColor                                = (Color)GetInt32(new IntPtr(p + 0x0D4)); // 024665B692D0 0xD4 OtherColor                  ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.Animator.FromPointer); // 024665B692F0 0xE8 Animator                    ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.AnimationSpeed                            = GetSingle(new IntPtr(p + 0x0F0)); // 024665B69310 0xF0 AnimationSpeed              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.IsShowSkillBalloon                        = GetBool(new IntPtr(p + 0x0F4)); // 024665B69330 0xF4 IsShowSkillBalloon          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 024665B69350 0xF8 TokenSource                 ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.WaitDurationTask                          = GetObject<WaitDurationTask>(new IntPtr(p + 0x100), ReversePrism.DataModels.WaitDurationTask.FromPointer); // 024665B69370 0x100 WaitDurationTask            ( 0001865409D0 ModelClassType WaitDurationTask WaitDurationTask WaitDurationTask Pointer )

            return value;
        }
    }
}
