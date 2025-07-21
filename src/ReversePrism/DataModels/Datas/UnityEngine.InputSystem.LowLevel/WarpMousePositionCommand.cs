using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kSize                                    int IL2CPP_TYPE_I4
    // 010 BaseCommand                              ModelEnumType InputDeviceCommand InputDeviceCommand InputDeviceCommand Int32
    // 018 WarpPositionInPlayerDisplaySpace         ModelEnumType Vector2 Vector2 Vector2 Int32
    public partial class WarpMousePositionCommand : DataModel
    {
        public InputDeviceCommand                       BaseCommand                             { get; set; }
        public Vector2                                  WarpPositionInPlayerDisplaySpace        { get; set; }

        public static WarpMousePositionCommand? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WarpMousePositionCommand() { Pointer= p0 };

            value.BaseCommand                               = (InputDeviceCommand)GetInt32(new IntPtr(p + 0x010)); // 0x10 BaseCommand                 ( ModelEnumType InputDeviceCommand InputDeviceCommand InputDeviceCommand Int32 )
            value.WarpPositionInPlayerDisplaySpace          = (Vector2)GetInt32(new IntPtr(p + 0x018)); // 0x18 WarpPositionInPlayerDisplaySpace ( ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
