using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 LetterImage                              ModelClassType Image Image Image Pointer
    // 028 CloseButton                              ModelClassType UIButton UIButton UIButton Pointer
    // 030 ButtonText                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 Animator                                 ModelClassType Animator Animator Animator Pointer
    // 040 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 048 ViewModel                                ModelClassType IntroductionViewModel IntroductionViewModel IntroductionViewModel Pointer
    // 050 BackKeyDisposable                        ModelClassType IDisposable IDisposable IDisposable Pointer
    // 058 onNextStep                               Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 060 onClose                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class IntroductionLetterOverlayView : DataModel
    {
        public Image?                                   LetterImage                             { get; set; }
        public UIButton?                                CloseButton                             { get; set; }
        public UITextMeshProUGUI?                       ButtonText                              { get; set; }
        public Animator?                                Animator                                { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }
        public IntroductionViewModel?                   ViewModel                               { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }

        public static IntroductionLetterOverlayView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntroductionLetterOverlayView() { Pointer= p0 };

            value.LetterImage                               = GetObject<Image>(new IntPtr(p + 0x020), ReversePrism.DataModels.Image.FromPointer); // 0x20 LetterImage                 ( ModelClassType Image Image Image Pointer )
            value.CloseButton                               = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0x28 CloseButton                 ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ButtonText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 ButtonText                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x038), ReversePrism.DataModels.Animator.FromPointer); // 0x38 Animator                    ( ModelClassType Animator Animator Animator Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x040), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x40 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.ViewModel                                 = GetObject<IntroductionViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.IntroductionViewModel.FromPointer); // 0x48 ViewModel                   ( ModelClassType IntroductionViewModel IntroductionViewModel IntroductionViewModel Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x050), ReversePrism.DataModels.IDisposable.FromPointer); // 0x50 BackKeyDisposable           ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
