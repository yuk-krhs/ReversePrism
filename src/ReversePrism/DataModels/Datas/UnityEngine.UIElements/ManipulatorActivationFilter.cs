using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Button                                   000186651110 ModelEnumType MouseButton MouseButton MouseButton Int32
    // 014 Modifiers                                00018675F1A0 ModelEnumType EventModifiers EventModifiers EventModifiers Int32
    // 018 ClickCount                               0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ManipulatorActivationFilter
    {
        public MouseButton                              Button                                  { get; set; }
        public EventModifiers                           Modifiers                               { get; set; }
        public int                                      ClickCount                              { get; set; }

        public static ManipulatorActivationFilter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ManipulatorActivationFilter();

            value.Button                                    = (MouseButton)GetInt32(new IntPtr(p + 0x010)); // 0270066E2F58 0x10 Button                      ( 000186651110 ModelEnumType MouseButton MouseButton MouseButton Int32 )
            value.Modifiers                                 = (EventModifiers)GetInt32(new IntPtr(p + 0x014)); // 0270066E2F78 0x14 Modifiers                   ( 00018675F1A0 ModelEnumType EventModifiers EventModifiers EventModifiers Int32 )
            value.ClickCount                                = GetInt32(new IntPtr(p + 0x018)); // 0270066E2F98 0x18 ClickCount                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
