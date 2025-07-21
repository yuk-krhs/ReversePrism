using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IAuditionSuccessResultView IAuditionSuccessResultView IAuditionSuccessResultView Pointer
    // 018 Argument                                 ModelClassType AuditionSuccessResultArgument AuditionSuccessResultArgument AuditionSuccessResultArgument Pointer
    // 020 AdvPresenter                             ModelClassType InGameResultADVPresenter InGameResultADVPresenter InGameResultADVPresenter Pointer
    // 028 TokenSource                              ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class AuditionSuccessResultPresenter : DataModel
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
            var value   = new AuditionSuccessResultPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IAuditionSuccessResultView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IAuditionSuccessResultView.FromPointer); // 0x10 View                        ( ModelClassType IAuditionSuccessResultView IAuditionSuccessResultView IAuditionSuccessResultView Pointer )
            value.Argument                                  = GetObject<AuditionSuccessResultArgument>(new IntPtr(p + 0x018), ReversePrism.DataModels.AuditionSuccessResultArgument.FromPointer); // 0x18 Argument                    ( ModelClassType AuditionSuccessResultArgument AuditionSuccessResultArgument AuditionSuccessResultArgument Pointer )
            value.AdvPresenter                              = GetObject<InGameResultADVPresenter>(new IntPtr(p + 0x020), ReversePrism.DataModels.InGameResultADVPresenter.FromPointer); // 0x20 AdvPresenter                ( ModelClassType InGameResultADVPresenter InGameResultADVPresenter InGameResultADVPresenter Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x28 TokenSource                 ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x30 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
