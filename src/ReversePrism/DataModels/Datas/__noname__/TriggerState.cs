using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kMaxNumMaps                              int IL2CPP_TYPE_I4
    // 000 kMaxNumControls                          int IL2CPP_TYPE_I4
    // 000 kMaxNumBindings                          int IL2CPP_TYPE_I4
    // 010 M_Phase                                  ModelPrimitiveType sbyte sbyte sbyte SByte
    // 011 M_Flags                                  ModelPrimitiveType sbyte sbyte sbyte SByte
    // 012 M_MapIndex                               ModelPrimitiveType sbyte sbyte sbyte SByte
    // 014 M_ControlIndex                           ModelPrimitiveType ushort ushort ushort UInt16
    // 018 M_Time                                   ModelPrimitiveType double double double Double
    // 020 M_StartTime                              ModelPrimitiveType double double double Double
    // 028 M_BindingIndex                           ModelPrimitiveType ushort ushort ushort UInt16
    // 02A M_InteractionIndex                       ModelPrimitiveType ushort ushort ushort UInt16
    // 02C M_Magnitude                              ModelPrimitiveType float float float Single
    // 030 M_LastPerformedInUpdate                  ModelPrimitiveType uint uint uint UInt32
    // 034 M_LastCanceledInUpdate                   ModelPrimitiveType uint uint uint UInt32
    // 038 M_PressedInUpdate                        ModelPrimitiveType uint uint uint UInt32
    // 03C M_ReleasedInUpdate                       ModelPrimitiveType uint uint uint UInt32
    public partial class TriggerState : DataModel
    {
        public sbyte                                    M_Phase                                 { get; set; }
        public sbyte                                    M_Flags                                 { get; set; }
        public sbyte                                    M_MapIndex                              { get; set; }
        public ushort                                   M_ControlIndex                          { get; set; }
        public double                                   M_Time                                  { get; set; }
        public double                                   M_StartTime                             { get; set; }
        public ushort                                   M_BindingIndex                          { get; set; }
        public ushort                                   M_InteractionIndex                      { get; set; }
        public float                                    M_Magnitude                             { get; set; }
        public uint                                     M_LastPerformedInUpdate                 { get; set; }
        public uint                                     M_LastCanceledInUpdate                  { get; set; }
        public uint                                     M_PressedInUpdate                       { get; set; }
        public uint                                     M_ReleasedInUpdate                      { get; set; }

        public static TriggerState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TriggerState() { Pointer= p0 };

            value.M_Phase                                   = GetSByte(new IntPtr(p + 0x010)); // 0x10 M_Phase                     ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_Flags                                   = GetSByte(new IntPtr(p + 0x011)); // 0x11 M_Flags                     ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_MapIndex                                = GetSByte(new IntPtr(p + 0x012)); // 0x12 M_MapIndex                  ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_ControlIndex                            = GetUInt16(new IntPtr(p + 0x014)); // 0x14 M_ControlIndex              ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.M_Time                                    = GetDouble(new IntPtr(p + 0x018)); // 0x18 M_Time                      ( ModelPrimitiveType double double double Double )
            value.M_StartTime                               = GetDouble(new IntPtr(p + 0x020)); // 0x20 M_StartTime                 ( ModelPrimitiveType double double double Double )
            value.M_BindingIndex                            = GetUInt16(new IntPtr(p + 0x028)); // 0x28 M_BindingIndex              ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.M_InteractionIndex                        = GetUInt16(new IntPtr(p + 0x02A)); // 0x2A M_InteractionIndex          ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.M_Magnitude                               = GetSingle(new IntPtr(p + 0x02C)); // 0x2C M_Magnitude                 ( ModelPrimitiveType float float float Single )
            value.M_LastPerformedInUpdate                   = GetUInt32(new IntPtr(p + 0x030)); // 0x30 M_LastPerformedInUpdate     ( ModelPrimitiveType uint uint uint UInt32 )
            value.M_LastCanceledInUpdate                    = GetUInt32(new IntPtr(p + 0x034)); // 0x34 M_LastCanceledInUpdate      ( ModelPrimitiveType uint uint uint UInt32 )
            value.M_PressedInUpdate                         = GetUInt32(new IntPtr(p + 0x038)); // 0x38 M_PressedInUpdate           ( ModelPrimitiveType uint uint uint UInt32 )
            value.M_ReleasedInUpdate                        = GetUInt32(new IntPtr(p + 0x03C)); // 0x3C M_ReleasedInUpdate          ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
