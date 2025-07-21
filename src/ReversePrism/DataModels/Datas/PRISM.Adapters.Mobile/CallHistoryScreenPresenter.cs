using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Model                                    ModelClassType CallHistoryScreenModel CallHistoryScreenModel CallHistoryScreenModel Pointer
    // 018 View                                     ModelClassType ICallHistoryScreenView ICallHistoryScreenView ICallHistoryScreenView Pointer
    // 020 Parameter                                ModelClassType CallHistoryParameter CallHistoryParameter CallHistoryParameter Pointer
    // 028 Container                                ModelClassType IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer Pointer
    // 030 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 038 Disposable                               ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
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

            value.Model                                     = GetObject<CallHistoryScreenModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.CallHistoryScreenModel.FromPointer); // 0x10 Model                       ( ModelClassType CallHistoryScreenModel CallHistoryScreenModel CallHistoryScreenModel Pointer )
            value.View                                      = GetObject<ICallHistoryScreenView>(new IntPtr(p + 0x018), ReversePrism.DataModels.ICallHistoryScreenView.FromPointer); // 0x18 View                        ( ModelClassType ICallHistoryScreenView ICallHistoryScreenView ICallHistoryScreenView Pointer )
            value.Parameter                                 = GetObject<CallHistoryParameter>(new IntPtr(p + 0x020), ReversePrism.DataModels.CallHistoryParameter.FromPointer); // 0x20 Parameter                   ( ModelClassType CallHistoryParameter CallHistoryParameter CallHistoryParameter Pointer )
            value.Container                                 = GetObject<IMobileScreenCommonInfoContainer>(new IntPtr(p + 0x028), ReversePrism.DataModels.IMobileScreenCommonInfoContainer.FromPointer); // 0x28 Container                   ( ModelClassType IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x030), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x30 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x38 Disposable                  ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
