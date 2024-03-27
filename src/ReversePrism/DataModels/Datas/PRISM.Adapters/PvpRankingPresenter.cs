using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     000186604C80 ModelClassType IPvPRankingView IPvPRankingView IPvPRankingView Pointer
    // 018 Argument                                 0001865F06F0 ModelClassType PvpRankingArgument PvpRankingArgument PvpRankingArgument Pointer
    // 020 Model                                    0001865F17B0 ModelClassType PvpRankingModel PvpRankingModel PvpRankingModel Pointer
    // 028 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 030 Cts                                      0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class PvpRankingPresenter
    {
        public IPvPRankingView?                         View                                    { get; set; }
        public PvpRankingArgument?                      Argument                                { get; set; }
        public PvpRankingModel?                         Model                                   { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }

        public static PvpRankingPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpRankingPresenter();

            value.View                                      = GetObject<IPvPRankingView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IPvPRankingView.FromPointer); // 0270D6616208 0x10 View                        ( 000186604C80 ModelClassType IPvPRankingView IPvPRankingView IPvPRankingView Pointer )
            value.Argument                                  = GetObject<PvpRankingArgument>(new IntPtr(p + 0x018), ReversePrism.DataModels.PvpRankingArgument.FromPointer); // 0270D6616228 0x18 Argument                    ( 0001865F06F0 ModelClassType PvpRankingArgument PvpRankingArgument PvpRankingArgument Pointer )
            value.Model                                     = GetObject<PvpRankingModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.PvpRankingModel.FromPointer); // 0270D6616248 0x20 Model                       ( 0001865F17B0 ModelClassType PvpRankingModel PvpRankingModel PvpRankingModel Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x028), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D6616268 0x28 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x030), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D6616288 0x30 Cts                         ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
