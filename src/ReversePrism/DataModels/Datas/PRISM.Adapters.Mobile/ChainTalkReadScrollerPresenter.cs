using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     00018671CBF0 ModelClassType IChainReadTalkScrollerView IChainReadTalkScrollerView IChainReadTalkScrollerView Pointer
    public partial class ChainTalkReadScrollerPresenter
    {
        public IChainReadTalkScrollerView?              View                                    { get; set; }

        public static ChainTalkReadScrollerPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkReadScrollerPresenter();

            value.View                                      = GetObject<IChainReadTalkScrollerView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IChainReadTalkScrollerView.FromPointer); // 0270D686A068 0x10 View                        ( 00018671CBF0 ModelClassType IChainReadTalkScrollerView IChainReadTalkScrollerView IChainReadTalkScrollerView Pointer )

            return value;
        }
    }
}
