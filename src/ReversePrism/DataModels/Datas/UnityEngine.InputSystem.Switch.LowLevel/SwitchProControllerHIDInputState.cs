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
    // 014 Buttons1                                 ModelPrimitiveType ushort ushort ushort UInt16
    // 016 Buttons2                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class SwitchProControllerHIDInputState : DataModel
    {
        public sbyte                                    LeftStickX                              { get; set; }
        public sbyte                                    LeftStickY                              { get; set; }
        public sbyte                                    RightStickX                             { get; set; }
        public sbyte                                    RightStickY                             { get; set; }
        public ushort                                   Buttons1                                { get; set; }
        public sbyte                                    Buttons2                                { get; set; }

        public static SwitchProControllerHIDInputState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SwitchProControllerHIDInputState() { Pointer= p0 };

            value.LeftStickX                                = GetSByte(new IntPtr(p + 0x010)); // 0x10 LeftStickX                  ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.LeftStickY                                = GetSByte(new IntPtr(p + 0x011)); // 0x11 LeftStickY                  ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.RightStickX                               = GetSByte(new IntPtr(p + 0x012)); // 0x12 RightStickX                 ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.RightStickY                               = GetSByte(new IntPtr(p + 0x013)); // 0x13 RightStickY                 ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Buttons1                                  = GetUInt16(new IntPtr(p + 0x014)); // 0x14 Buttons1                    ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Buttons2                                  = GetSByte(new IntPtr(p + 0x016)); // 0x16 Buttons2                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
