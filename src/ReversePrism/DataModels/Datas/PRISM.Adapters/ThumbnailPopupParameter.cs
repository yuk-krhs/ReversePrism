using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 018 AssetKey                                 000186672F10 ModelPrimitiveType string string string String
    public partial class ThumbnailPopupParameter
    {
        public IResourceTag?                            ResourceTag                             { get; set; }
        public string                                   AssetKey                                { get; set; }

        public static ThumbnailPopupParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ThumbnailPopupParameter();

            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x010), ReversePrism.DataModels.IResourceTag.FromPointer); // 0270D61D9630 0x10 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )
            value.AssetKey                                  = GetString(new IntPtr(p + 0x018)); // 0270D61D9650 0x18 AssetKey                    ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
