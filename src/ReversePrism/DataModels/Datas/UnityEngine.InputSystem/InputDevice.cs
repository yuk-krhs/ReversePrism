using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 InvalidDeviceId                          int IL2CPP_TYPE_I4
    // 000 kLocalParticipantId                      int IL2CPP_TYPE_I4
    // 000 kInvalidDeviceIndex                      int IL2CPP_TYPE_I4
    // 0E0 M_DeviceFlags                            00018662B9E0 ModelEnumType DeviceFlags DeviceFlags DeviceFlags Int32
    // 0E4 M_DeviceId                               0001865F2F90 ModelPrimitiveType int int int Int32
    // 0E8 M_ParticipantId                          0001865F2F90 ModelPrimitiveType int int int Int32
    // 0EC M_DeviceIndex                            0001865F2F90 ModelPrimitiveType int int int Int32
    // 0F0 M_Description                            0001865ED4F0 ModelEnumType InputDeviceDescription InputDeviceDescription InputDeviceDescription Int32
    // 128 M_LastUpdateTimeInternal                 0001865C2BA0 ModelPrimitiveType double double double Double
    // 130 M_CurrentUpdateStepCount                 000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 138 M_AliasesForEachControl                  000185B8E520 ModelEnumListType InternedString[] InternedString[] List<InternedString> Pointer
    // 140 M_UsagesForEachControl                   000185B8E520 ModelEnumListType InternedString[] InternedString[] List<InternedString> Pointer
    // 148 M_UsageToControl                         000185B8C4A0 ModelClassListType InputControl[] InputControl[] List<InputControl> Pointer
    // 150 M_ChildrenForEachControl                 000185B8C4A0 ModelClassListType InputControl[] InputControl[] List<InputControl> Pointer
    // 158 M_StateOffsetToControlMap                000185B83950 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 160 M_ControlTreeNodes                       000185CBD788 ModelEnumListType ControlBitRangeNode[] ControlBitRangeNode[] List<ControlBitRangeNode> Pointer
    // 168 M_ControlTreeIndices                     000185CAEC08 ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer
    // 000 kControlIndexBits                        int IL2CPP_TYPE_I4
    // 000 kStateOffsetBits                         int IL2CPP_TYPE_I4
    // 000 kStateSizeBits                           int IL2CPP_TYPE_I4
    public partial class InputDevice : DataModel
    {
        public DeviceFlags                              M_DeviceFlags                           { get; set; }
        public int                                      M_DeviceId                              { get; set; }
        public int                                      M_ParticipantId                         { get; set; }
        public int                                      M_DeviceIndex                           { get; set; }
        public InputDeviceDescription                   M_Description                           { get; set; }
        public double                                   M_LastUpdateTimeInternal                { get; set; }
        public uint                                     M_CurrentUpdateStepCount                { get; set; }
        public List<InternedString>?                    M_AliasesForEachControl                 { get; set; }
        public List<InternedString>?                    M_UsagesForEachControl                  { get; set; }
        public List<InputControl>?                      M_UsageToControl                        { get; set; }
        public List<InputControl>?                      M_ChildrenForEachControl                { get; set; }
        public List<uint>?                              M_StateOffsetToControlMap               { get; set; }
        public List<ControlBitRangeNode>?               M_ControlTreeNodes                      { get; set; }
        public List<ushort>?                            M_ControlTreeIndices                    { get; set; }

        public static InputDevice? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputDevice() { Pointer= p0 };

            value.M_DeviceFlags                             = (DeviceFlags)GetInt32(new IntPtr(p + 0x0E0)); // 0245A2E36198 0xE0 M_DeviceFlags               ( 00018662B9E0 ModelEnumType DeviceFlags DeviceFlags DeviceFlags Int32 )
            value.M_DeviceId                                = GetInt32(new IntPtr(p + 0x0E4)); // 0245A2E361B8 0xE4 M_DeviceId                  ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_ParticipantId                           = GetInt32(new IntPtr(p + 0x0E8)); // 0245A2E361D8 0xE8 M_ParticipantId             ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_DeviceIndex                             = GetInt32(new IntPtr(p + 0x0EC)); // 0245A2E361F8 0xEC M_DeviceIndex               ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_Description                             = (InputDeviceDescription)GetInt32(new IntPtr(p + 0x0F0)); // 0245A2E36218 0xF0 M_Description               ( 0001865ED4F0 ModelEnumType InputDeviceDescription InputDeviceDescription InputDeviceDescription Int32 )
            value.M_LastUpdateTimeInternal                  = GetDouble(new IntPtr(p + 0x128)); // 0245A2E36238 0x128 M_LastUpdateTimeInternal    ( 0001865C2BA0 ModelPrimitiveType double double double Double )
            value.M_CurrentUpdateStepCount                  = GetUInt32(new IntPtr(p + 0x130)); // 0245A2E36258 0x130 M_CurrentUpdateStepCount    ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.M_AliasesForEachControl                   = GetEnumList<InternedString>(new IntPtr(p + 0x138)); // 0245A2E36278 0x138 M_AliasesForEachControl     ( 000185B8E520 ModelEnumListType InternedString[] InternedString[] List<InternedString> Pointer )
            value.M_UsagesForEachControl                    = GetEnumList<InternedString>(new IntPtr(p + 0x140)); // 0245A2E36298 0x140 M_UsagesForEachControl      ( 000185B8E520 ModelEnumListType InternedString[] InternedString[] List<InternedString> Pointer )
            value.M_UsageToControl                          = GetObjectList<InputControl>(new IntPtr(p + 0x148), ReversePrism.DataModels.InputControl.FromPointer); // 0245A2E362B8 0x148 M_UsageToControl            ( 000185B8C4A0 ModelClassListType InputControl[] InputControl[] List<InputControl> Pointer )
            value.M_ChildrenForEachControl                  = GetObjectList<InputControl>(new IntPtr(p + 0x150), ReversePrism.DataModels.InputControl.FromPointer); // 0245A2E362D8 0x150 M_ChildrenForEachControl    ( 000185B8C4A0 ModelClassListType InputControl[] InputControl[] List<InputControl> Pointer )
            value.M_StateOffsetToControlMap                 = GetUInt32List(new IntPtr(p + 0x158)); // 0245A2E362F8 0x158 M_StateOffsetToControlMap   ( 000185B83950 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.M_ControlTreeNodes                        = GetEnumList<ControlBitRangeNode>(new IntPtr(p + 0x160)); // 0245A2E36318 0x160 M_ControlTreeNodes          ( 000185CBD788 ModelEnumListType ControlBitRangeNode[] ControlBitRangeNode[] List<ControlBitRangeNode> Pointer )
            value.M_ControlTreeIndices                      = GetUInt16List(new IntPtr(p + 0x168)); // 0245A2E36338 0x168 M_ControlTreeIndices        ( 000185CAEC08 ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer )

            return value;
        }
    }
}
