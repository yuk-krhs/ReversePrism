using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IIntroductionCharacterSelectView IIntroductionCharacterSelectView IIntroductionCharacterSelectView Pointer
    // 018 ViewModel                                ModelClassType IntroductionCharacterSelectViewModel IntroductionCharacterSelectViewModel IntroductionCharacterSelectViewModel Pointer
    // 020 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class IntroductionCharacterSelectPresenter : DataModel
    {
        public IIntroductionCharacterSelectView?        View                                    { get; set; }
        public IntroductionCharacterSelectViewModel?    ViewModel                               { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static IntroductionCharacterSelectPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntroductionCharacterSelectPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IIntroductionCharacterSelectView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IIntroductionCharacterSelectView.FromPointer); // 0x10 View                        ( ModelClassType IIntroductionCharacterSelectView IIntroductionCharacterSelectView IIntroductionCharacterSelectView Pointer )
            value.ViewModel                                 = GetObject<IntroductionCharacterSelectViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.IntroductionCharacterSelectViewModel.FromPointer); // 0x18 ViewModel                   ( ModelClassType IntroductionCharacterSelectViewModel IntroductionCharacterSelectViewModel IntroductionCharacterSelectViewModel Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x20 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
