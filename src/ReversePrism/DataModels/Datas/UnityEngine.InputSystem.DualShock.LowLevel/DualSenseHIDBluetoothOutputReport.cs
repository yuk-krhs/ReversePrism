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
    // 019 Tag1                                     ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01A Tag2                                     ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01B Payload                                  ModelEnumType DualSenseHIDOutputReportPayload DualSenseHIDOutputReportPayload DualSenseHIDOutputReportPayload Int32
    // 062 Crc32                                    ModelPrimitiveType uint uint uint UInt32
    // 018 RawData                                  ModelEnumType <rawData>e__FixedBuffer <rawData>e__FixedBuffer <rawData>e__FixedBuffer Int32
    public partial class DualSenseHIDBluetoothOutputReport : DataModel
    {
        public InputDeviceCommand                       BaseCommand                             { get; set; }
        public sbyte                                    ReportId                                { get; set; }
        public sbyte                                    Tag1                                    { get; set; }
        public sbyte                                    Tag2                                    { get; set; }
        public DualSenseHIDOutputReportPayload          Payload                                 { get; set; }
        public uint                                     Crc32                                   { get; set; }
        public <rawData>e__FixedBuffer                  RawData                                 { get; set; }

        public static DualSenseHIDBluetoothOutputReport? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DualSenseHIDBluetoothOutputReport() { Pointer= p0 };

            value.BaseCommand                               = (InputDeviceCommand)GetInt32(new IntPtr(p + 0x010)); // 0x10 BaseCommand                 ( ModelEnumType InputDeviceCommand InputDeviceCommand InputDeviceCommand Int32 )
            value.ReportId                                  = GetSByte(new IntPtr(p + 0x018)); // 0x18 ReportId                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Tag1                                      = GetSByte(new IntPtr(p + 0x019)); // 0x19 Tag1                        ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Tag2                                      = GetSByte(new IntPtr(p + 0x01A)); // 0x1A Tag2                        ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Payload                                   = (DualSenseHIDOutputReportPayload)GetInt32(new IntPtr(p + 0x01B)); // 0x1B Payload                     ( ModelEnumType DualSenseHIDOutputReportPayload DualSenseHIDOutputReportPayload DualSenseHIDOutputReportPayload Int32 )
            value.Crc32                                     = GetUInt32(new IntPtr(p + 0x062)); // 0x62 Crc32                       ( ModelPrimitiveType uint uint uint UInt32 )
            value.RawData                                   = (<rawData>e__FixedBuffer)GetInt32(new IntPtr(p + 0x018)); // 0x18 RawData                     ( ModelEnumType <rawData>e__FixedBuffer <rawData>e__FixedBuffer <rawData>e__FixedBuffer Int32 )

            return value;
        }
    }
}
