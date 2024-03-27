using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Format                                   FourCC IL2CPP_TYPE_VALUETYPE
    // 010 LeftStickX                               00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 011 LeftStickY                               00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 012 RightStickX                              00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 013 RightStickY                              00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 014 Buttons1                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 015 Buttons2                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 016 Buttons3                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 017 LeftTrigger                              00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 018 RightTrigger                             00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class DualShock4HIDInputReport
    {
        public sbyte                                    LeftStickX                              { get; set; }
        public sbyte                                    LeftStickY                              { get; set; }
        public sbyte                                    RightStickX                             { get; set; }
        public sbyte                                    RightStickY                             { get; set; }
        public sbyte                                    Buttons1                                { get; set; }
        public sbyte                                    Buttons2                                { get; set; }
        public sbyte                                    Buttons3                                { get; set; }
        public sbyte                                    LeftTrigger                             { get; set; }
        public sbyte                                    RightTrigger                            { get; set; }

        public static DualShock4HIDInputReport? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DualShock4HIDInputReport();

            value.LeftStickX                                = GetSByte(new IntPtr(p + 0x010)); // 0270D77F9668 0x10 LeftStickX                  ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.LeftStickY                                = GetSByte(new IntPtr(p + 0x011)); // 0270D77F9688 0x11 LeftStickY                  ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.RightStickX                               = GetSByte(new IntPtr(p + 0x012)); // 0270D77F96A8 0x12 RightStickX                 ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.RightStickY                               = GetSByte(new IntPtr(p + 0x013)); // 0270D77F96C8 0x13 RightStickY                 ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Buttons1                                  = GetSByte(new IntPtr(p + 0x014)); // 0270D77F96E8 0x14 Buttons1                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Buttons2                                  = GetSByte(new IntPtr(p + 0x015)); // 0270D77F9708 0x15 Buttons2                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Buttons3                                  = GetSByte(new IntPtr(p + 0x016)); // 0270D77F9728 0x16 Buttons3                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.LeftTrigger                               = GetSByte(new IntPtr(p + 0x017)); // 0270D77F9748 0x17 LeftTrigger                 ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.RightTrigger                              = GetSByte(new IntPtr(p + 0x018)); // 0270D77F9768 0x18 RightTrigger                ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
