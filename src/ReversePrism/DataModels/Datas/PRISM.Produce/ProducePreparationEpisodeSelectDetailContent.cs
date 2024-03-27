using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Title                                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 SynopsisText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 Thumbnail                                0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 038 VoAttributeIcon                          000186567D60 ModelClassType ProducePreparationEpisodeSelectAttributeIcon ProducePreparationEpisodeSelectAttributeIcon ProducePreparationEpisodeSelectAttributeIcon Pointer
    // 040 DaAttributeIcon                          000186567D60 ModelClassType ProducePreparationEpisodeSelectAttributeIcon ProducePreparationEpisodeSelectAttributeIcon ProducePreparationEpisodeSelectAttributeIcon Pointer
    // 048 ViAttributeIcon                          000186567D60 ModelClassType ProducePreparationEpisodeSelectAttributeIcon ProducePreparationEpisodeSelectAttributeIcon ProducePreparationEpisodeSelectAttributeIcon Pointer
    // 050 DifficultyButtons                        000185B9CB30 ModelClassListType ProduceEpisodeEpisodeSelectDifficultyButton[] ProduceEpisodeEpisodeSelectDifficultyButton[] List<ProduceEpisodeEpisodeSelectDifficultyButton> Pointer
    // 058 FadeCanvasGroup                          000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 060 FadeCurve                                000186586CC0 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 068 FadeTimeDisposable                       0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class ProducePreparationEpisodeSelectDetailContent
    {
        public UITextMeshProUGUI?                       Title                                   { get; set; }
        public UITextMeshProUGUI?                       SynopsisText                            { get; set; }
        public UIImage?                                 Thumbnail                               { get; set; }
        public ProducePreparationEpisodeSelectAttributeIcon? VoAttributeIcon                         { get; set; }
        public ProducePreparationEpisodeSelectAttributeIcon? DaAttributeIcon                         { get; set; }
        public ProducePreparationEpisodeSelectAttributeIcon? ViAttributeIcon                         { get; set; }
        public List<ProduceEpisodeEpisodeSelectDifficultyButton>? DifficultyButtons                       { get; set; }
        public CanvasGroup?                             FadeCanvasGroup                         { get; set; }
        public AnimationCurve?                          FadeCurve                               { get; set; }
        public IDisposable?                             FadeTimeDisposable                      { get; set; }

        public static ProducePreparationEpisodeSelectDetailContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProducePreparationEpisodeSelectDetailContent();

            value.Title                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D59DD1F8 0x20 Title                       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SynopsisText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D59DD218 0x28 SynopsisText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Thumbnail                                 = GetObject<UIImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIImage.FromPointer); // 0270D59DD238 0x30 Thumbnail                   ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.VoAttributeIcon                           = GetObject<ProducePreparationEpisodeSelectAttributeIcon>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProducePreparationEpisodeSelectAttributeIcon.FromPointer); // 0270D59DD258 0x38 VoAttributeIcon             ( 000186567D60 ModelClassType ProducePreparationEpisodeSelectAttributeIcon ProducePreparationEpisodeSelectAttributeIcon ProducePreparationEpisodeSelectAttributeIcon Pointer )
            value.DaAttributeIcon                           = GetObject<ProducePreparationEpisodeSelectAttributeIcon>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProducePreparationEpisodeSelectAttributeIcon.FromPointer); // 0270D59DD278 0x40 DaAttributeIcon             ( 000186567D60 ModelClassType ProducePreparationEpisodeSelectAttributeIcon ProducePreparationEpisodeSelectAttributeIcon ProducePreparationEpisodeSelectAttributeIcon Pointer )
            value.ViAttributeIcon                           = GetObject<ProducePreparationEpisodeSelectAttributeIcon>(new IntPtr(p + 0x048), ReversePrism.DataModels.ProducePreparationEpisodeSelectAttributeIcon.FromPointer); // 0270D59DD298 0x48 ViAttributeIcon             ( 000186567D60 ModelClassType ProducePreparationEpisodeSelectAttributeIcon ProducePreparationEpisodeSelectAttributeIcon ProducePreparationEpisodeSelectAttributeIcon Pointer )
            value.DifficultyButtons                         = GetObjectList<ProduceEpisodeEpisodeSelectDifficultyButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.ProduceEpisodeEpisodeSelectDifficultyButton.FromPointer); // 0270D59DD2B8 0x50 DifficultyButtons           ( 000185B9CB30 ModelClassListType ProduceEpisodeEpisodeSelectDifficultyButton[] ProduceEpisodeEpisodeSelectDifficultyButton[] List<ProduceEpisodeEpisodeSelectDifficultyButton> Pointer )
            value.FadeCanvasGroup                           = GetObject<CanvasGroup>(new IntPtr(p + 0x058), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270D59DD2D8 0x58 FadeCanvasGroup             ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.FadeCurve                                 = GetObject<AnimationCurve>(new IntPtr(p + 0x060), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0270D59DD2F8 0x60 FadeCurve                   ( 000186586CC0 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.FadeTimeDisposable                        = GetObject<IDisposable>(new IntPtr(p + 0x068), ReversePrism.DataModels.IDisposable.FromPointer); // 0270D59DD318 0x68 FadeTimeDisposable          ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
