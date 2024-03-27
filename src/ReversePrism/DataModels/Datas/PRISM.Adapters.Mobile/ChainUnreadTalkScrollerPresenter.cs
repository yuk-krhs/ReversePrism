using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     00018671FD50 ModelClassType IChainUnreadTalkScrollerView IChainUnreadTalkScrollerView IChainUnreadTalkScrollerView Pointer
    public partial class ChainUnreadTalkScrollerPresenter
    {
        public IChainUnreadTalkScrollerView?            View                                    { get; set; }

        public static ChainUnreadTalkScrollerPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainUnreadTalkScrollerPresenter();

            value.View                                      = GetObject<IChainUnreadTalkScrollerView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IChainUnreadTalkScrollerView.FromPointer); // 0270D686E970 0x10 View                        ( 00018671FD50 ModelClassType IChainUnreadTalkScrollerView IChainUnreadTalkScrollerView IChainUnreadTalkScrollerView Pointer )

            return value;
        }
    }
}
