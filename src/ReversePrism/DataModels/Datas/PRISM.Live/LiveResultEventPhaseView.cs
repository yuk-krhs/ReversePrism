using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 BackgroundImage                          ModelClassType Image Image Image Pointer
    // 068 CharacterArea                            ModelClassType Transform Transform Transform Pointer
    // 070 CharacterImage                           ModelClassType Image Image Image Pointer
    // 078 LogoImage                                ModelClassType Image Image Image Pointer
    // 080 LogoEffectImage                          ModelClassType Image Image Image Pointer
    // 088 MusicInfoView                            ModelClassType MusicBasicInfoView MusicBasicInfoView MusicBasicInfoView Pointer
    // 090 ScoreDetailPanel                         ModelClassType LiveEventScoreDetailPanel LiveEventScoreDetailPanel LiveEventScoreDetailPanel Pointer
    // 098 EventButton                              ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 0A0 NextStoryObjects                         ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 0A8 EventStoryTexts                          ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 0B0 EventStoryRemainPointTexts               ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 0B8 NextStoryAnimator                        ModelClassType Animator Animator Animator Pointer
    // 0C0 CompleteStoryAnimator                    ModelClassType Animator Animator Animator Pointer
    // 0C8 EventMaster                              ModelClassType MstEvent MstEvent MstEvent Pointer
    // 0D0 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 0D8 Model                                    ModelClassType LiveResultEventPhaseViewModel LiveResultEventPhaseViewModel LiveResultEventPhaseViewModel Pointer
    // 000 AnimatorParamKeyNext                     int IL2CPP_TYPE_I4
    // 004 AnimatorParamKeyComplete                 int IL2CPP_TYPE_I4
    public partial class LiveResultEventPhaseView : DataModel
    {
        public Image?                                   BackgroundImage                         { get; set; }
        public Transform?                               CharacterArea                           { get; set; }
        public Image?                                   CharacterImage                          { get; set; }
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
        public MstEvent?                                EventMaster                             { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }
        public LiveResultEventPhaseViewModel?           Model                                   { get; set; }

        public static LiveResultEventPhaseView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveResultEventPhaseView() { Pointer= p0 };

            value.BackgroundImage                           = GetObject<Image>(new IntPtr(p + 0x060), ReversePrism.DataModels.Image.FromPointer); // 0x60 BackgroundImage             ( ModelClassType Image Image Image Pointer )
            value.CharacterArea                             = GetObject<Transform>(new IntPtr(p + 0x068), ReversePrism.DataModels.Transform.FromPointer); // 0x68 CharacterArea               ( ModelClassType Transform Transform Transform Pointer )
            value.CharacterImage                            = GetObject<Image>(new IntPtr(p + 0x070), ReversePrism.DataModels.Image.FromPointer); // 0x70 CharacterImage              ( ModelClassType Image Image Image Pointer )
            value.LogoImage                                 = GetObject<Image>(new IntPtr(p + 0x078), ReversePrism.DataModels.Image.FromPointer); // 0x78 LogoImage                   ( ModelClassType Image Image Image Pointer )
            value.LogoEffectImage                           = GetObject<Image>(new IntPtr(p + 0x080), ReversePrism.DataModels.Image.FromPointer); // 0x80 LogoEffectImage             ( ModelClassType Image Image Image Pointer )
            value.MusicInfoView                             = GetObject<MusicBasicInfoView>(new IntPtr(p + 0x088), ReversePrism.DataModels.MusicBasicInfoView.FromPointer); // 0x88 MusicInfoView               ( ModelClassType MusicBasicInfoView MusicBasicInfoView MusicBasicInfoView Pointer )
            value.ScoreDetailPanel                          = GetObject<LiveEventScoreDetailPanel>(new IntPtr(p + 0x090), ReversePrism.DataModels.LiveEventScoreDetailPanel.FromPointer); // 0x90 ScoreDetailPanel            ( ModelClassType LiveEventScoreDetailPanel LiveEventScoreDetailPanel LiveEventScoreDetailPanel Pointer )
            value.EventButton                               = GetObject<ButtonBase>(new IntPtr(p + 0x098), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x98 EventButton                 ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.NextStoryObjects                          = GetObjectList<GameObject>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.GameObject.FromPointer); // 0xA0 NextStoryObjects            ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.EventStoryTexts                           = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xA8 EventStoryTexts             ( ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.EventStoryRemainPointTexts                = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xB0 EventStoryRemainPointTexts  ( ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.NextStoryAnimator                         = GetObject<Animator>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.Animator.FromPointer); // 0xB8 NextStoryAnimator           ( ModelClassType Animator Animator Animator Pointer )
            value.CompleteStoryAnimator                     = GetObject<Animator>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.Animator.FromPointer); // 0xC0 CompleteStoryAnimator       ( ModelClassType Animator Animator Animator Pointer )
            value.EventMaster                               = GetObject<MstEvent>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.MstEvent.FromPointer); // 0xC8 EventMaster                 ( ModelClassType MstEvent MstEvent MstEvent Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0xD0 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.Model                                     = GetObject<LiveResultEventPhaseViewModel>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.LiveResultEventPhaseViewModel.FromPointer); // 0xD8 Model                       ( ModelClassType LiveResultEventPhaseViewModel LiveResultEventPhaseViewModel LiveResultEventPhaseViewModel Pointer )

            return value;
        }
    }
}
