using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Model                                    0001865297E0 ModelClassType CallHistoryScreenModel CallHistoryScreenModel CallHistoryScreenModel Pointer
    // 018 View                                     0001867174D0 ModelClassType ICallHistoryScreenView ICallHistoryScreenView ICallHistoryScreenView Pointer
    // 020 Parameter                                000186529030 ModelClassType CallHistoryParameter CallHistoryParameter CallHistoryParameter Pointer
    // 028 Container                                0001865B76B0 ModelClassType IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer Pointer
    // 030 Cts                                      0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 038 Disposable                               0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class CallHistoryScreenPresenter : DataModel
    {
        public CallHistoryScreenModel?                  Model                                   { get; set; }
        public ICallHistoryScreenView?                  View                                    { get; set; }
        public CallHistoryParameter?                    Parameter                               { get; set; }
        public IMobileScreenCommonInfoContainer?        Container                               { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }

        public static CallHistoryScreenPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CallHistoryScreenPresenter() { Pointer= p0 };

            value.Model                                     = GetObject<CallHistoryScreenModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.CallHistoryScreenModel.FromPointer); // 0246668A3350 0x10 Model                       ( 0001865297E0 ModelClassType CallHistoryScreenModel CallHistoryScreenModel CallHistoryScreenModel Pointer )
            value.View                                      = GetObject<ICallHistoryScreenView>(new IntPtr(p + 0x018), ReversePrism.DataModels.ICallHistoryScreenView.FromPointer); // 0246668A3370 0x18 View                        ( 0001867174D0 ModelClassType ICallHistoryScreenView ICallHistoryScreenView ICallHistoryScreenView Pointer )
            value.Parameter                                 = GetObject<CallHistoryParameter>(new IntPtr(p + 0x020), ReversePrism.DataModels.CallHistoryParameter.FromPointer); // 0246668A3390 0x20 Parameter                   ( 000186529030 ModelClassType CallHistoryParameter CallHistoryParameter CallHistoryParameter Pointer )
            value.Container                                 = GetObject<IMobileScreenCommonInfoContainer>(new IntPtr(p + 0x028), ReversePrism.DataModels.IMobileScreenCommonInfoContainer.FromPointer); // 0246668A33B0 0x28 Container                   ( 0001865B76B0 ModelClassType IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x030), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0246668A33D0 0x30 Cts                         ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0246668A33F0 0x38 Disposable                  ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
