using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 AnnounceBannerLoader                     0001866BD3F0 ModelClassType AnnounceBannerLoader AnnounceBannerLoader AnnounceBannerLoader Pointer
    // 040 ResourceTag                              00018661CBD0 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 048 <OnArticleClicked>k__BackingField        Subject`1<string> IL2CPP_TYPE_GENERICINST
    // 050 <OnMoreClicked>k__BackingField           Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class AnnounceListViewContext : DataModel
    {
        public AnnounceBannerLoader?                    AnnounceBannerLoader                    { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static AnnounceListViewContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnnounceListViewContext() { Pointer= p0 };

            value.AnnounceBannerLoader                      = GetObject<AnnounceBannerLoader>(new IntPtr(p + 0x038), ReversePrism.DataModels.AnnounceBannerLoader.FromPointer); // 02466BE61BE0 0x38 AnnounceBannerLoader        ( 0001866BD3F0 ModelClassType AnnounceBannerLoader AnnounceBannerLoader AnnounceBannerLoader Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x040), ReversePrism.DataModels.IResourceTag.FromPointer); // 02466BE61C00 0x40 ResourceTag                 ( 00018661CBD0 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
