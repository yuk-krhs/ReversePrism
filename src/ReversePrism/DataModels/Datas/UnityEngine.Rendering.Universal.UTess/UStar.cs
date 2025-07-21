using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 points                                   ArraySlice`1<int> IL2CPP_TYPE_GENERICINST
    // 020 PointCount                               ModelPrimitiveType int int int Int32
    public partial class UStar : DataModel
    {
        public int                                      PointCount                              { get; set; }

        public static UStar? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UStar() { Pointer= p0 };

            value.PointCount                                = GetInt32(new IntPtr(p + 0x020)); // 0x20 PointCount                  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
