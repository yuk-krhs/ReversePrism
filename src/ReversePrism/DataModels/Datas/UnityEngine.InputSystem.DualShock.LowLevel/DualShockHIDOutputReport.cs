using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kSize                                    int IL2CPP_TYPE_I4
    // 000 kReportId                                int IL2CPP_TYPE_I4
    // 010 BaseCommand                              0001865ECDD0 ModelEnumType InputDeviceCommand InputDeviceCommand InputDeviceCommand Int32
    // 018 ReportId                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 019 Flags                                    00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01A Unknown1                                 0001865C7310 ModelEnumType <unknown1>e__FixedBuffer <unknown1>e__FixedBuffer <unknown1>e__FixedBuffer Int32
    // 01C HighFrequencyMotorSpeed                  00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01D LowFrequencyMotorSpeed                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01E RedColor                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01F GreenColor                               00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 020 BlueColor                                00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 021 Unknown2                                 0001865C7810 ModelEnumType <unknown2>e__FixedBuffer <unknown2>e__FixedBuffer <unknown2>e__FixedBuffer Int32
    public partial class DualShockHIDOutputReport
    {
        public InputDeviceCommand                       BaseCommand                             { get; set; }
        public sbyte                                    ReportId                                { get; set; }
        public sbyte                                    Flags                                   { get; set; }
        public <unknown1>e__FixedBuffer                 Unknown1                                { get; set; }
        public sbyte                                    HighFrequencyMotorSpeed                 { get; set; }
        public sbyte                                    LowFrequencyMotorSpeed                  { get; set; }
        public sbyte                                    RedColor                                { get; set; }
        public sbyte                                    GreenColor                              { get; set; }
        public sbyte                                    BlueColor                               { get; set; }
        public <unknown2>e__FixedBuffer                 Unknown2                                { get; set; }

        public static DualShockHIDOutputReport? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DualShockHIDOutputReport();

            value.BaseCommand                               = (InputDeviceCommand)GetInt32(new IntPtr(p + 0x010)); // 0270D77FA380 0x10 BaseCommand                 ( 0001865ECDD0 ModelEnumType InputDeviceCommand InputDeviceCommand InputDeviceCommand Int32 )
            value.ReportId                                  = GetSByte(new IntPtr(p + 0x018)); // 0270D77FA3A0 0x18 ReportId                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Flags                                     = GetSByte(new IntPtr(p + 0x019)); // 0270D77FA3C0 0x19 Flags                       ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Unknown1                                  = (<unknown1>e__FixedBuffer)GetInt32(new IntPtr(p + 0x01A)); // 0270D77FA3E0 0x1A Unknown1                    ( 0001865C7310 ModelEnumType <unknown1>e__FixedBuffer <unknown1>e__FixedBuffer <unknown1>e__FixedBuffer Int32 )
            value.HighFrequencyMotorSpeed                   = GetSByte(new IntPtr(p + 0x01C)); // 0270D77FA400 0x1C HighFrequencyMotorSpeed     ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.LowFrequencyMotorSpeed                    = GetSByte(new IntPtr(p + 0x01D)); // 0270D77FA420 0x1D LowFrequencyMotorSpeed      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.RedColor                                  = GetSByte(new IntPtr(p + 0x01E)); // 0270D77FA440 0x1E RedColor                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.GreenColor                                = GetSByte(new IntPtr(p + 0x01F)); // 0270D77FA460 0x1F GreenColor                  ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.BlueColor                                 = GetSByte(new IntPtr(p + 0x020)); // 0270D77FA480 0x20 BlueColor                   ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Unknown2                                  = (<unknown2>e__FixedBuffer)GetInt32(new IntPtr(p + 0x021)); // 0270D77FA4A0 0x21 Unknown2                    ( 0001865C7810 ModelEnumType <unknown2>e__FixedBuffer <unknown2>e__FixedBuffer <unknown2>e__FixedBuffer Int32 )

            return value;
        }
    }
}
