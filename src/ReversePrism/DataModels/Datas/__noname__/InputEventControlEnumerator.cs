using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Flags                                  000186626FE0 ModelEnumType Enumerate Enumerate Enumerate Int32
    // 018 M_Device                                 0001866FB5B0 ModelClassType InputDevice InputDevice InputDevice Pointer
    // 020 M_StateOffsetToControlIndex              000185B83C70 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 028 M_StateOffsetToControlIndexLength        0001865F4260 ModelPrimitiveType int int int Int32
    // 030 M_AllControls                            000185B8C690 ModelClassListType InputControl[] InputControl[] List<InputControl> Pointer
    // 038 m_DefaultState                           IntPtr IL2CPP_TYPE_PTR
    // 040 m_CurrentState                           IntPtr IL2CPP_TYPE_PTR
    // 048 m_NoiseMask                              IntPtr IL2CPP_TYPE_PTR
    // 050 M_EventPtr                               0001865EF0C0 ModelEnumType InputEventPtr InputEventPtr InputEventPtr Int32
    // 058 M_CurrentControl                         0001865EB190 ModelClassType InputControl InputControl InputControl Pointer
    // 060 M_CurrentIndexInStateOffsetToControlIndexMap 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 064 M_CurrentControlStateBitOffset           000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 068 m_EventState                             IntPtr IL2CPP_TYPE_PTR
    // 070 M_CurrentBitOffset                       000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 074 M_EndBitOffset                           000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 078 M_MagnitudeThreshold                     0001866656B0 ModelPrimitiveType float float float Single
    public partial class InputEventControlEnumerator
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
            var value   = new InputEventControlEnumerator();

            value.M_Flags                                   = (Enumerate)GetInt32(new IntPtr(p + 0x010)); // 0270D76C8528 0x10 M_Flags                     ( 000186626FE0 ModelEnumType Enumerate Enumerate Enumerate Int32 )
            value.M_Device                                  = GetObject<InputDevice>(new IntPtr(p + 0x018), ReversePrism.DataModels.InputDevice.FromPointer); // 0270D76C8548 0x18 M_Device                    ( 0001866FB5B0 ModelClassType InputDevice InputDevice InputDevice Pointer )
            value.M_StateOffsetToControlIndex               = GetUInt32List(new IntPtr(p + 0x020)); // 0270D76C8568 0x20 M_StateOffsetToControlIndex ( 000185B83C70 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.M_StateOffsetToControlIndexLength         = GetInt32(new IntPtr(p + 0x028)); // 0270D76C8588 0x28 M_StateOffsetToControlIndexLength ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.M_AllControls                             = GetObjectList<InputControl>(new IntPtr(p + 0x030), ReversePrism.DataModels.InputControl.FromPointer); // 0270D76C85A8 0x30 M_AllControls               ( 000185B8C690 ModelClassListType InputControl[] InputControl[] List<InputControl> Pointer )
            value.M_EventPtr                                = (InputEventPtr)GetInt32(new IntPtr(p + 0x050)); // 0270D76C8628 0x50 M_EventPtr                  ( 0001865EF0C0 ModelEnumType InputEventPtr InputEventPtr InputEventPtr Int32 )
            value.M_CurrentControl                          = GetObject<InputControl>(new IntPtr(p + 0x058), ReversePrism.DataModels.InputControl.FromPointer); // 0270D76C8648 0x58 M_CurrentControl            ( 0001865EB190 ModelClassType InputControl InputControl InputControl Pointer )
            value.M_CurrentIndexInStateOffsetToControlIndexMap = GetInt32(new IntPtr(p + 0x060)); // 0270D76C8668 0x60 M_CurrentIndexInStateOffsetToControlIndexMap ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_CurrentControlStateBitOffset            = GetUInt32(new IntPtr(p + 0x064)); // 0270D76C8688 0x64 M_CurrentControlStateBitOffset ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.M_CurrentBitOffset                        = GetUInt32(new IntPtr(p + 0x070)); // 0270D76C86C8 0x70 M_CurrentBitOffset          ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.M_EndBitOffset                            = GetUInt32(new IntPtr(p + 0x074)); // 0270D76C86E8 0x74 M_EndBitOffset              ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.M_MagnitudeThreshold                      = GetSingle(new IntPtr(p + 0x078)); // 0270D76C8708 0x78 M_MagnitudeThreshold        ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
