using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SimulatedTouchscreen                     ModelClassType Touchscreen Touchscreen Touchscreen Pointer
    // 028 M_NumPointers                            ModelPrimitiveType int int int Int32
    // 030 M_Pointers                               ModelClassListType Pointer[] Pointer[] List<Pointer> Pointer
    // 038 M_CurrentPositions                       ModelEnumListType Vector2[] Vector2[] List<Vector2> Pointer
    // 040 M_CurrentDisplayIndices                  ModelPrimitiveListType int[] int[] List<int> Pointer
    // 048 M_Touches                                ModelClassListType ButtonControl[] ButtonControl[] List<ButtonControl> Pointer
    // 050 M_LastTouchId                            ModelPrimitiveType int int int Int32
    // 054 M_PrimaryTouchIndex                      ModelPrimitiveType int int int Int32
    // 058 m_OnDeviceChange                         Action`2<InputDevice, InputDeviceChange> IL2CPP_TYPE_GENERICINST
    // 060 m_OnEvent                                Action`2<InputEventPtr, InputDevice> IL2CPP_TYPE_GENERICINST
    // 000 s_Instance                               TouchSimulation IL2CPP_TYPE_CLASS
    public partial class TouchSimulation : DataModel
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
            var value   = new TouchSimulation() { Pointer= p0 };

            value.SimulatedTouchscreen                      = GetObject<Touchscreen>(new IntPtr(p + 0x020), ReversePrism.DataModels.Touchscreen.FromPointer); // 0x20 SimulatedTouchscreen        ( ModelClassType Touchscreen Touchscreen Touchscreen Pointer )
            value.M_NumPointers                             = GetInt32(new IntPtr(p + 0x028)); // 0x28 M_NumPointers               ( ModelPrimitiveType int int int Int32 )
            value.M_Pointers                                = GetObjectList<Pointer>(new IntPtr(p + 0x030), ReversePrism.DataModels.Pointer.FromPointer); // 0x30 M_Pointers                  ( ModelClassListType Pointer[] Pointer[] List<Pointer> Pointer )
            value.M_CurrentPositions                        = GetEnumList<Vector2>(new IntPtr(p + 0x038)); // 0x38 M_CurrentPositions          ( ModelEnumListType Vector2[] Vector2[] List<Vector2> Pointer )
            value.M_CurrentDisplayIndices                   = GetInt32List(new IntPtr(p + 0x040)); // 0x40 M_CurrentDisplayIndices     ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.M_Touches                                 = GetObjectList<ButtonControl>(new IntPtr(p + 0x048), ReversePrism.DataModels.ButtonControl.FromPointer); // 0x48 M_Touches                   ( ModelClassListType ButtonControl[] ButtonControl[] List<ButtonControl> Pointer )
            value.M_LastTouchId                             = GetInt32(new IntPtr(p + 0x050)); // 0x50 M_LastTouchId               ( ModelPrimitiveType int int int Int32 )
            value.M_PrimaryTouchIndex                       = GetInt32(new IntPtr(p + 0x054)); // 0x54 M_PrimaryTouchIndex         ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
