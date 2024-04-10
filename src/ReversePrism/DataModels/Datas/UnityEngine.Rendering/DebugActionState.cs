using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Type                                   00018657EBC0 ModelEnumType DebugActionKeyType DebugActionKeyType DebugActionKeyType Int32
    // 018 InputAction                              0001865E7E40 ModelClassType InputAction InputAction InputAction Pointer
    // 020 M_TriggerPressedUp                       000185B78CA0 ModelPrimitiveListType bool[] bool[] List<bool> Pointer
    // 028 M_Timer                                  0001866656B0 ModelPrimitiveType float float float Single
    // 02C RunningAction                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 030 ActionState                              0001866656B0 ModelPrimitiveType float float float Single
    public partial class DebugActionState : DataModel
    {
        public DebugActionKeyType                       M_Type                                  { get; set; }
        public InputAction?                             InputAction                             { get; set; }
        public List<bool>?                              M_TriggerPressedUp                      { get; set; }
        public float                                    M_Timer                                 { get; set; }
        public bool                                     RunningAction                           { get; set; }
        public float                                    ActionState                             { get; set; }

        public static DebugActionState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugActionState() { Pointer= p0 };

            value.M_Type                                    = (DebugActionKeyType)GetInt32(new IntPtr(p + 0x010)); // 0246691C6B00 0x10 M_Type                      ( 00018657EBC0 ModelEnumType DebugActionKeyType DebugActionKeyType DebugActionKeyType Int32 )
            value.InputAction                               = GetObject<InputAction>(new IntPtr(p + 0x018), ReversePrism.DataModels.InputAction.FromPointer); // 0246691C6B20 0x18 InputAction                 ( 0001865E7E40 ModelClassType InputAction InputAction InputAction Pointer )
            value.M_TriggerPressedUp                        = GetBoolList(new IntPtr(p + 0x020)); // 0246691C6B40 0x20 M_TriggerPressedUp          ( 000185B78CA0 ModelPrimitiveListType bool[] bool[] List<bool> Pointer )
            value.M_Timer                                   = GetSingle(new IntPtr(p + 0x028)); // 0246691C6B60 0x28 M_Timer                     ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.RunningAction                             = GetBool(new IntPtr(p + 0x02C)); // 0246691C6B80 0x2C RunningAction               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ActionState                               = GetSingle(new IntPtr(p + 0x030)); // 0246691C6BA0 0x30 ActionState                 ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
