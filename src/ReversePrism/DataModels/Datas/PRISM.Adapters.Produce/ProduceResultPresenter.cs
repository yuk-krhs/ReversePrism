using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Argument                                 ModelClassType ProduceResultArgument ProduceResultArgument ProduceResultArgument Pointer
    // 018 View                                     ModelClassType IProduceResultView IProduceResultView IProduceResultView Pointer
    // 020 TokenSource                              ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 028 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 030 idolBaseRewards                          IEnumerable`1<IIdolBaseRewardStatus> IL2CPP_TYPE_GENERICINST
    // 038 CurrentPhase                             ModelEnumType ResultPhase ResultPhase ResultPhase Int32
    public partial class ProduceResultPresenter : DataModel
    {
        public ProduceResultArgument?                   Argument                                { get; set; }
        public IProduceResultView?                      View                                    { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public ResultPhase                              CurrentPhase                            { get; set; }

        public static ProduceResultPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceResultPresenter() { Pointer= p0 };

            value.Argument                                  = GetObject<ProduceResultArgument>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProduceResultArgument.FromPointer); // 0x10 Argument                    ( ModelClassType ProduceResultArgument ProduceResultArgument ProduceResultArgument Pointer )
            value.View                                      = GetObject<IProduceResultView>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProduceResultView.FromPointer); // 0x18 View                        ( ModelClassType IProduceResultView IProduceResultView IProduceResultView Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x020), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x20 TokenSource                 ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x028), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x28 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.CurrentPhase                              = (ResultPhase)GetInt32(new IntPtr(p + 0x038)); // 0x38 CurrentPhase                ( ModelEnumType ResultPhase ResultPhase ResultPhase Int32 )

            return value;
        }
    }
}
