using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 <SelectedIndex>k__BackingField           ReactiveProperty`1<int> IL2CPP_TYPE_GENERICINST
    // 018 PreviousSelectedIndex                    ModelPrimitiveType int int int Int32
    // 020 <OnCellClicked>k__BackingField           Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 028 ScrollDirection                          ModelEnumType ScrollDirection ScrollDirection ScrollDirection Int32
    // 030 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    public partial class DefaultCarouselContext : DataModel
    {
        public int                                      PreviousSelectedIndex                   { get; set; }
        public ScrollDirection                          ScrollDirection                         { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static DefaultCarouselContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DefaultCarouselContext() { Pointer= p0 };

            value.PreviousSelectedIndex                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 PreviousSelectedIndex       ( ModelPrimitiveType int int int Int32 )
            value.ScrollDirection                           = (ScrollDirection)GetInt32(new IntPtr(p + 0x028)); // 0x28 ScrollDirection             ( ModelEnumType ScrollDirection ScrollDirection ScrollDirection Int32 )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x030), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x30 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
