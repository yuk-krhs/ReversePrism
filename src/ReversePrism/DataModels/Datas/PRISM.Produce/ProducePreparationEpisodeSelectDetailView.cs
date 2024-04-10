using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Content                                  000186569B70 ModelClassType ProducePreparationEpisodeSelectDetailContent ProducePreparationEpisodeSelectDetailContent ProducePreparationEpisodeSelectDetailContent Pointer
    // 028 NextButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 030 PrevButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 038 DecideButton                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 CancelButton                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 048 DeckButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 050 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 058 TouchBlockObject                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 060 SelectedThumbnail                        0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 068 Animator                                 0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 070 PopupPrefab                              00018675FC50 ModelClassType PopupBase PopupBase PopupBase Pointer
    // 078 AnimeDissapoble                          0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 080 BackKeyDisposable                        0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 088 Popup                                    00018675FC50 ModelClassType PopupBase PopupBase PopupBase Pointer
    // 090 PrevParent                               0001866AA150 ModelClassType Transform Transform Transform Pointer
    public partial class ProducePreparationEpisodeSelectDetailView : DataModel
    {
        public ProducePreparationEpisodeSelectDetailContent? Content                                 { get; set; }
        public UIButton?                                NextButton                              { get; set; }
        public UIButton?                                PrevButton                              { get; set; }
        public UIButton?                                DecideButton                            { get; set; }
        public UIButton?                                CancelButton                            { get; set; }
        public UIButton?                                DeckButton                              { get; set; }
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public GameObject?                              TouchBlockObject                        { get; set; }
        public UIImage?                                 SelectedThumbnail                       { get; set; }
        public Animator?                                Animator                                { get; set; }
        public PopupBase?                               PopupPrefab                             { get; set; }
        public IDisposable?                             AnimeDissapoble                         { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }
        public PopupBase?                               Popup                                   { get; set; }
        public Transform?                               PrevParent                              { get; set; }

        public static ProducePreparationEpisodeSelectDetailView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProducePreparationEpisodeSelectDetailView() { Pointer= p0 };

            value.Content                                   = GetObject<ProducePreparationEpisodeSelectDetailContent>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProducePreparationEpisodeSelectDetailContent.FromPointer); // 024665A3F010 0x20 Content                     ( 000186569B70 ModelClassType ProducePreparationEpisodeSelectDetailContent ProducePreparationEpisodeSelectDetailContent ProducePreparationEpisodeSelectDetailContent Pointer )
            value.NextButton                                = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 024665A3F030 0x28 NextButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.PrevButton                                = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 024665A3F050 0x30 PrevButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.DecideButton                              = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 024665A3F070 0x38 DecideButton                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.CancelButton                              = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 024665A3F090 0x40 CancelButton                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.DeckButton                                = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 024665A3F0B0 0x48 DeckButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x050), ReversePrism.DataModels.CanvasGroup.FromPointer); // 024665A3F0D0 0x50 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.TouchBlockObject                          = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 024665A3F0F0 0x58 TouchBlockObject            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SelectedThumbnail                         = GetObject<UIImage>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIImage.FromPointer); // 024665A3F110 0x60 SelectedThumbnail           ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x068), ReversePrism.DataModels.Animator.FromPointer); // 024665A3F130 0x68 Animator                    ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.PopupPrefab                               = GetObject<PopupBase>(new IntPtr(p + 0x070), ReversePrism.DataModels.PopupBase.FromPointer); // 024665A3F150 0x70 PopupPrefab                 ( 00018675FC50 ModelClassType PopupBase PopupBase PopupBase Pointer )
            value.AnimeDissapoble                           = GetObject<IDisposable>(new IntPtr(p + 0x078), ReversePrism.DataModels.IDisposable.FromPointer); // 024665A3F170 0x78 AnimeDissapoble             ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x080), ReversePrism.DataModels.IDisposable.FromPointer); // 024665A3F190 0x80 BackKeyDisposable           ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.Popup                                     = GetObject<PopupBase>(new IntPtr(p + 0x088), ReversePrism.DataModels.PopupBase.FromPointer); // 024665A3F1B0 0x88 Popup                       ( 00018675FC50 ModelClassType PopupBase PopupBase PopupBase Pointer )
            value.PrevParent                                = GetObject<Transform>(new IntPtr(p + 0x090), ReversePrism.DataModels.Transform.FromPointer); // 024665A3F1D0 0x90 PrevParent                  ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
