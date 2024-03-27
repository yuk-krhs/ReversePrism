using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Up                                       0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 Down                                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 Left                                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C Right                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 Forward                                  0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 Backward                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 Mode                                     0001866D5290 ModelEnumType Mode Mode Mode Int32
    public partial class Vector3Composite
    {
        public int                                      Up                                      { get; set; }
        public int                                      Down                                    { get; set; }
        public int                                      Left                                    { get; set; }
        public int                                      Right                                   { get; set; }
        public int                                      Forward                                 { get; set; }
        public int                                      Backward                                { get; set; }
        public Mode                                     Mode                                    { get; set; }

        public static Vector3Composite? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Vector3Composite();

            value.Up                                        = GetInt32(new IntPtr(p + 0x010)); // 0270D78D7468 0x10 Up                          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Down                                      = GetInt32(new IntPtr(p + 0x014)); // 0270D78D7488 0x14 Down                        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Left                                      = GetInt32(new IntPtr(p + 0x018)); // 0270D78D74A8 0x18 Left                        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Right                                     = GetInt32(new IntPtr(p + 0x01C)); // 0270D78D74C8 0x1C Right                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Forward                                   = GetInt32(new IntPtr(p + 0x020)); // 0270D78D74E8 0x20 Forward                     ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Backward                                  = GetInt32(new IntPtr(p + 0x024)); // 0270D78D7508 0x24 Backward                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Mode                                      = (Mode)GetInt32(new IntPtr(p + 0x028)); // 0270D78D7528 0x28 Mode                        ( 0001866D5290 ModelEnumType Mode Mode Mode Int32 )

            return value;
        }
    }
}
