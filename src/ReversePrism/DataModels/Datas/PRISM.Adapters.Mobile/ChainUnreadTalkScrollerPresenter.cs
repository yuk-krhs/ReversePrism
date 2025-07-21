using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IChainUnreadTalkScrollerView IChainUnreadTalkScrollerView IChainUnreadTalkScrollerView Pointer
    // 018 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    public partial class ChainUnreadTalkScrollerPresenter : DataModel
    {
        public IChainUnreadTalkScrollerView?            View                                    { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static ChainUnreadTalkScrollerPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainUnreadTalkScrollerPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IChainUnreadTalkScrollerView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IChainUnreadTalkScrollerView.FromPointer); // 0x10 View                        ( ModelClassType IChainUnreadTalkScrollerView IChainUnreadTalkScrollerView IChainUnreadTalkScrollerView Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x018), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x18 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
