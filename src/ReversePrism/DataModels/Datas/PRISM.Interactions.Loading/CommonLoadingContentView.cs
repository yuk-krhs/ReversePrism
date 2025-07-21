using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MiniCharaView                            ModelClassType LoadingMiniCharaView LoadingMiniCharaView LoadingMiniCharaView Pointer
    // 028 TipsView                                 ModelClassType LoadingTipsView LoadingTipsView LoadingTipsView Pointer
    // 030 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
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

            value.MiniCharaView                             = GetObject<LoadingMiniCharaView>(new IntPtr(p + 0x020), ReversePrism.DataModels.LoadingMiniCharaView.FromPointer); // 0x20 MiniCharaView               ( ModelClassType LoadingMiniCharaView LoadingMiniCharaView LoadingMiniCharaView Pointer )
            value.TipsView                                  = GetObject<LoadingTipsView>(new IntPtr(p + 0x028), ReversePrism.DataModels.LoadingTipsView.FromPointer); // 0x28 TipsView                    ( ModelClassType LoadingTipsView LoadingTipsView LoadingTipsView Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x030), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x30 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
