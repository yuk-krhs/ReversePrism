using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     000186587F00 ModelClassType IIntroductionUnitLetterView IIntroductionUnitLetterView IIntroductionUnitLetterView Pointer
    // 018 Argument                                 00018672D920 ModelClassType IntroductionUnitLetterArgument IntroductionUnitLetterArgument IntroductionUnitLetterArgument Pointer
    // 020 introductionViewModelDic                 IReadOnlyDictionary`2<int, IntroductionViewModel> IL2CPP_TYPE_GENERICINST
    // 028 Cts                                      0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 Disposables                              0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class IntroductionUnitLetterPresenter
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
            var value   = new IntroductionUnitLetterPresenter();

            value.View                                      = GetObject<IIntroductionUnitLetterView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IIntroductionUnitLetterView.FromPointer); // 0270D6840EF0 0x10 View                        ( 000186587F00 ModelClassType IIntroductionUnitLetterView IIntroductionUnitLetterView IIntroductionUnitLetterView Pointer )
            value.Argument                                  = GetObject<IntroductionUnitLetterArgument>(new IntPtr(p + 0x018), ReversePrism.DataModels.IntroductionUnitLetterArgument.FromPointer); // 0270D6840F10 0x18 Argument                    ( 00018672D920 ModelClassType IntroductionUnitLetterArgument IntroductionUnitLetterArgument IntroductionUnitLetterArgument Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D6840F50 0x28 Cts                         ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D6840F70 0x30 Disposables                 ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
