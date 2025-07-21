using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Flags                                  ModelEnumType Enumerate Enumerate Enumerate Int32
    // 018 M_Device                                 ModelClassType InputDevice InputDevice InputDevice Pointer
    // 020 M_StateOffsetToControlIndex              ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 028 M_StateOffsetToControlIndexLength        ModelPrimitiveType int int int Int32
    // 030 M_AllControls                            ModelClassListType InputControl[] InputControl[] List<InputControl> Pointer
    // 038 m_DefaultState                           IntPtr IL2CPP_TYPE_PTR
    // 040 m_CurrentState                           IntPtr IL2CPP_TYPE_PTR
    // 048 m_NoiseMask                              IntPtr IL2CPP_TYPE_PTR
    // 050 M_EventPtr                               ModelEnumType InputEventPtr InputEventPtr InputEventPtr Int32
    // 058 M_CurrentControl                         ModelClassType InputControl InputControl InputControl Pointer
    // 060 M_CurrentIndexInStateOffsetToControlIndexMap ModelPrimitiveType int int int Int32
    // 064 M_CurrentControlStateBitOffset           ModelPrimitiveType uint uint uint UInt32
    // 068 m_EventState                             IntPtr IL2CPP_TYPE_PTR
    // 070 M_CurrentBitOffset                       ModelPrimitiveType uint uint uint UInt32
    // 074 M_EndBitOffset                           ModelPrimitiveType uint uint uint UInt32
    // 078 M_MagnitudeThreshold                     ModelPrimitiveType float float float Single
    public partial class InputEventControlEnumerator : DataModel
    {
        public Enumerate                                M_Flags                                 { get; set; }
        public InputDevice?                             M_Device                                { get; set; }
        public List<uint>?                              M_StateOffsetToControlIndex             { get; set; }
        public int                                      M_StateOffsetToControlIndexLength       { get; set; }
        public List<InputControl>?                      M_AllControls                           { get; set; }
        public InputEventPtr                            M_EventPtr                              { get; set; }
        public InputControl?                            M_CurrentControl                        { get; set; }
        public int                                      M_CurrentIndexInStateOffsetToControlIndexMap { get; set; }
        public uint                                     M_CurrentControlStateBitOffset          { get; set; }
        public uint                                     M_CurrentBitOffset                      { get; set; }
        public uint                                     M_EndBitOffset                          { get; set; }
        public float                                    M_MagnitudeThreshold                    { get; set; }

        public static InputEventControlEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputEventControlEnumerator() { Pointer= p0 };

            value.M_Flags                                   = (Enumerate)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Flags                     ( ModelEnumType Enumerate Enumerate Enumerate Int32 )
            value.M_Device                                  = GetObject<InputDevice>(new IntPtr(p + 0x018), ReversePrism.DataModels.InputDevice.FromPointer); // 0x18 M_Device                    ( ModelClassType InputDevice InputDevice InputDevice Pointer )
            value.M_StateOffsetToControlIndex               = GetUInt32List(new IntPtr(p + 0x020)); // 0x20 M_StateOffsetToControlIndex ( ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.M_StateOffsetToControlIndexLength         = GetInt32(new IntPtr(p + 0x028)); // 0x28 M_StateOffsetToControlIndexLength ( ModelPrimitiveType int int int Int32 )
            value.M_AllControls                             = GetObjectList<InputControl>(new IntPtr(p + 0x030), ReversePrism.DataModels.InputControl.FromPointer); // 0x30 M_AllControls               ( ModelClassListType InputControl[] InputControl[] List<InputControl> Pointer )
            value.M_EventPtr                                = (InputEventPtr)GetInt32(new IntPtr(p + 0x050)); // 0x50 M_EventPtr                  ( ModelEnumType InputEventPtr InputEventPtr InputEventPtr Int32 )
            value.M_CurrentControl                          = GetObject<InputControl>(new IntPtr(p + 0x058), ReversePrism.DataModels.InputControl.FromPointer); // 0x58 M_CurrentControl            ( ModelClassType InputControl InputControl InputControl Pointer )
            value.M_CurrentIndexInStateOffsetToControlIndexMap = GetInt32(new IntPtr(p + 0x060)); // 0x60 M_CurrentIndexInStateOffsetToControlIndexMap ( ModelPrimitiveType int int int Int32 )
            value.M_CurrentControlStateBitOffset            = GetUInt32(new IntPtr(p + 0x064)); // 0x64 M_CurrentControlStateBitOffset ( ModelPrimitiveType uint uint uint UInt32 )
            value.M_CurrentBitOffset                        = GetUInt32(new IntPtr(p + 0x070)); // 0x70 M_CurrentBitOffset          ( ModelPrimitiveType uint uint uint UInt32 )
            value.M_EndBitOffset                            = GetUInt32(new IntPtr(p + 0x074)); // 0x74 M_EndBitOffset              ( ModelPrimitiveType uint uint uint UInt32 )
            value.M_MagnitudeThreshold                      = GetSingle(new IntPtr(p + 0x078)); // 0x78 M_MagnitudeThreshold        ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
