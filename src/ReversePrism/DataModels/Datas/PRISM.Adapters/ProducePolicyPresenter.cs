using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ProducePolicyModel                       000186564DE0 ModelClassType ProducePolicyModel ProducePolicyModel ProducePolicyModel Pointer
    // 018 ProducePolicyViewModel                   000186565F80 ModelClassType ProducePolicyViewModel ProducePolicyViewModel ProducePolicyViewModel Pointer
    // 020 ProducePolicyView                        0001865F0120 ModelClassType IProducePolicyView IProducePolicyView IProducePolicyView Pointer
    // 028 OnInActivateTitleView                    0001866792B0 ModelClassType Action Action Action Pointer
    // 030 Cts                                      0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 038 onClickProducePolicyButton               Action`1<int> IL2CPP_TYPE_GENERICINST
    public partial class ProducePolicyPresenter
    {
        public ProducePolicyModel?                      ProducePolicyModel                      { get; set; }
        public ProducePolicyViewModel?                  ProducePolicyViewModel                  { get; set; }
        public IProducePolicyView?                      ProducePolicyView                       { get; set; }
        public Action?                                  OnInActivateTitleView                   { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }

        public static ProducePolicyPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProducePolicyPresenter();

            value.ProducePolicyModel                        = GetObject<ProducePolicyModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProducePolicyModel.FromPointer); // 0270D658EC58 0x10 ProducePolicyModel          ( 000186564DE0 ModelClassType ProducePolicyModel ProducePolicyModel ProducePolicyModel Pointer )
            value.ProducePolicyViewModel                    = GetObject<ProducePolicyViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProducePolicyViewModel.FromPointer); // 0270D658EC78 0x18 ProducePolicyViewModel      ( 000186565F80 ModelClassType ProducePolicyViewModel ProducePolicyViewModel ProducePolicyViewModel Pointer )
            value.ProducePolicyView                         = GetObject<IProducePolicyView>(new IntPtr(p + 0x020), ReversePrism.DataModels.IProducePolicyView.FromPointer); // 0270D658EC98 0x20 ProducePolicyView           ( 0001865F0120 ModelClassType IProducePolicyView IProducePolicyView IProducePolicyView Pointer )
            value.OnInActivateTitleView                     = GetObject<Action>(new IntPtr(p + 0x028), ReversePrism.DataModels.Action.FromPointer); // 0270D658ECB8 0x28 OnInActivateTitleView       ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x030), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D658ECD8 0x30 Cts                         ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
