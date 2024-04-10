using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MiniCharaView                            00018659E6C0 ModelClassType LoadingMiniCharaView LoadingMiniCharaView LoadingMiniCharaView Pointer
    // 028 TipsView                                 00018659FA60 ModelClassType LoadingTipsView LoadingTipsView LoadingTipsView Pointer
    // 030 ResourceLoader                           00018661A8D0 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    public partial class CommonLoadingContentView : DataModel
    {
        public LoadingMiniCharaView?                    MiniCharaView                           { get; set; }
        public LoadingTipsView?                         TipsView                                { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static CommonLoadingContentView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CommonLoadingContentView() { Pointer= p0 };

            value.MiniCharaView                             = GetObject<LoadingMiniCharaView>(new IntPtr(p + 0x020), ReversePrism.DataModels.LoadingMiniCharaView.FromPointer); // 0245A1EA07B8 0x20 MiniCharaView               ( 00018659E6C0 ModelClassType LoadingMiniCharaView LoadingMiniCharaView LoadingMiniCharaView Pointer )
            value.TipsView                                  = GetObject<LoadingTipsView>(new IntPtr(p + 0x028), ReversePrism.DataModels.LoadingTipsView.FromPointer); // 0245A1EA07D8 0x28 TipsView                    ( 00018659FA60 ModelClassType LoadingTipsView LoadingTipsView LoadingTipsView Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x030), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0245A1EA07F8 0x30 ResourceLoader              ( 00018661A8D0 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
