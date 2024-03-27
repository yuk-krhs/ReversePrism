using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ExpectedReportId                         int IL2CPP_TYPE_I4
    // 010 ReportId                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 012 LeftStickX                               00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 013 LeftStickY                               00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 014 RightStickX                              00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 015 RightStickY                              00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 016 LeftTrigger                              00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 017 RightTrigger                             00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 019 Buttons0                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01A Buttons1                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01B Buttons2                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class DualSenseHIDBluetoothInputReport
    {
        public sbyte                                    ReportId                                { get; set; }
        public sbyte                                    LeftStickX                              { get; set; }
        public sbyte                                    LeftStickY                              { get; set; }
        public sbyte                                    RightStickX                             { get; set; }
        public sbyte                                    RightStickY                             { get; set; }
        public sbyte                                    LeftTrigger                             { get; set; }
        public sbyte                                    RightTrigger                            { get; set; }
        public sbyte                                    Buttons0                                { get; set; }
        public sbyte                                    Buttons1                                { get; set; }
        public sbyte                                    Buttons2                                { get; set; }

        public static DualSenseHIDBluetoothInputReport? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DualSenseHIDBluetoothInputReport();

            value.ReportId                                  = GetSByte(new IntPtr(p + 0x010)); // 0270D77F8F90 0x10 ReportId                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.LeftStickX                                = GetSByte(new IntPtr(p + 0x012)); // 0270D77F8FB0 0x12 LeftStickX                  ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.LeftStickY                                = GetSByte(new IntPtr(p + 0x013)); // 0270D77F8FD0 0x13 LeftStickY                  ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.RightStickX                               = GetSByte(new IntPtr(p + 0x014)); // 0270D77F8FF0 0x14 RightStickX                 ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.RightStickY                               = GetSByte(new IntPtr(p + 0x015)); // 0270D77F9010 0x15 RightStickY                 ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.LeftTrigger                               = GetSByte(new IntPtr(p + 0x016)); // 0270D77F9030 0x16 LeftTrigger                 ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.RightTrigger                              = GetSByte(new IntPtr(p + 0x017)); // 0270D77F9050 0x17 RightTrigger                ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Buttons0                                  = GetSByte(new IntPtr(p + 0x019)); // 0270D77F9070 0x19 Buttons0                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Buttons1                                  = GetSByte(new IntPtr(p + 0x01A)); // 0270D77F9090 0x1A Buttons1                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Buttons2                                  = GetSByte(new IntPtr(p + 0x01B)); // 0270D77F90B0 0x1B Buttons2                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
