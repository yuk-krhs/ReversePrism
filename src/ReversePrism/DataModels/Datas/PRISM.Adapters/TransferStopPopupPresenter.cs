using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     00018667E040 ModelClassType ITransferStopPopupView ITransferStopPopupView ITransferStopPopupView Pointer
    // 018 Model                                    0001866A9390 ModelClassType TransferStopPopupModel TransferStopPopupModel TransferStopPopupModel Pointer
    // 020 CompositeDisposable                      0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class TransferStopPopupPresenter : DataModel
    {
        public ITransferStopPopupView?                  View                                    { get; set; }
        public TransferStopPopupModel?                  Model                                   { get; set; }
        public CompositeDisposable?                     CompositeDisposable                     { get; set; }

        public static TransferStopPopupPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TransferStopPopupPresenter() { Pointer= p0 };

            value.View                                      = GetObject<ITransferStopPopupView>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITransferStopPopupView.FromPointer); // 0246667DD3A8 0x10 View                        ( 00018667E040 ModelClassType ITransferStopPopupView ITransferStopPopupView ITransferStopPopupView Pointer )
            value.Model                                     = GetObject<TransferStopPopupModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.TransferStopPopupModel.FromPointer); // 0246667DD3C8 0x18 Model                       ( 0001866A9390 ModelClassType TransferStopPopupModel TransferStopPopupModel TransferStopPopupModel Pointer )
            value.CompositeDisposable                       = GetObject<CompositeDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0246667DD3E8 0x20 CompositeDisposable         ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
