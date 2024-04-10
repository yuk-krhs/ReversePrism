using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kSize                                    int IL2CPP_TYPE_I4
    // 010 BaseCommand                              0001865ECDD0 ModelEnumType InputDeviceCommand InputDeviceCommand InputDeviceCommand Int32
    // 018 M_Position                               0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    public partial class SetIMECursorPositionCommand : DataModel
    {
        public InputDeviceCommand                       BaseCommand                             { get; set; }
        public Vector2                                  M_Position                              { get; set; }

        public static SetIMECursorPositionCommand? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SetIMECursorPositionCommand() { Pointer= p0 };

            value.BaseCommand                               = (InputDeviceCommand)GetInt32(new IntPtr(p + 0x010)); // 024667854B70 0x10 BaseCommand                 ( 0001865ECDD0 ModelEnumType InputDeviceCommand InputDeviceCommand InputDeviceCommand Int32 )
            value.M_Position                                = (Vector2)GetInt32(new IntPtr(p + 0x018)); // 024667854B90 0x18 M_Position                  ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
