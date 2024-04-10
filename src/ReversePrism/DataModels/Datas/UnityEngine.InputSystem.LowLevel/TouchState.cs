using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kSizeInBytes                             int IL2CPP_TYPE_I4
    // 010 TouchId                                  0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 Position                                 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 01C Delta                                    0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 024 Pressure                                 000186666050 ModelPrimitiveType float float float Single
    // 028 Radius                                   0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 030 PhaseId                                  00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 031 TapCount                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 032 DisplayIndex                             00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 033 Flags                                    00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 034 UpdateStepCount                          000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 038 StartTime                                0001865C2E50 ModelPrimitiveType double double double Double
    // 040 StartPosition                            0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
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

            value.TouchId                                   = GetInt32(new IntPtr(p + 0x010)); // 0245A33966A0 0x10 TouchId                     ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Position                                  = (Vector2)GetInt32(new IntPtr(p + 0x014)); // 0245A33966C0 0x14 Position                    ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Delta                                     = (Vector2)GetInt32(new IntPtr(p + 0x01C)); // 0245A33966E0 0x1C Delta                       ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Pressure                                  = GetSingle(new IntPtr(p + 0x024)); // 0245A3396700 0x24 Pressure                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.Radius                                    = (Vector2)GetInt32(new IntPtr(p + 0x028)); // 0245A3396720 0x28 Radius                      ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.PhaseId                                   = GetSByte(new IntPtr(p + 0x030)); // 0245A3396740 0x30 PhaseId                     ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.TapCount                                  = GetSByte(new IntPtr(p + 0x031)); // 0245A3396760 0x31 TapCount                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.DisplayIndex                              = GetSByte(new IntPtr(p + 0x032)); // 0245A3396780 0x32 DisplayIndex                ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Flags                                     = GetSByte(new IntPtr(p + 0x033)); // 0245A33967A0 0x33 Flags                       ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.UpdateStepCount                           = GetUInt32(new IntPtr(p + 0x034)); // 0245A33967C0 0x34 UpdateStepCount             ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.StartTime                                 = GetDouble(new IntPtr(p + 0x038)); // 0245A33967E0 0x38 StartTime                   ( 0001865C2E50 ModelPrimitiveType double double double Double )
            value.StartPosition                             = (Vector2)GetInt32(new IntPtr(p + 0x040)); // 0245A3396800 0x40 StartPosition               ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
