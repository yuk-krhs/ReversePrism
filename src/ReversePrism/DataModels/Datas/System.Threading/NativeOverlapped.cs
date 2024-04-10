using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 InternalLow                              <int> IL2CPP_TYPE_I
    // 018 InternalHigh                             <int> IL2CPP_TYPE_I
    // 020 OffsetLow                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 OffsetHigh                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 EventHandle                              <int> IL2CPP_TYPE_I
    public partial class NativeOverlapped : DataModel
    {
        public int                                      OffsetLow                               { get; set; }
        public int                                      OffsetHigh                              { get; set; }

        public static NativeOverlapped? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeOverlapped() { Pointer= p0 };

            value.OffsetLow                                 = GetInt32(new IntPtr(p + 0x020)); // 024666B25140 0x20 OffsetLow                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.OffsetHigh                                = GetInt32(new IntPtr(p + 0x024)); // 024666B25160 0x24 OffsetHigh                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
