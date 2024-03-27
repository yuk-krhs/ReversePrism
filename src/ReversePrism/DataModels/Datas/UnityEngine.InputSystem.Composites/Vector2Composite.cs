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
    // 020 Normalize                                000186595960 ModelPrimitiveType bool bool bool Bool
    // 024 Mode                                     0001866D3300 ModelEnumType Mode Mode Mode Int32
    public partial class Vector2Composite
    {
        public int                                      Up                                      { get; set; }
        public int                                      Down                                    { get; set; }
        public int                                      Left                                    { get; set; }
        public int                                      Right                                   { get; set; }
        public bool                                     Normalize                               { get; set; }
        public Mode                                     Mode                                    { get; set; }

        public static Vector2Composite? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Vector2Composite();

            value.Up                                        = GetInt32(new IntPtr(p + 0x010)); // 0270D78D6F00 0x10 Up                          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Down                                      = GetInt32(new IntPtr(p + 0x014)); // 0270D78D6F20 0x14 Down                        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Left                                      = GetInt32(new IntPtr(p + 0x018)); // 0270D78D6F40 0x18 Left                        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Right                                     = GetInt32(new IntPtr(p + 0x01C)); // 0270D78D6F60 0x1C Right                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Normalize                                 = GetBool(new IntPtr(p + 0x020)); // 0270D78D6F80 0x20 Normalize                   ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Mode                                      = (Mode)GetInt32(new IntPtr(p + 0x024)); // 0270D78D6FA0 0x24 Mode                        ( 0001866D3300 ModelEnumType Mode Mode Mode Int32 )

            return value;
        }
    }
}
