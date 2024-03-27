using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ButtonAction                             0001865E80A0 ModelClassType InputAction InputAction InputAction Pointer
    // 018 RepeatMode                               00018669ACD0 ModelEnumType DebugActionRepeatMode DebugActionRepeatMode DebugActionRepeatMode Int32
    // 01C RepeatDelay                              000186666050 ModelPrimitiveType float float float Single
    public partial class DebugActionDesc
    {
        public InputAction?                             ButtonAction                            { get; set; }
        public DebugActionRepeatMode                    RepeatMode                              { get; set; }
        public float                                    RepeatDelay                             { get; set; }

        public static DebugActionDesc? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugActionDesc();

            value.ButtonAction                              = GetObject<InputAction>(new IntPtr(p + 0x010), ReversePrism.DataModels.InputAction.FromPointer); // 0270D9163548 0x10 ButtonAction                ( 0001865E80A0 ModelClassType InputAction InputAction InputAction Pointer )
            value.RepeatMode                                = (DebugActionRepeatMode)GetInt32(new IntPtr(p + 0x018)); // 0270D9163568 0x18 RepeatMode                  ( 00018669ACD0 ModelEnumType DebugActionRepeatMode DebugActionRepeatMode DebugActionRepeatMode Int32 )
            value.RepeatDelay                               = GetSingle(new IntPtr(p + 0x01C)); // 0270D9163588 0x1C RepeatDelay                 ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
