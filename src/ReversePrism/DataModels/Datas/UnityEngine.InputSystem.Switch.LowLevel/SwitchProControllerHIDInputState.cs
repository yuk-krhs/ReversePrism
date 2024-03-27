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
    // 014 Buttons1                                 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 016 Buttons2                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class SwitchProControllerHIDInputState
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
            var value   = new SwitchProControllerHIDInputState();

            value.LeftStickX                                = GetSByte(new IntPtr(p + 0x010)); // 0270D77BB5E8 0x10 LeftStickX                  ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.LeftStickY                                = GetSByte(new IntPtr(p + 0x011)); // 0270D77BB608 0x11 LeftStickY                  ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.RightStickX                               = GetSByte(new IntPtr(p + 0x012)); // 0270D77BB628 0x12 RightStickX                 ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.RightStickY                               = GetSByte(new IntPtr(p + 0x013)); // 0270D77BB648 0x13 RightStickY                 ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Buttons1                                  = GetUInt16(new IntPtr(p + 0x014)); // 0270D77BB668 0x14 Buttons1                    ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Buttons2                                  = GetSByte(new IntPtr(p + 0x016)); // 0270D77BB688 0x16 Buttons2                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
