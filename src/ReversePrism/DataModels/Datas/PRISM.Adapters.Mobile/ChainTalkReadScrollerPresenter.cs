using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IChainReadTalkScrollerView IChainReadTalkScrollerView IChainReadTalkScrollerView Pointer
    // 018 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    public partial class ChainTalkReadScrollerPresenter : DataModel
    {
        public IChainReadTalkScrollerView?              View                                    { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static ChainTalkReadScrollerPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkReadScrollerPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IChainReadTalkScrollerView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IChainReadTalkScrollerView.FromPointer); // 0x10 View                        ( ModelClassType IChainReadTalkScrollerView IChainReadTalkScrollerView IChainReadTalkScrollerView Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x018), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x18 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
