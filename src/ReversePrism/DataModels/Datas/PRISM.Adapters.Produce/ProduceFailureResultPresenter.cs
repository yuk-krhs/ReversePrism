using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Argument                                 00018653F640 ModelClassType ProduceFailureResultArgument ProduceFailureResultArgument ProduceFailureResultArgument Pointer
    // 018 View                                     0001865E74F0 ModelClassType IProduceFailureResultView IProduceFailureResultView IProduceFailureResultView Pointer
    // 020 AdvPresenter                             0001866D8020 ModelClassType InGameResultADVPresenter InGameResultADVPresenter InGameResultADVPresenter Pointer
    // 028 TokenSource                              0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 038 CurrentPhase                             0001865D8BA0 ModelEnumType ResultPhase ResultPhase ResultPhase Int32
    public partial class ProduceFailureResultPresenter
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
            var value   = new ProduceFailureResultPresenter();

            value.Argument                                  = GetObject<ProduceFailureResultArgument>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProduceFailureResultArgument.FromPointer); // 0270D681EA20 0x10 Argument                    ( 00018653F640 ModelClassType ProduceFailureResultArgument ProduceFailureResultArgument ProduceFailureResultArgument Pointer )
            value.View                                      = GetObject<IProduceFailureResultView>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProduceFailureResultView.FromPointer); // 0270D681EA40 0x18 View                        ( 0001865E74F0 ModelClassType IProduceFailureResultView IProduceFailureResultView IProduceFailureResultView Pointer )
            value.AdvPresenter                              = GetObject<InGameResultADVPresenter>(new IntPtr(p + 0x020), ReversePrism.DataModels.InGameResultADVPresenter.FromPointer); // 0270D681EA60 0x20 AdvPresenter                ( 0001866D8020 ModelClassType InGameResultADVPresenter InGameResultADVPresenter InGameResultADVPresenter Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D681EA80 0x28 TokenSource                 ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D681EAA0 0x30 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.CurrentPhase                              = (ResultPhase)GetInt32(new IntPtr(p + 0x038)); // 0270D681EAC0 0x38 CurrentPhase                ( 0001865D8BA0 ModelEnumType ResultPhase ResultPhase ResultPhase Int32 )

            return value;
        }
    }
}
