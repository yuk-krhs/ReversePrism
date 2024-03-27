using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     000186585D50 ModelClassType IIntroductionCharacterSelectView IIntroductionCharacterSelectView IIntroductionCharacterSelectView Pointer
    // 018 ViewModel                                000186725E60 ModelClassType IntroductionCharacterSelectViewModel IntroductionCharacterSelectViewModel IntroductionCharacterSelectViewModel Pointer
    // 020 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class IntroductionCharacterSelectPresenter
    {
        public IIntroductionCharacterSelectView?        View                                    { get; set; }
        public IntroductionCharacterSelectViewModel?    ViewModel                               { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static IntroductionCharacterSelectPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntroductionCharacterSelectPresenter();

            value.View                                      = GetObject<IIntroductionCharacterSelectView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IIntroductionCharacterSelectView.FromPointer); // 0270D63ACAB0 0x10 View                        ( 000186585D50 ModelClassType IIntroductionCharacterSelectView IIntroductionCharacterSelectView IIntroductionCharacterSelectView Pointer )
            value.ViewModel                                 = GetObject<IntroductionCharacterSelectViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.IntroductionCharacterSelectViewModel.FromPointer); // 0270D63ACAD0 0x18 ViewModel                   ( 000186725E60 ModelClassType IntroductionCharacterSelectViewModel IntroductionCharacterSelectViewModel IntroductionCharacterSelectViewModel Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D63ACAF0 0x20 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
