using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kDefaultHistorySize                      int IL2CPP_TYPE_I4
    // 010 <onRecordAdded>k__BackingField           Action`1<Record> IL2CPP_TYPE_GENERICINST
    // 018 <onShouldRecordStateChange>k__BackingField Func`4<InputControl, double, InputEventPtr, bool> IL2CPP_TYPE_GENERICINST
    // 020 M_Controls                               ModelClassListType InputControl[] InputControl[] List<InputControl> Pointer
    // 028 M_ControlCount                           ModelPrimitiveType int int int Int32
    // 030 m_RecordBuffer                           NativeArray`1<sbyte> IL2CPP_TYPE_GENERICINST
    // 040 M_StateSizeInBytes                       ModelPrimitiveType int int int Int32
    // 044 M_RecordCount                            ModelPrimitiveType int int int Int32
    // 048 M_HistoryDepth                           ModelPrimitiveType int int int Int32
    // 04C M_ExtraMemoryPerRecord                   ModelPrimitiveType int int int Int32
    // 050 M_HeadIndex                              ModelPrimitiveType int int int Int32
    // 054 M_CurrentVersion                         ModelPrimitiveType uint uint uint UInt32
    // 058 m_UpdateMask                             Nullable`1<InputUpdateType> IL2CPP_TYPE_GENERICINST
    // 060 M_AddNewControls                         ModelPrimitiveType bool bool bool Bool
    public partial class InputStateHistory : DataModel
    {
        public List<InputControl>?                      M_Controls                              { get; set; }
        public int                                      M_ControlCount                          { get; set; }
        public int                                      M_StateSizeInBytes                      { get; set; }
        public int                                      M_RecordCount                           { get; set; }
        public int                                      M_HistoryDepth                          { get; set; }
        public int                                      M_ExtraMemoryPerRecord                  { get; set; }
        public int                                      M_HeadIndex                             { get; set; }
        public uint                                     M_CurrentVersion                        { get; set; }
        public bool                                     M_AddNewControls                        { get; set; }

        public static InputStateHistory? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputStateHistory() { Pointer= p0 };

            value.M_Controls                                = GetObjectList<InputControl>(new IntPtr(p + 0x020), ReversePrism.DataModels.InputControl.FromPointer); // 0x20 M_Controls                  ( ModelClassListType InputControl[] InputControl[] List<InputControl> Pointer )
            value.M_ControlCount                            = GetInt32(new IntPtr(p + 0x028)); // 0x28 M_ControlCount              ( ModelPrimitiveType int int int Int32 )
            value.M_StateSizeInBytes                        = GetInt32(new IntPtr(p + 0x040)); // 0x40 M_StateSizeInBytes          ( ModelPrimitiveType int int int Int32 )
            value.M_RecordCount                             = GetInt32(new IntPtr(p + 0x044)); // 0x44 M_RecordCount               ( ModelPrimitiveType int int int Int32 )
            value.M_HistoryDepth                            = GetInt32(new IntPtr(p + 0x048)); // 0x48 M_HistoryDepth              ( ModelPrimitiveType int int int Int32 )
            value.M_ExtraMemoryPerRecord                    = GetInt32(new IntPtr(p + 0x04C)); // 0x4C M_ExtraMemoryPerRecord      ( ModelPrimitiveType int int int Int32 )
            value.M_HeadIndex                               = GetInt32(new IntPtr(p + 0x050)); // 0x50 M_HeadIndex                 ( ModelPrimitiveType int int int Int32 )
            value.M_CurrentVersion                          = GetUInt32(new IntPtr(p + 0x054)); // 0x54 M_CurrentVersion            ( ModelPrimitiveType uint uint uint UInt32 )
            value.M_AddNewControls                          = GetBool(new IntPtr(p + 0x060)); // 0x60 M_AddNewControls            ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
