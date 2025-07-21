using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 078 EnemyIcon                                ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 080 SkillIcon                                ModelClassType TrainerSkillIconView TrainerSkillIconView TrainerSkillIconView Pointer
    // 088 SkillBalloonObject                       ModelClassType GameObject GameObject GameObject Pointer
    // 090 SkillBalloonImage                        ModelClassType Graphic Graphic Graphic Pointer
    // 098 SkillNameText                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A0 ShowSkillBalloonTime                     ModelPrimitiveType float float float Single
    // 0A4 VoLessonColor                            ModelEnumType Color Color Color Int32
    // 0B4 DaLessonColor                            ModelEnumType Color Color Color Int32
    // 0C4 ViLessonColor                            ModelEnumType Color Color Color Int32
    // 0D4 OtherColor                               ModelEnumType Color Color Color Int32
    // 0E8 Animator                                 ModelClassType Animator Animator Animator Pointer
    // 0F0 IsShowSkillBalloon                       ModelPrimitiveType bool bool bool Bool
    // 0F8 TokenSource                              ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 100 WaitDurationTask                         ModelClassType WaitDurationTask WaitDurationTask WaitDurationTask Pointer
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
        public bool                                     IsShowSkillBalloon                      { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }
        public WaitDurationTask?                        WaitDurationTask                        { get; set; }

        public static EnemySkillContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnemySkillContent() { Pointer= p0 };

            value.EnemyIcon                                 = GetObject<UIRawImage>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x78 EnemyIcon                   ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.SkillIcon                                 = GetObject<TrainerSkillIconView>(new IntPtr(p + 0x080), ReversePrism.DataModels.TrainerSkillIconView.FromPointer); // 0x80 SkillIcon                   ( ModelClassType TrainerSkillIconView TrainerSkillIconView TrainerSkillIconView Pointer )
            value.SkillBalloonObject                        = GetObject<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 0x88 SkillBalloonObject          ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SkillBalloonImage                         = GetObject<Graphic>(new IntPtr(p + 0x090), ReversePrism.DataModels.Graphic.FromPointer); // 0x90 SkillBalloonImage           ( ModelClassType Graphic Graphic Graphic Pointer )
            value.SkillNameText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x098), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x98 SkillNameText               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ShowSkillBalloonTime                      = GetSingle(new IntPtr(p + 0x0A0)); // 0xA0 ShowSkillBalloonTime        ( ModelPrimitiveType float float float Single )
            value.VoLessonColor                             = (Color)GetInt32(new IntPtr(p + 0x0A4)); // 0xA4 VoLessonColor               ( ModelEnumType Color Color Color Int32 )
            value.DaLessonColor                             = (Color)GetInt32(new IntPtr(p + 0x0B4)); // 0xB4 DaLessonColor               ( ModelEnumType Color Color Color Int32 )
            value.ViLessonColor                             = (Color)GetInt32(new IntPtr(p + 0x0C4)); // 0xC4 ViLessonColor               ( ModelEnumType Color Color Color Int32 )
            value.OtherColor                                = (Color)GetInt32(new IntPtr(p + 0x0D4)); // 0xD4 OtherColor                  ( ModelEnumType Color Color Color Int32 )
            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.Animator.FromPointer); // 0xE8 Animator                    ( ModelClassType Animator Animator Animator Pointer )
            value.IsShowSkillBalloon                        = GetBool(new IntPtr(p + 0x0F0)); // 0xF0 IsShowSkillBalloon          ( ModelPrimitiveType bool bool bool Bool )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0xF8 TokenSource                 ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.WaitDurationTask                          = GetObject<WaitDurationTask>(new IntPtr(p + 0x100), ReversePrism.DataModels.WaitDurationTask.FromPointer); // 0x100 WaitDurationTask            ( ModelClassType WaitDurationTask WaitDurationTask WaitDurationTask Pointer )

            return value;
        }
    }
}
