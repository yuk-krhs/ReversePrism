using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Content                                  ModelClassType ProducePreparationEpisodeSelectDetailContent ProducePreparationEpisodeSelectDetailContent ProducePreparationEpisodeSelectDetailContent Pointer
    // 028 NextButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 030 PrevButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 038 DecideButton                             ModelClassType UIButton UIButton UIButton Pointer
    // 040 CancelButton                             ModelClassType UIButton UIButton UIButton Pointer
    // 048 DeckButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 050 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 058 TouchBlockObject                         ModelClassType GameObject GameObject GameObject Pointer
    // 060 SelectedThumbnail                        ModelClassType UIImage UIImage UIImage Pointer
    // 068 Animator                                 ModelClassType Animator Animator Animator Pointer
    // 070 PopupPrefab                              ModelClassType PopupBase PopupBase PopupBase Pointer
    // 078 AnimeDissapoble                          ModelClassType IDisposable IDisposable IDisposable Pointer
    // 080 BackKeyDisposable                        ModelClassType IDisposable IDisposable IDisposable Pointer
    // 088 Popup                                    ModelClassType PopupBase PopupBase PopupBase Pointer
    // 090 PrevParent                               ModelClassType Transform Transform Transform Pointer
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

            value.Content                                   = GetObject<ProducePreparationEpisodeSelectDetailContent>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProducePreparationEpisodeSelectDetailContent.FromPointer); // 0x20 Content                     ( ModelClassType ProducePreparationEpisodeSelectDetailContent ProducePreparationEpisodeSelectDetailContent ProducePreparationEpisodeSelectDetailContent Pointer )
            value.NextButton                                = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0x28 NextButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.PrevButton                                = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0x30 PrevButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.DecideButton                              = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 DecideButton                ( ModelClassType UIButton UIButton UIButton Pointer )
            value.CancelButton                              = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0x40 CancelButton                ( ModelClassType UIButton UIButton UIButton Pointer )
            value.DeckButton                                = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 0x48 DeckButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x050), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x50 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.TouchBlockObject                          = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 TouchBlockObject            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SelectedThumbnail                         = GetObject<UIImage>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIImage.FromPointer); // 0x60 SelectedThumbnail           ( ModelClassType UIImage UIImage UIImage Pointer )
            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x068), ReversePrism.DataModels.Animator.FromPointer); // 0x68 Animator                    ( ModelClassType Animator Animator Animator Pointer )
            value.PopupPrefab                               = GetObject<PopupBase>(new IntPtr(p + 0x070), ReversePrism.DataModels.PopupBase.FromPointer); // 0x70 PopupPrefab                 ( ModelClassType PopupBase PopupBase PopupBase Pointer )
            value.AnimeDissapoble                           = GetObject<IDisposable>(new IntPtr(p + 0x078), ReversePrism.DataModels.IDisposable.FromPointer); // 0x78 AnimeDissapoble             ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x080), ReversePrism.DataModels.IDisposable.FromPointer); // 0x80 BackKeyDisposable           ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.Popup                                     = GetObject<PopupBase>(new IntPtr(p + 0x088), ReversePrism.DataModels.PopupBase.FromPointer); // 0x88 Popup                       ( ModelClassType PopupBase PopupBase PopupBase Pointer )
            value.PrevParent                                = GetObject<Transform>(new IntPtr(p + 0x090), ReversePrism.DataModels.Transform.FromPointer); // 0x90 PrevParent                  ( ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
