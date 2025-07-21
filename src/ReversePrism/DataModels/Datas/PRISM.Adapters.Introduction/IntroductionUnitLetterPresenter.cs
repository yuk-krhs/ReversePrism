using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IIntroductionUnitLetterView IIntroductionUnitLetterView IIntroductionUnitLetterView Pointer
    // 018 Argument                                 ModelClassType IntroductionUnitLetterArgument IntroductionUnitLetterArgument IntroductionUnitLetterArgument Pointer
    // 020 introductionViewModelDic                 IReadOnlyDictionary`2<int, IntroductionViewModel> IL2CPP_TYPE_GENERICINST
    // 028 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class IntroductionUnitLetterPresenter : DataModel
    {
        public IIntroductionUnitLetterView?             View                                    { get; set; }
        public IntroductionUnitLetterArgument?          Argument                                { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static IntroductionUnitLetterPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntroductionUnitLetterPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IIntroductionUnitLetterView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IIntroductionUnitLetterView.FromPointer); // 0x10 View                        ( ModelClassType IIntroductionUnitLetterView IIntroductionUnitLetterView IIntroductionUnitLetterView Pointer )
            value.Argument                                  = GetObject<IntroductionUnitLetterArgument>(new IntPtr(p + 0x018), ReversePrism.DataModels.IntroductionUnitLetterArgument.FromPointer); // 0x18 Argument                    ( ModelClassType IntroductionUnitLetterArgument IntroductionUnitLetterArgument IntroductionUnitLetterArgument Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x28 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x30 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
