using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Model                                    0001866BAE90 ModelClassType HomeBannerModel HomeBannerModel HomeBannerModel Pointer
    public partial class HomeBannerViewModel : DataModel
    {
        public HomeBannerModel?                         Model                                   { get; set; }

        public static HomeBannerViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeBannerViewModel() { Pointer= p0 };

            value.Model                                     = GetObject<HomeBannerModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.HomeBannerModel.FromPointer); // 0245A5EAC8C8 0x10 Model                       ( 0001866BAE90 ModelClassType HomeBannerModel HomeBannerModel HomeBannerModel Pointer )

            return value;
        }
    }
}
