using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ResourceTagName                          string IL2CPP_TYPE_STRING
    // 020 LetterImage                              0001866CCDB0 ModelClassType Image Image Image Pointer
    // 028 CloseButton                              0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 030 ButtonText                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 Animator                                 0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 040 ViewModel                                000186730E20 ModelClassType IntroductionViewModel IntroductionViewModel IntroductionViewModel Pointer
    // 048 BackKeyDisposable                        0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 050 onNextStep                               Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 058 onClose                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 060 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    public partial class IntroductionLetterOverlayView
    {
        public Image?                                   LetterImage                             { get; set; }
        public UIButton?                                CloseButton                             { get; set; }
        public UITextMeshProUGUI?                       ButtonText                              { get; set; }
        public Animator?                                Animator                                { get; set; }
        public IntroductionViewModel?                   ViewModel                               { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static IntroductionLetterOverlayView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntroductionLetterOverlayView();

            value.LetterImage                               = GetObject<Image>(new IntPtr(p + 0x020), ReversePrism.DataModels.Image.FromPointer); // 0270DBC4B588 0x20 LetterImage                 ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.CloseButton                               = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0270DBC4B5A8 0x28 CloseButton                 ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ButtonText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DBC4B5C8 0x30 ButtonText                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x038), ReversePrism.DataModels.Animator.FromPointer); // 0270DBC4B5E8 0x38 Animator                    ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.ViewModel                                 = GetObject<IntroductionViewModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.IntroductionViewModel.FromPointer); // 0270DBC4B608 0x40 ViewModel                   ( 000186730E20 ModelClassType IntroductionViewModel IntroductionViewModel IntroductionViewModel Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x048), ReversePrism.DataModels.IDisposable.FromPointer); // 0270DBC4B628 0x48 BackKeyDisposable           ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x060), ReversePrism.DataModels.IResourceTag.FromPointer); // 0270DBC4B688 0x60 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
