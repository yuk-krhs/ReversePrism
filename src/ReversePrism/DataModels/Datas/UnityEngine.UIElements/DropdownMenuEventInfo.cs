using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Modifiers                                ModelEnumType EventModifiers EventModifiers EventModifiers Int32
    // 014 MousePosition                            ModelEnumType Vector2 Vector2 Vector2 Int32
    // 01C LocalMousePosition                       ModelEnumType Vector2 Vector2 Vector2 Int32
    // 024 <character>k__BackingField               char IL2CPP_TYPE_CHAR
    // 028 KeyCode                                  ModelEnumType KeyCode KeyCode KeyCode Int32
    public partial class DropdownMenuEventInfo : DataModel
    {
        public EventModifiers                           Modifiers                               { get; set; }
        public Vector2                                  MousePosition                           { get; set; }
        public Vector2                                  LocalMousePosition                      { get; set; }
        public KeyCode                                  KeyCode                                 { get; set; }

        public static DropdownMenuEventInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DropdownMenuEventInfo() { Pointer= p0 };

            value.Modifiers                                 = (EventModifiers)GetInt32(new IntPtr(p + 0x010)); // 0x10 Modifiers                   ( ModelEnumType EventModifiers EventModifiers EventModifiers Int32 )
            value.MousePosition                             = (Vector2)GetInt32(new IntPtr(p + 0x014)); // 0x14 MousePosition               ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.LocalMousePosition                        = (Vector2)GetInt32(new IntPtr(p + 0x01C)); // 0x1C LocalMousePosition          ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.KeyCode                                   = (KeyCode)GetInt32(new IntPtr(p + 0x028)); // 0x28 KeyCode                     ( ModelEnumType KeyCode KeyCode KeyCode Int32 )

            return value;
        }
    }
}
