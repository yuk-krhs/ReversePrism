using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Buttons                                  ModelPrimitiveType ushort ushort ushort UInt16
    // 012 LeftTrigger                              ModelPrimitiveType sbyte sbyte sbyte SByte
    // 013 RightTrigger                             ModelPrimitiveType sbyte sbyte sbyte SByte
    // 014 LeftStickX                               ModelPrimitiveType short short short Int16
    // 016 LeftStickY                               ModelPrimitiveType short short short Int16
    // 018 RightStickX                              ModelPrimitiveType short short short Int16
    // 01A RightStickY                              ModelPrimitiveType short short short Int16
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

            value.Buttons                                   = GetUInt16(new IntPtr(p + 0x010)); // 0x10 Buttons                     ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.LeftTrigger                               = GetSByte(new IntPtr(p + 0x012)); // 0x12 LeftTrigger                 ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.RightTrigger                              = GetSByte(new IntPtr(p + 0x013)); // 0x13 RightTrigger                ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.LeftStickX                                = GetInt16(new IntPtr(p + 0x014)); // 0x14 LeftStickX                  ( ModelPrimitiveType short short short Int16 )
            value.LeftStickY                                = GetInt16(new IntPtr(p + 0x016)); // 0x16 LeftStickY                  ( ModelPrimitiveType short short short Int16 )
            value.RightStickX                               = GetInt16(new IntPtr(p + 0x018)); // 0x18 RightStickX                 ( ModelPrimitiveType short short short Int16 )
            value.RightStickY                               = GetInt16(new IntPtr(p + 0x01A)); // 0x1A RightStickY                 ( ModelPrimitiveType short short short Int16 )

            return value;
        }
    }
}
