using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OffsetL                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 OffsetH                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 evt_ptr                                  <int> IL2CPP_TYPE_I
    public partial class Overlapped
    {
        public int                                      OffsetL                                 { get; set; }
        public int                                      OffsetH                                 { get; set; }

        public static Overlapped? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Overlapped();

            value.OffsetL                                   = GetInt32(new IntPtr(p + 0x010)); // 0270D6AEEB18 0x10 OffsetL                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OffsetH                                   = GetInt32(new IntPtr(p + 0x014)); // 0270D6AEEB38 0x14 OffsetH                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
