using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Argument                                 000186572560 ModelClassType ProduceResultArgument ProduceResultArgument ProduceResultArgument Pointer
    // 018 View                                     0001865F2660 ModelClassType IProduceResultView IProduceResultView IProduceResultView Pointer
    // 020 FUnitDetailPopupViewFactory              0001865F1840 ModelClassType IProduceResultFUnitDetailPopupViewFactory IProduceResultFUnitDetailPopupViewFactory IProduceResultFUnitDetailPopupViewFactory Pointer
    // 028 TokenSource                              0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 038 idolBaseRewards                          IEnumerable`1<IIdolBaseRewardStatus> IL2CPP_TYPE_GENERICINST
    // 040 CurrentPhase                             00018661C290 ModelEnumType ResultPhase ResultPhase ResultPhase Int32
    public partial class ProduceResultPresenter
    {
        public ProduceResultArgument?                   Argument                                { get; set; }
        public IProduceResultView?                      View                                    { get; set; }
        public IProduceResultFUnitDetailPopupViewFactory? FUnitDetailPopupViewFactory             { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public ResultPhase                              CurrentPhase                            { get; set; }

        public static ProduceResultPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceResultPresenter();

            value.Argument                                  = GetObject<ProduceResultArgument>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProduceResultArgument.FromPointer); // 0270D683A580 0x10 Argument                    ( 000186572560 ModelClassType ProduceResultArgument ProduceResultArgument ProduceResultArgument Pointer )
            value.View                                      = GetObject<IProduceResultView>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProduceResultView.FromPointer); // 0270D683A5A0 0x18 View                        ( 0001865F2660 ModelClassType IProduceResultView IProduceResultView IProduceResultView Pointer )
            value.FUnitDetailPopupViewFactory               = GetObject<IProduceResultFUnitDetailPopupViewFactory>(new IntPtr(p + 0x020), ReversePrism.DataModels.IProduceResultFUnitDetailPopupViewFactory.FromPointer); // 0270D683A5C0 0x20 FUnitDetailPopupViewFactory ( 0001865F1840 ModelClassType IProduceResultFUnitDetailPopupViewFactory IProduceResultFUnitDetailPopupViewFactory IProduceResultFUnitDetailPopupViewFactory Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D683A5E0 0x28 TokenSource                 ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D683A600 0x30 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.CurrentPhase                              = (ResultPhase)GetInt32(new IntPtr(p + 0x040)); // 0270D683A640 0x40 CurrentPhase                ( 00018661C290 ModelEnumType ResultPhase ResultPhase ResultPhase Int32 )

            return value;
        }
    }
}
