using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Model                                    000186557550 ModelClassType ChainGroupMemberScreenModel ChainGroupMemberScreenModel ChainGroupMemberScreenModel Pointer
    // 018 View                                     00018671BFF0 ModelClassType IChainGroupMemberScreenView IChainGroupMemberScreenView IChainGroupMemberScreenView Pointer
    // 020 Parameter                                000186556DB0 ModelClassType ChainGroupMemberParameter ChainGroupMemberParameter ChainGroupMemberParameter Pointer
    // 028 Container                                0001865B76B0 ModelClassType IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer Pointer
    // 030 Cts                                      0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 038 Disposable                               0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class ChainGroupMemberScreenPresenter : DataModel
    {
        public ChainGroupMemberScreenModel?             Model                                   { get; set; }
        public IChainGroupMemberScreenView?             View                                    { get; set; }
        public ChainGroupMemberParameter?               Parameter                               { get; set; }
        public IMobileScreenCommonInfoContainer?        Container                               { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }

        public static ChainGroupMemberScreenPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainGroupMemberScreenPresenter() { Pointer= p0 };

            value.Model                                     = GetObject<ChainGroupMemberScreenModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ChainGroupMemberScreenModel.FromPointer); // 0246668C5818 0x10 Model                       ( 000186557550 ModelClassType ChainGroupMemberScreenModel ChainGroupMemberScreenModel ChainGroupMemberScreenModel Pointer )
            value.View                                      = GetObject<IChainGroupMemberScreenView>(new IntPtr(p + 0x018), ReversePrism.DataModels.IChainGroupMemberScreenView.FromPointer); // 0246668C5838 0x18 View                        ( 00018671BFF0 ModelClassType IChainGroupMemberScreenView IChainGroupMemberScreenView IChainGroupMemberScreenView Pointer )
            value.Parameter                                 = GetObject<ChainGroupMemberParameter>(new IntPtr(p + 0x020), ReversePrism.DataModels.ChainGroupMemberParameter.FromPointer); // 0246668C5858 0x20 Parameter                   ( 000186556DB0 ModelClassType ChainGroupMemberParameter ChainGroupMemberParameter ChainGroupMemberParameter Pointer )
            value.Container                                 = GetObject<IMobileScreenCommonInfoContainer>(new IntPtr(p + 0x028), ReversePrism.DataModels.IMobileScreenCommonInfoContainer.FromPointer); // 0246668C5878 0x28 Container                   ( 0001865B76B0 ModelClassType IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x030), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0246668C5898 0x30 Cts                         ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0246668C58B8 0x38 Disposable                  ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
