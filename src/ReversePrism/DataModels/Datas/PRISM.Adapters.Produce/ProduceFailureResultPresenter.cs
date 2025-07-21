using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Argument                                 ModelClassType ProduceFailureResultArgument ProduceFailureResultArgument ProduceFailureResultArgument Pointer
    // 018 View                                     ModelClassType IProduceFailureResultView IProduceFailureResultView IProduceFailureResultView Pointer
    // 020 AdvPresenter                             ModelClassType InGameResultADVPresenter InGameResultADVPresenter InGameResultADVPresenter Pointer
    // 028 TokenSource                              ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 038 CurrentPhase                             ModelEnumType ResultPhase ResultPhase ResultPhase Int32
    public partial class ProduceFailureResultPresenter : DataModel
    {
        public ProduceFailureResultArgument?            Argument                                { get; set; }
        public IProduceFailureResultView?               View                                    { get; set; }
        public InGameResultADVPresenter?                AdvPresenter                            { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public ResultPhase                              CurrentPhase                            { get; set; }

        public static ProduceFailureResultPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceFailureResultPresenter() { Pointer= p0 };

            value.Argument                                  = GetObject<ProduceFailureResultArgument>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProduceFailureResultArgument.FromPointer); // 0x10 Argument                    ( ModelClassType ProduceFailureResultArgument ProduceFailureResultArgument ProduceFailureResultArgument Pointer )
            value.View                                      = GetObject<IProduceFailureResultView>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProduceFailureResultView.FromPointer); // 0x18 View                        ( ModelClassType IProduceFailureResultView IProduceFailureResultView IProduceFailureResultView Pointer )
            value.AdvPresenter                              = GetObject<InGameResultADVPresenter>(new IntPtr(p + 0x020), ReversePrism.DataModels.InGameResultADVPresenter.FromPointer); // 0x20 AdvPresenter                ( ModelClassType InGameResultADVPresenter InGameResultADVPresenter InGameResultADVPresenter Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x28 TokenSource                 ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x30 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.CurrentPhase                              = (ResultPhase)GetInt32(new IntPtr(p + 0x038)); // 0x38 CurrentPhase                ( ModelEnumType ResultPhase ResultPhase ResultPhase Int32 )

            return value;
        }
    }
}
