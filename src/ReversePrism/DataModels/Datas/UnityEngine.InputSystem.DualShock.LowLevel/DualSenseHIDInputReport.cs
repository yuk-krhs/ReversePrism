using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Format                                   FourCC IL2CPP_TYPE_VALUETYPE
    // 010 LeftStickX                               ModelPrimitiveType sbyte sbyte sbyte SByte
    // 011 LeftStickY                               ModelPrimitiveType sbyte sbyte sbyte SByte
    // 012 RightStickX                              ModelPrimitiveType sbyte sbyte sbyte SByte
    // 013 RightStickY                              ModelPrimitiveType sbyte sbyte sbyte SByte
    // 014 LeftTrigger                              ModelPrimitiveType sbyte sbyte sbyte SByte
    // 015 RightTrigger                             ModelPrimitiveType sbyte sbyte sbyte SByte
    // 016 Buttons0                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 017 Buttons1                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 018 Buttons2                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class DualSenseHIDInputReport : DataModel
    {
        public sbyte                                    LeftStickX                              { get; set; }
        public sbyte                                    LeftStickY                              { get; set; }
        public sbyte                                    RightStickX                             { get; set; }
        public sbyte                                    RightStickY                             { get; set; }
        public sbyte                                    LeftTrigger                             { get; set; }
        public sbyte                                    RightTrigger                            { get; set; }
        public sbyte                                    Buttons0                                { get; set; }
        public sbyte                                    Buttons1                                { get; set; }
        public sbyte                                    Buttons2                                { get; set; }

        public static DualSenseHIDInputReport? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DualSenseHIDInputReport() { Pointer= p0 };

            value.LeftStickX                                = GetSByte(new IntPtr(p + 0x010)); // 0x10 LeftStickX                  ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.LeftStickY                                = GetSByte(new IntPtr(p + 0x011)); // 0x11 LeftStickY                  ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.RightStickX                               = GetSByte(new IntPtr(p + 0x012)); // 0x12 RightStickX                 ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.RightStickY                               = GetSByte(new IntPtr(p + 0x013)); // 0x13 RightStickY                 ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.LeftTrigger                               = GetSByte(new IntPtr(p + 0x014)); // 0x14 LeftTrigger                 ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.RightTrigger                              = GetSByte(new IntPtr(p + 0x015)); // 0x15 RightTrigger                ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Buttons0                                  = GetSByte(new IntPtr(p + 0x016)); // 0x16 Buttons0                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Buttons1                                  = GetSByte(new IntPtr(p + 0x017)); // 0x17 Buttons1                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Buttons2                                  = GetSByte(new IntPtr(p + 0x018)); // 0x18 Buttons2                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
