using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Offset0000                               00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 020 Offset0016                               00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    public partial class FixedBytes32Align8
    {
        public FixedBytes16Align8                       Offset0000                              { get; set; }
        public FixedBytes16Align8                       Offset0016                              { get; set; }

        public static FixedBytes32Align8? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FixedBytes32Align8();

            value.Offset0000                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x010)); // 02700355FD08 0x10 Offset0000                  ( 00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0016                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x020)); // 02700355FD28 0x20 Offset0016                  ( 00018659C1C0 ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )

            return value;
        }
    }
}
