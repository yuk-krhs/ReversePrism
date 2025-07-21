using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kSize                                    int IL2CPP_TYPE_I4
    // 010 BaseCommand                              ModelEnumType InputDeviceCommand InputDeviceCommand InputDeviceCommand Int32
    // 018 ReportId                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 019 Payload                                  ModelEnumType DualSenseHIDOutputReportPayload DualSenseHIDOutputReportPayload DualSenseHIDOutputReportPayload Int32
    public partial class DualSenseHIDUSBOutputReport : DataModel
    {
        public InputDeviceCommand                       BaseCommand                             { get; set; }
        public sbyte                                    ReportId                                { get; set; }
        public DualSenseHIDOutputReportPayload          Payload                                 { get; set; }

        public static DualSenseHIDUSBOutputReport? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DualSenseHIDUSBOutputReport() { Pointer= p0 };

            value.BaseCommand                               = (InputDeviceCommand)GetInt32(new IntPtr(p + 0x010)); // 0x10 BaseCommand                 ( ModelEnumType InputDeviceCommand InputDeviceCommand InputDeviceCommand Int32 )
            value.ReportId                                  = GetSByte(new IntPtr(p + 0x018)); // 0x18 ReportId                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Payload                                   = (DualSenseHIDOutputReportPayload)GetInt32(new IntPtr(p + 0x019)); // 0x19 Payload                     ( ModelEnumType DualSenseHIDOutputReportPayload DualSenseHIDOutputReportPayload DualSenseHIDOutputReportPayload Int32 )

            return value;
        }
    }
}
