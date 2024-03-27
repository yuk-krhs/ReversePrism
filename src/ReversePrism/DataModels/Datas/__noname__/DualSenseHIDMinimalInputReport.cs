using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ExpectedSize1                            int IL2CPP_TYPE_I4
    // 004 ExpectedSize2                            int IL2CPP_TYPE_I4
    // 010 ReportId                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 011 LeftStickX                               00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 012 LeftStickY                               00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 013 RightStickX                              00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 014 RightStickY                              00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 015 Buttons0                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 016 Buttons1                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 017 Buttons2                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 018 LeftTrigger                              00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 019 RightTrigger                             00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class DualSenseHIDMinimalInputReport
    {
        public sbyte                                    ReportId                                { get; set; }
        public sbyte                                    LeftStickX                              { get; set; }
        public sbyte                                    LeftStickY                              { get; set; }
        public sbyte                                    RightStickX                             { get; set; }
        public sbyte                                    RightStickY                             { get; set; }
        public sbyte                                    Buttons0                                { get; set; }
        public sbyte                                    Buttons1                                { get; set; }
        public sbyte                                    Buttons2                                { get; set; }
        public sbyte                                    LeftTrigger                             { get; set; }
        public sbyte                                    RightTrigger                            { get; set; }

        public static DualSenseHIDMinimalInputReport? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DualSenseHIDMinimalInputReport();

            value.ReportId                                  = GetSByte(new IntPtr(p + 0x010)); // 0270D77F9170 0x10 ReportId                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.LeftStickX                                = GetSByte(new IntPtr(p + 0x011)); // 0270D77F9190 0x11 LeftStickX                  ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.LeftStickY                                = GetSByte(new IntPtr(p + 0x012)); // 0270D77F91B0 0x12 LeftStickY                  ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.RightStickX                               = GetSByte(new IntPtr(p + 0x013)); // 0270D77F91D0 0x13 RightStickX                 ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.RightStickY                               = GetSByte(new IntPtr(p + 0x014)); // 0270D77F91F0 0x14 RightStickY                 ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Buttons0                                  = GetSByte(new IntPtr(p + 0x015)); // 0270D77F9210 0x15 Buttons0                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Buttons1                                  = GetSByte(new IntPtr(p + 0x016)); // 0270D77F9230 0x16 Buttons1                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Buttons2                                  = GetSByte(new IntPtr(p + 0x017)); // 0270D77F9250 0x17 Buttons2                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.LeftTrigger                               = GetSByte(new IntPtr(p + 0x018)); // 0270D77F9270 0x18 LeftTrigger                 ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.RightTrigger                              = GetSByte(new IntPtr(p + 0x019)); // 0270D77F9290 0x19 RightTrigger                ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
