using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 018 View                                     ModelClassType ILiveEventView ILiveEventView ILiveEventView Pointer
    // 020 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 028 EventMaster                              ModelClassType MstEvent MstEvent MstEvent Pointer
    // 030 LiveEventModel                           ModelClassType LiveEventViewModel LiveEventViewModel LiveEventViewModel Pointer
    public partial class LiveEventPresenter : DataModel
    {
        public CompositeDisposable?                     Disposables                             { get; set; }
        public ILiveEventView?                          View                                    { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public MstEvent?                                EventMaster                             { get; set; }
        public LiveEventViewModel?                      LiveEventModel                          { get; set; }

        public static LiveEventPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventPresenter() { Pointer= p0 };

            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x010), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x10 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.View                                      = GetObject<ILiveEventView>(new IntPtr(p + 0x018), ReversePrism.DataModels.ILiveEventView.FromPointer); // 0x18 View                        ( ModelClassType ILiveEventView ILiveEventView ILiveEventView Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x020), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x20 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.EventMaster                               = GetObject<MstEvent>(new IntPtr(p + 0x028), ReversePrism.DataModels.MstEvent.FromPointer); // 0x28 EventMaster                 ( ModelClassType MstEvent MstEvent MstEvent Pointer )
            value.LiveEventModel                            = GetObject<LiveEventViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.LiveEventViewModel.FromPointer); // 0x30 LiveEventModel              ( ModelClassType LiveEventViewModel LiveEventViewModel LiveEventViewModel Pointer )

            return value;
        }
    }
}
