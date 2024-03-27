using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 preWillRenderCanvases                    WillRenderCanvases IL2CPP_TYPE_CLASS
    // 008 willRenderCanvases                       WillRenderCanvases IL2CPP_TYPE_CLASS
    // 010 <externBeginRenderOverlays>k__BackingField Action`1<int> IL2CPP_TYPE_GENERICINST
    // 018 <externRenderOverlaysBefore>k__BackingField Action`2<int, int> IL2CPP_TYPE_GENERICINST
    // 020 <externEndRenderOverlays>k__BackingField Action`1<int> IL2CPP_TYPE_GENERICINST
    public partial class Canvas
    {

        public static Canvas? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Canvas();


            return value;
        }
    }
}
