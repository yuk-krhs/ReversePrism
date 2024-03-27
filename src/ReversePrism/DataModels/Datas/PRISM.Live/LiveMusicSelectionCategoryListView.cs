using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 SlideAnimation                           00018650BB70 ModelClassType SimpleSlideAnimation SimpleSlideAnimation SimpleSlideAnimation Pointer
    public partial class LiveMusicSelectionCategoryListView
    {
        public SimpleSlideAnimation?                    SlideAnimation                          { get; set; }

        public static LiveMusicSelectionCategoryListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMusicSelectionCategoryListView();

            value.SlideAnimation                            = GetObject<SimpleSlideAnimation>(new IntPtr(p + 0x090), ReversePrism.DataModels.SimpleSlideAnimation.FromPointer); // 0270D51356E8 0x90 SlideAnimation              ( 00018650BB70 ModelClassType SimpleSlideAnimation SimpleSlideAnimation SimpleSlideAnimation Pointer )

            return value;
        }
    }
}
