using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kSizeInBytes                             int IL2CPP_TYPE_I4
    // 010 TouchId                                  ModelPrimitiveType int int int Int32
    // 014 Position                                 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 01C Delta                                    ModelEnumType Vector2 Vector2 Vector2 Int32
    // 024 Pressure                                 ModelPrimitiveType float float float Single
    // 028 Radius                                   ModelEnumType Vector2 Vector2 Vector2 Int32
    // 030 PhaseId                                  ModelPrimitiveType sbyte sbyte sbyte SByte
    // 031 TapCount                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 032 DisplayIndex                             ModelPrimitiveType sbyte sbyte sbyte SByte
    // 033 Flags                                    ModelPrimitiveType sbyte sbyte sbyte SByte
    // 034 UpdateStepCount                          ModelPrimitiveType uint uint uint UInt32
    // 038 StartTime                                ModelPrimitiveType double double double Double
    // 040 StartPosition                            ModelEnumType Vector2 Vector2 Vector2 Int32
    public partial class TouchState : DataModel
    {
        public int                                      TouchId                                 { get; set; }
        public Vector2                                  Position                                { get; set; }
        public Vector2                                  Delta                                   { get; set; }
        public float                                    Pressure                                { get; set; }
        public Vector2                                  Radius                                  { get; set; }
        public sbyte                                    PhaseId                                 { get; set; }
        public sbyte                                    TapCount                                { get; set; }
        public sbyte                                    DisplayIndex                            { get; set; }
        public sbyte                                    Flags                                   { get; set; }
        public uint                                     UpdateStepCount                         { get; set; }
        public double                                   StartTime                               { get; set; }
        public Vector2                                  StartPosition                           { get; set; }

        public static TouchState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TouchState() { Pointer= p0 };

            value.TouchId                                   = GetInt32(new IntPtr(p + 0x010)); // 0x10 TouchId                     ( ModelPrimitiveType int int int Int32 )
            value.Position                                  = (Vector2)GetInt32(new IntPtr(p + 0x014)); // 0x14 Position                    ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Delta                                     = (Vector2)GetInt32(new IntPtr(p + 0x01C)); // 0x1C Delta                       ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Pressure                                  = GetSingle(new IntPtr(p + 0x024)); // 0x24 Pressure                    ( ModelPrimitiveType float float float Single )
            value.Radius                                    = (Vector2)GetInt32(new IntPtr(p + 0x028)); // 0x28 Radius                      ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.PhaseId                                   = GetSByte(new IntPtr(p + 0x030)); // 0x30 PhaseId                     ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.TapCount                                  = GetSByte(new IntPtr(p + 0x031)); // 0x31 TapCount                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.DisplayIndex                              = GetSByte(new IntPtr(p + 0x032)); // 0x32 DisplayIndex                ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Flags                                     = GetSByte(new IntPtr(p + 0x033)); // 0x33 Flags                       ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.UpdateStepCount                           = GetUInt32(new IntPtr(p + 0x034)); // 0x34 UpdateStepCount             ( ModelPrimitiveType uint uint uint UInt32 )
            value.StartTime                                 = GetDouble(new IntPtr(p + 0x038)); // 0x38 StartTime                   ( ModelPrimitiveType double double double Double )
            value.StartPosition                             = (Vector2)GetInt32(new IntPtr(p + 0x040)); // 0x40 StartPosition               ( ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
