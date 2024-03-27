using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     00018670BFA0 ModelClassType IAuditionSuccessResultView IAuditionSuccessResultView IAuditionSuccessResultView Pointer
    // 018 Argument                                 00018671D0B0 ModelClassType AuditionSuccessResultArgument AuditionSuccessResultArgument AuditionSuccessResultArgument Pointer
    // 020 AdvPresenter                             0001866D8020 ModelClassType InGameResultADVPresenter InGameResultADVPresenter InGameResultADVPresenter Pointer
    // 028 TokenSource                              0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class AuditionSuccessResultPresenter
    {
        public IAuditionSuccessResultView?              View                                    { get; set; }
        public AuditionSuccessResultArgument?           Argument                                { get; set; }
        public InGameResultADVPresenter?                AdvPresenter                            { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static AuditionSuccessResultPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AuditionSuccessResultPresenter();

            value.View                                      = GetObject<IAuditionSuccessResultView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IAuditionSuccessResultView.FromPointer); // 0270D681C928 0x10 View                        ( 00018670BFA0 ModelClassType IAuditionSuccessResultView IAuditionSuccessResultView IAuditionSuccessResultView Pointer )
            value.Argument                                  = GetObject<AuditionSuccessResultArgument>(new IntPtr(p + 0x018), ReversePrism.DataModels.AuditionSuccessResultArgument.FromPointer); // 0270D681C948 0x18 Argument                    ( 00018671D0B0 ModelClassType AuditionSuccessResultArgument AuditionSuccessResultArgument AuditionSuccessResultArgument Pointer )
            value.AdvPresenter                              = GetObject<InGameResultADVPresenter>(new IntPtr(p + 0x020), ReversePrism.DataModels.InGameResultADVPresenter.FromPointer); // 0270D681C968 0x20 AdvPresenter                ( 0001866D8020 ModelClassType InGameResultADVPresenter InGameResultADVPresenter InGameResultADVPresenter Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D681C988 0x28 TokenSource                 ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D681C9A8 0x30 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
