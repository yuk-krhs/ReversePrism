using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kSize                                    int IL2CPP_TYPE_I4
    // 010 BaseCommand                              0001865ECDD0 ModelEnumType InputDeviceCommand InputDeviceCommand InputDeviceCommand Int32
    // 018 ReportId                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 019 Payload                                  00018670A890 ModelEnumType DualSenseHIDOutputReportPayload DualSenseHIDOutputReportPayload DualSenseHIDOutputReportPayload Int32
    public partial class DualSenseHIDUSBOutputReport
    {
        public InputDeviceCommand                       BaseCommand                             { get; set; }
        public sbyte                                    ReportId                                { get; set; }
        public DualSenseHIDOutputReportPayload          Payload                                 { get; set; }

        public static DualSenseHIDUSBOutputReport? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DualSenseHIDUSBOutputReport();

            value.BaseCommand                               = (InputDeviceCommand)GetInt32(new IntPtr(p + 0x010)); // 0270D77F9978 0x10 BaseCommand                 ( 0001865ECDD0 ModelEnumType InputDeviceCommand InputDeviceCommand InputDeviceCommand Int32 )
            value.ReportId                                  = GetSByte(new IntPtr(p + 0x018)); // 0270D77F9998 0x18 ReportId                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Payload                                   = (DualSenseHIDOutputReportPayload)GetInt32(new IntPtr(p + 0x019)); // 0270D77F99B8 0x19 Payload                     ( 00018670A890 ModelEnumType DualSenseHIDOutputReportPayload DualSenseHIDOutputReportPayload DualSenseHIDOutputReportPayload Int32 )

            return value;
        }
    }
}
