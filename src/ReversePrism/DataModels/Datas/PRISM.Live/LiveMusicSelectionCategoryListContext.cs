using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 ItemCount                                ModelPrimitiveType int int int Int32
    public partial class LiveMusicSelectionCategoryListContext : DataModel
    {
        public int                                      ItemCount                               { get; set; }

        public static LiveMusicSelectionCategoryListContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMusicSelectionCategoryListContext() { Pointer= p0 };

            value.ItemCount                                 = GetInt32(new IntPtr(p + 0x040)); // 0x40 ItemCount                   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
