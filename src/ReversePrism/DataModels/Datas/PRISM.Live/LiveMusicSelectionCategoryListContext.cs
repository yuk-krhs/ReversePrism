using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 ItemCount                                0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class LiveMusicSelectionCategoryListContext
    {
        public int                                      ItemCount                               { get; set; }

        public static LiveMusicSelectionCategoryListContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMusicSelectionCategoryListContext();

            value.ItemCount                                 = GetInt32(new IntPtr(p + 0x038)); // 0270D51352E0 0x38 ItemCount                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
