using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Argument                                 00018673CF20 ModelClassType PieceArchiveArgument PieceArchiveArgument PieceArchiveArgument Pointer
    // 018 View                                     0001865D5790 ModelClassType IPieceArchiveView IPieceArchiveView IPieceArchiveView Pointer
    // 020 TitleView                                0001865EA1D0 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 028 pieceConversionConfirmedPopupViewFactory IPopupViewFactory`1<IPieceConversionConfirmedPopupView> IL2CPP_TYPE_GENERICINST
    // 030 pieceConversionCompletedPopupViewFactory IPopupViewFactory`1<IPieceConversionCompletedPopupView> IL2CPP_TYPE_GENERICINST
    // 038 Cts                                      0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 040 Disposables                              0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 048 Vm                                       00018673F090 ModelClassType PieceArchiveViewModel PieceArchiveViewModel PieceArchiveViewModel Pointer
    public partial class PieceArchivePresenter
    {
        public PieceArchiveArgument?                    Argument                                { get; set; }
        public IPieceArchiveView?                       View                                    { get; set; }
        public CommonTitleView?                         TitleView                               { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public PieceArchiveViewModel?                   Vm                                      { get; set; }

        public static PieceArchivePresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PieceArchivePresenter();

            value.Argument                                  = GetObject<PieceArchiveArgument>(new IntPtr(p + 0x010), ReversePrism.DataModels.PieceArchiveArgument.FromPointer); // 0270D5F1A628 0x10 Argument                    ( 00018673CF20 ModelClassType PieceArchiveArgument PieceArchiveArgument PieceArchiveArgument Pointer )
            value.View                                      = GetObject<IPieceArchiveView>(new IntPtr(p + 0x018), ReversePrism.DataModels.IPieceArchiveView.FromPointer); // 0270D5F1A648 0x18 View                        ( 0001865D5790 ModelClassType IPieceArchiveView IPieceArchiveView IPieceArchiveView Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x020), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0270D5F1A668 0x20 TitleView                   ( 0001865EA1D0 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x038), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D5F1A6C8 0x38 Cts                         ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x040), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D5F1A6E8 0x40 Disposables                 ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Vm                                        = GetObject<PieceArchiveViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.PieceArchiveViewModel.FromPointer); // 0270D5F1A708 0x48 Vm                          ( 00018673F090 ModelClassType PieceArchiveViewModel PieceArchiveViewModel PieceArchiveViewModel Pointer )

            return value;
        }
    }
}
