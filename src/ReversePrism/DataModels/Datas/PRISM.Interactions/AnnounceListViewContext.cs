using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 WebTextureLoader                         ModelClassType WebTextureLoader WebTextureLoader WebTextureLoader Pointer
    // 048 <OnArticleClicked>k__BackingField        Subject`1<string> IL2CPP_TYPE_GENERICINST
    // 050 <OnMoreClicked>k__BackingField           Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class AnnounceListViewContext : DataModel
    {
        public WebTextureLoader?                        WebTextureLoader                        { get; set; }

        public static AnnounceListViewContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnnounceListViewContext() { Pointer= p0 };

            value.WebTextureLoader                          = GetObject<WebTextureLoader>(new IntPtr(p + 0x040), ReversePrism.DataModels.WebTextureLoader.FromPointer); // 0x40 WebTextureLoader            ( ModelClassType WebTextureLoader WebTextureLoader WebTextureLoader Pointer )

            return value;
        }
    }
}
