using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 BackgroundImage                          0001866CCDB0 ModelClassType Image Image Image Pointer
    // 060 CharacterArea                            0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 068 LogoImage                                0001866CCDB0 ModelClassType Image Image Image Pointer
    // 070 LogoEffectImage                          0001866CCDB0 ModelClassType Image Image Image Pointer
    // 078 MusicInfoView                            0001866630C0 ModelClassType MusicBasicInfoView MusicBasicInfoView MusicBasicInfoView Pointer
    // 080 ScoreDetailPanel                         0001865543E0 ModelClassType LiveEventScoreDetailPanel LiveEventScoreDetailPanel LiveEventScoreDetailPanel Pointer
    // 088 EventButton                              000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 090 NextStoryObjects                         000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 098 EventStoryTexts                          000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 0A0 EventStoryRemainPointTexts               000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 0A8 NextStoryAnimator                        0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 0B0 CompleteStoryAnimator                    0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 0B8 EventId                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0C0 ResourceTag                              000186671910 ModelPrimitiveType string string string String
    // 0C8 Model                                    00018656E750 ModelClassType LiveResultEventPhaseViewModel LiveResultEventPhaseViewModel LiveResultEventPhaseViewModel Pointer
    // 000 AnimatorParamKeyNext                     int IL2CPP_TYPE_I4
    // 004 AnimatorParamKeyComplete                 int IL2CPP_TYPE_I4
    public partial class LiveResultEventPhaseView
    {
        public Image?                                   BackgroundImage                         { get; set; }
        public Transform?                               CharacterArea                           { get; set; }
        public Image?                                   LogoImage                               { get; set; }
        public Image?                                   LogoEffectImage                         { get; set; }
        public MusicBasicInfoView?                      MusicInfoView                           { get; set; }
        public LiveEventScoreDetailPanel?               ScoreDetailPanel                        { get; set; }
        public ButtonBase?                              EventButton                             { get; set; }
        public List<GameObject>?                        NextStoryObjects                        { get; set; }
        public List<UITextMeshProUGUI>?                 EventStoryTexts                         { get; set; }
        public List<UITextMeshProUGUI>?                 EventStoryRemainPointTexts              { get; set; }
        public Animator?                                NextStoryAnimator                       { get; set; }
        public Animator?                                CompleteStoryAnimator                   { get; set; }
        public int                                      EventId                                 { get; set; }
        public string                                   ResourceTag                             { get; set; }
        public LiveResultEventPhaseViewModel?           Model                                   { get; set; }

        public static LiveResultEventPhaseView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveResultEventPhaseView();

            value.BackgroundImage                           = GetObject<Image>(new IntPtr(p + 0x058), ReversePrism.DataModels.Image.FromPointer); // 0270D5237198 0x58 BackgroundImage             ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.CharacterArea                             = GetObject<Transform>(new IntPtr(p + 0x060), ReversePrism.DataModels.Transform.FromPointer); // 0270D52371B8 0x60 CharacterArea               ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.LogoImage                                 = GetObject<Image>(new IntPtr(p + 0x068), ReversePrism.DataModels.Image.FromPointer); // 0270D52371D8 0x68 LogoImage                   ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.LogoEffectImage                           = GetObject<Image>(new IntPtr(p + 0x070), ReversePrism.DataModels.Image.FromPointer); // 0270D52371F8 0x70 LogoEffectImage             ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.MusicInfoView                             = GetObject<MusicBasicInfoView>(new IntPtr(p + 0x078), ReversePrism.DataModels.MusicBasicInfoView.FromPointer); // 0270D5237218 0x78 MusicInfoView               ( 0001866630C0 ModelClassType MusicBasicInfoView MusicBasicInfoView MusicBasicInfoView Pointer )
            value.ScoreDetailPanel                          = GetObject<LiveEventScoreDetailPanel>(new IntPtr(p + 0x080), ReversePrism.DataModels.LiveEventScoreDetailPanel.FromPointer); // 0270D5237238 0x80 ScoreDetailPanel            ( 0001865543E0 ModelClassType LiveEventScoreDetailPanel LiveEventScoreDetailPanel LiveEventScoreDetailPanel Pointer )
            value.EventButton                               = GetObject<ButtonBase>(new IntPtr(p + 0x088), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270D5237258 0x88 EventButton                 ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.NextStoryObjects                          = GetObjectList<GameObject>(new IntPtr(p + 0x090), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5237278 0x90 NextStoryObjects            ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.EventStoryTexts                           = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x098), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5237298 0x98 EventStoryTexts             ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.EventStoryRemainPointTexts                = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D52372B8 0xA0 EventStoryRemainPointTexts  ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.NextStoryAnimator                         = GetObject<Animator>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Animator.FromPointer); // 0270D52372D8 0xA8 NextStoryAnimator           ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.CompleteStoryAnimator                     = GetObject<Animator>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Animator.FromPointer); // 0270D52372F8 0xB0 CompleteStoryAnimator       ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.EventId                                   = GetInt32(new IntPtr(p + 0x0B8)); // 0270D5237318 0xB8 EventId                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ResourceTag                               = GetString(new IntPtr(p + 0x0C0)); // 0270D5237338 0xC0 ResourceTag                 ( 000186671910 ModelPrimitiveType string string string String )
            value.Model                                     = GetObject<LiveResultEventPhaseViewModel>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.LiveResultEventPhaseViewModel.FromPointer); // 0270D5237358 0xC8 Model                       ( 00018656E750 ModelClassType LiveResultEventPhaseViewModel LiveResultEventPhaseViewModel LiveResultEventPhaseViewModel Pointer )

            return value;
        }
    }
}
