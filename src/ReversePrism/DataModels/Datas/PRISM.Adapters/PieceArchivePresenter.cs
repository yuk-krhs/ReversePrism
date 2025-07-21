using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Argument                                 ModelClassType PieceArchiveArgument PieceArchiveArgument PieceArchiveArgument Pointer
    // 018 View                                     ModelClassType IPieceArchiveView IPieceArchiveView IPieceArchiveView Pointer
    // 020 TitleView                                ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 028 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 038 Vm                                       ModelClassType PieceArchiveViewModel PieceArchiveViewModel PieceArchiveViewModel Pointer
    public partial class PieceArchivePresenter : DataModel
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
            var value   = new PieceArchivePresenter() { Pointer= p0 };

            value.Argument                                  = GetObject<PieceArchiveArgument>(new IntPtr(p + 0x010), ReversePrism.DataModels.PieceArchiveArgument.FromPointer); // 0x10 Argument                    ( ModelClassType PieceArchiveArgument PieceArchiveArgument PieceArchiveArgument Pointer )
            value.View                                      = GetObject<IPieceArchiveView>(new IntPtr(p + 0x018), ReversePrism.DataModels.IPieceArchiveView.FromPointer); // 0x18 View                        ( ModelClassType IPieceArchiveView IPieceArchiveView IPieceArchiveView Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x020), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0x20 TitleView                   ( ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x28 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x30 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Vm                                        = GetObject<PieceArchiveViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.PieceArchiveViewModel.FromPointer); // 0x38 Vm                          ( ModelClassType PieceArchiveViewModel PieceArchiveViewModel PieceArchiveViewModel Pointer )

            return value;
        }
    }
}
