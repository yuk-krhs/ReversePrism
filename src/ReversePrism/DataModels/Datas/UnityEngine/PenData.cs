using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Position                                 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 018 Tilt                                     ModelEnumType Vector2 Vector2 Vector2 Int32
    // 020 PenStatus                                ModelEnumType PenStatus PenStatus PenStatus Int32
    // 024 Twist                                    ModelPrimitiveType float float float Single
    // 028 Pressure                                 ModelPrimitiveType float float float Single
    // 02C ContactType                              ModelEnumType PenEventType PenEventType PenEventType Int32
    // 030 DeltaPos                                 ModelEnumType Vector2 Vector2 Vector2 Int32
    public partial class PenData : DataModel
    {
        public Vector2                                  Position                                { get; set; }
        public Vector2                                  Tilt                                    { get; set; }
        public PenStatus                                PenStatus                               { get; set; }
        public float                                    Twist                                   { get; set; }
        public float                                    Pressure                                { get; set; }
        public PenEventType                             ContactType                             { get; set; }
        public Vector2                                  DeltaPos                                { get; set; }

        public static PenData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PenData() { Pointer= p0 };

            value.Position                                  = (Vector2)GetInt32(new IntPtr(p + 0x010)); // 0x10 Position                    ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Tilt                                      = (Vector2)GetInt32(new IntPtr(p + 0x018)); // 0x18 Tilt                        ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.PenStatus                                 = (PenStatus)GetInt32(new IntPtr(p + 0x020)); // 0x20 PenStatus                   ( ModelEnumType PenStatus PenStatus PenStatus Int32 )
            value.Twist                                     = GetSingle(new IntPtr(p + 0x024)); // 0x24 Twist                       ( ModelPrimitiveType float float float Single )
            value.Pressure                                  = GetSingle(new IntPtr(p + 0x028)); // 0x28 Pressure                    ( ModelPrimitiveType float float float Single )
            value.ContactType                               = (PenEventType)GetInt32(new IntPtr(p + 0x02C)); // 0x2C ContactType                 ( ModelEnumType PenEventType PenEventType PenEventType Int32 )
            value.DeltaPos                                  = (Vector2)GetInt32(new IntPtr(p + 0x030)); // 0x30 DeltaPos                    ( ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
