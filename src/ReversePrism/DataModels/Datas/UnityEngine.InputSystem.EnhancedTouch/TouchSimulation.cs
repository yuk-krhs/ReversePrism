using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SimulatedTouchscreen                     0001866950C0 ModelClassType Touchscreen Touchscreen Touchscreen Pointer
    // 028 M_NumPointers                            0001865F5290 ModelPrimitiveType int int int Int32
    // 030 M_Pointers                               000185B9BB60 ModelClassListType Pointer[] Pointer[] List<Pointer> Pointer
    // 038 M_CurrentPositions                       000185CB0928 ModelEnumListType Vector2[] Vector2[] List<Vector2> Pointer
    // 040 M_CurrentDisplayIndices                  000185B7DFD0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 048 M_Touches                                000185B72160 ModelClassListType ButtonControl[] ButtonControl[] List<ButtonControl> Pointer
    // 050 M_LastTouchId                            0001865F5290 ModelPrimitiveType int int int Int32
    // 054 M_PrimaryTouchIndex                      0001865F5290 ModelPrimitiveType int int int Int32
    // 058 m_OnDeviceChange                         Action`2<InputDevice, InputDeviceChange> IL2CPP_TYPE_GENERICINST
    // 060 m_OnEvent                                Action`2<InputEventPtr, InputDevice> IL2CPP_TYPE_GENERICINST
    // 000 s_Instance                               TouchSimulation IL2CPP_TYPE_CLASS
    public partial class TouchSimulation
    {
        public Touchscreen?                             SimulatedTouchscreen                    { get; set; }
        public int                                      M_NumPointers                           { get; set; }
        public List<Pointer>?                           M_Pointers                              { get; set; }
        public List<Vector2>?                           M_CurrentPositions                      { get; set; }
        public List<int>?                               M_CurrentDisplayIndices                 { get; set; }
        public List<ButtonControl>?                     M_Touches                               { get; set; }
        public int                                      M_LastTouchId                           { get; set; }
        public int                                      M_PrimaryTouchIndex                     { get; set; }

        public static TouchSimulation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TouchSimulation();

            value.SimulatedTouchscreen                      = GetObject<Touchscreen>(new IntPtr(p + 0x020), ReversePrism.DataModels.Touchscreen.FromPointer); // 0270D77F8910 0x20 SimulatedTouchscreen        ( 0001866950C0 ModelClassType Touchscreen Touchscreen Touchscreen Pointer )
            value.M_NumPointers                             = GetInt32(new IntPtr(p + 0x028)); // 0270D77F8930 0x28 M_NumPointers               ( 0001865F5290 ModelPrimitiveType int int int Int32 )
            value.M_Pointers                                = GetObjectList<Pointer>(new IntPtr(p + 0x030), ReversePrism.DataModels.Pointer.FromPointer); // 0270D77F8950 0x30 M_Pointers                  ( 000185B9BB60 ModelClassListType Pointer[] Pointer[] List<Pointer> Pointer )
            value.M_CurrentPositions                        = GetEnumList<Vector2>(new IntPtr(p + 0x038)); // 0270D77F8970 0x38 M_CurrentPositions          ( 000185CB0928 ModelEnumListType Vector2[] Vector2[] List<Vector2> Pointer )
            value.M_CurrentDisplayIndices                   = GetInt32List(new IntPtr(p + 0x040)); // 0270D77F8990 0x40 M_CurrentDisplayIndices     ( 000185B7DFD0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.M_Touches                                 = GetObjectList<ButtonControl>(new IntPtr(p + 0x048), ReversePrism.DataModels.ButtonControl.FromPointer); // 0270D77F89B0 0x48 M_Touches                   ( 000185B72160 ModelClassListType ButtonControl[] ButtonControl[] List<ButtonControl> Pointer )
            value.M_LastTouchId                             = GetInt32(new IntPtr(p + 0x050)); // 0270D77F89D0 0x50 M_LastTouchId               ( 0001865F5290 ModelPrimitiveType int int int Int32 )
            value.M_PrimaryTouchIndex                       = GetInt32(new IntPtr(p + 0x054)); // 0270D77F89F0 0x54 M_PrimaryTouchIndex         ( 0001865F5290 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
