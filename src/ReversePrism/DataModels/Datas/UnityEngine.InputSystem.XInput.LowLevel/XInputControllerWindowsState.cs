using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Buttons                                  000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 012 LeftTrigger                              00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 013 RightTrigger                             00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 014 LeftStickX                               0001865F1520 ModelPrimitiveType short short short Int16
    // 016 LeftStickY                               0001865F1520 ModelPrimitiveType short short short Int16
    // 018 RightStickX                              0001865F1520 ModelPrimitiveType short short short Int16
    // 01A RightStickY                              0001865F1520 ModelPrimitiveType short short short Int16
    public partial class XInputControllerWindowsState : DataModel
    {
        public ushort                                   Buttons                                 { get; set; }
        public sbyte                                    LeftTrigger                             { get; set; }
        public sbyte                                    RightTrigger                            { get; set; }
        public short                                    LeftStickX                              { get; set; }
        public short                                    LeftStickY                              { get; set; }
        public short                                    RightStickX                             { get; set; }
        public short                                    RightStickY                             { get; set; }

        public static XInputControllerWindowsState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XInputControllerWindowsState() { Pointer= p0 };

            value.Buttons                                   = GetUInt16(new IntPtr(p + 0x010)); // 0246677DF228 0x10 Buttons                     ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.LeftTrigger                               = GetSByte(new IntPtr(p + 0x012)); // 0246677DF248 0x12 LeftTrigger                 ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.RightTrigger                              = GetSByte(new IntPtr(p + 0x013)); // 0246677DF268 0x13 RightTrigger                ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.LeftStickX                                = GetInt16(new IntPtr(p + 0x014)); // 0246677DF288 0x14 LeftStickX                  ( 0001865F1520 ModelPrimitiveType short short short Int16 )
            value.LeftStickY                                = GetInt16(new IntPtr(p + 0x016)); // 0246677DF2A8 0x16 LeftStickY                  ( 0001865F1520 ModelPrimitiveType short short short Int16 )
            value.RightStickX                               = GetInt16(new IntPtr(p + 0x018)); // 0246677DF2C8 0x18 RightStickX                 ( 0001865F1520 ModelPrimitiveType short short short Int16 )
            value.RightStickY                               = GetInt16(new IntPtr(p + 0x01A)); // 0246677DF2E8 0x1A RightStickY                 ( 0001865F1520 ModelPrimitiveType short short short Int16 )

            return value;
        }
    }
}
