using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ReportId                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class DualSenseHIDGenericInputReport
    {
        public sbyte                                    ReportId                                { get; set; }

        public static DualSenseHIDGenericInputReport? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DualSenseHIDGenericInputReport();

            value.ReportId                                  = GetSByte(new IntPtr(p + 0x010)); // 0270D77F8AD0 0x10 ReportId                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
