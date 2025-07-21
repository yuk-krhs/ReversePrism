using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EventType                                ModelPrimitiveType short short short Int16
    // 012 KeyDown                                  ModelPrimitiveType bool bool bool Bool
    // 014 RepeatCount                              ModelPrimitiveType short short short Int16
    // 016 VirtualKeyCode                           ModelPrimitiveType short short short Int16
    // 018 VirtualScanCode                          ModelPrimitiveType short short short Int16
    // 01A Character                                char IL2CPP_TYPE_CHAR
    // 01C ControlKeyState                          ModelPrimitiveType int int int Int32
    // 020 Pad1                                     ModelPrimitiveType int int int Int32
    // 024 Pad2                                     ModelPrimitiveType bool bool bool Bool
    public partial class InputRecord : DataModel
    {
        public short                                    EventType                               { get; set; }
        public bool                                     KeyDown                                 { get; set; }
        public short                                    RepeatCount                             { get; set; }
        public short                                    VirtualKeyCode                          { get; set; }
        public short                                    VirtualScanCode                         { get; set; }
        public int                                      ControlKeyState                         { get; set; }
        public int                                      Pad1                                    { get; set; }
        public bool                                     Pad2                                    { get; set; }

        public static InputRecord? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputRecord() { Pointer= p0 };

            value.EventType                                 = GetInt16(new IntPtr(p + 0x010)); // 0x10 EventType                   ( ModelPrimitiveType short short short Int16 )
            value.KeyDown                                   = GetBool(new IntPtr(p + 0x012)); // 0x12 KeyDown                     ( ModelPrimitiveType bool bool bool Bool )
            value.RepeatCount                               = GetInt16(new IntPtr(p + 0x014)); // 0x14 RepeatCount                 ( ModelPrimitiveType short short short Int16 )
            value.VirtualKeyCode                            = GetInt16(new IntPtr(p + 0x016)); // 0x16 VirtualKeyCode              ( ModelPrimitiveType short short short Int16 )
            value.VirtualScanCode                           = GetInt16(new IntPtr(p + 0x018)); // 0x18 VirtualScanCode             ( ModelPrimitiveType short short short Int16 )
            value.ControlKeyState                           = GetInt32(new IntPtr(p + 0x01C)); // 0x1C ControlKeyState             ( ModelPrimitiveType int int int Int32 )
            value.Pad1                                      = GetInt32(new IntPtr(p + 0x020)); // 0x20 Pad1                        ( ModelPrimitiveType int int int Int32 )
            value.Pad2                                      = GetBool(new IntPtr(p + 0x024)); // 0x24 Pad2                        ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
