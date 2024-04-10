using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Padding1                                 000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16
    // 012 Buttons1                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 013 Buttons2                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 014 Buttons3                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 015 Padding2                                 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 016 LeftStickX                               00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 017 LeftStickY                               00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 018 RightStickX                              00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 019 RightStickY                              00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01A Padding3                                 0001865C6BE0 ModelEnumType <padding3>e__FixedBuffer <padding3>e__FixedBuffer <padding3>e__FixedBuffer Int32
    // 022 LeftTrigger                              00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 023 RightTrigger                             00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class DualShock3HIDInputReport : DataModel
    {
        public ushort                                   Padding1                                { get; set; }
        public sbyte                                    Buttons1                                { get; set; }
        public sbyte                                    Buttons2                                { get; set; }
        public sbyte                                    Buttons3                                { get; set; }
        public sbyte                                    Padding2                                { get; set; }
        public sbyte                                    LeftStickX                              { get; set; }
        public sbyte                                    LeftStickY                              { get; set; }
        public sbyte                                    RightStickX                             { get; set; }
        public sbyte                                    RightStickY                             { get; set; }
        public <padding3>e__FixedBuffer                 Padding3                                { get; set; }
        public sbyte                                    LeftTrigger                             { get; set; }
        public sbyte                                    RightTrigger                            { get; set; }

        public static DualShock3HIDInputReport? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DualShock3HIDInputReport() { Pointer= p0 };

            value.Padding1                                  = GetUInt16(new IntPtr(p + 0x010)); // 024667851E88 0x10 Padding1                    ( 000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Buttons1                                  = GetSByte(new IntPtr(p + 0x012)); // 024667851EA8 0x12 Buttons1                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Buttons2                                  = GetSByte(new IntPtr(p + 0x013)); // 024667851EC8 0x13 Buttons2                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Buttons3                                  = GetSByte(new IntPtr(p + 0x014)); // 024667851EE8 0x14 Buttons3                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Padding2                                  = GetSByte(new IntPtr(p + 0x015)); // 024667851F08 0x15 Padding2                    ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.LeftStickX                                = GetSByte(new IntPtr(p + 0x016)); // 024667851F28 0x16 LeftStickX                  ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.LeftStickY                                = GetSByte(new IntPtr(p + 0x017)); // 024667851F48 0x17 LeftStickY                  ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.RightStickX                               = GetSByte(new IntPtr(p + 0x018)); // 024667851F68 0x18 RightStickX                 ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.RightStickY                               = GetSByte(new IntPtr(p + 0x019)); // 024667851F88 0x19 RightStickY                 ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Padding3                                  = (<padding3>e__FixedBuffer)GetInt32(new IntPtr(p + 0x01A)); // 024667851FA8 0x1A Padding3                    ( 0001865C6BE0 ModelEnumType <padding3>e__FixedBuffer <padding3>e__FixedBuffer <padding3>e__FixedBuffer Int32 )
            value.LeftTrigger                               = GetSByte(new IntPtr(p + 0x022)); // 024667851FC8 0x22 LeftTrigger                 ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.RightTrigger                              = GetSByte(new IntPtr(p + 0x023)); // 024667851FE8 0x23 RightTrigger                ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
