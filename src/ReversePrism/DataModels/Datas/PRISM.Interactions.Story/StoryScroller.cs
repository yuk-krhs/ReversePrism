using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ScrollRect                               0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    public partial class StoryScroller
    {
        public ScrollRect?                              ScrollRect                              { get; set; }

        public static StoryScroller? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryScroller();

            value.ScrollRect                                = GetObject<ScrollRect>(new IntPtr(p + 0x020), ReversePrism.DataModels.ScrollRect.FromPointer); // 0270DB948220 0x20 ScrollRect                  ( 0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer )

            return value;
        }
    }
}
