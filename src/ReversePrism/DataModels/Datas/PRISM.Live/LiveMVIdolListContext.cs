using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 SelectedCharacterId                      ReactiveProperty`1<int> IL2CPP_TYPE_GENERICINST
    // 040 ItemCount                                0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class LiveMVIdolListContext
    {
        public int                                      ItemCount                               { get; set; }

        public static LiveMVIdolListContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMVIdolListContext();

            value.ItemCount                                 = GetInt32(new IntPtr(p + 0x040)); // 0270D51B5BD0 0x40 ItemCount                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
