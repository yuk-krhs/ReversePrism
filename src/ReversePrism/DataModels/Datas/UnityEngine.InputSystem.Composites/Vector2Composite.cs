using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Up                                       ModelPrimitiveType int int int Int32
    // 014 Down                                     ModelPrimitiveType int int int Int32
    // 018 Left                                     ModelPrimitiveType int int int Int32
    // 01C Right                                    ModelPrimitiveType int int int Int32
    // 020 Normalize                                ModelPrimitiveType bool bool bool Bool
    // 024 Mode                                     ModelEnumType Mode Mode Mode Int32
    public partial class Vector2Composite : DataModel
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
            var value   = new Vector2Composite() { Pointer= p0 };

            value.Up                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Up                          ( ModelPrimitiveType int int int Int32 )
            value.Down                                      = GetInt32(new IntPtr(p + 0x014)); // 0x14 Down                        ( ModelPrimitiveType int int int Int32 )
            value.Left                                      = GetInt32(new IntPtr(p + 0x018)); // 0x18 Left                        ( ModelPrimitiveType int int int Int32 )
            value.Right                                     = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Right                       ( ModelPrimitiveType int int int Int32 )
            value.Normalize                                 = GetBool(new IntPtr(p + 0x020)); // 0x20 Normalize                   ( ModelPrimitiveType bool bool bool Bool )
            value.Mode                                      = (Mode)GetInt32(new IntPtr(p + 0x024)); // 0x24 Mode                        ( ModelEnumType Mode Mode Mode Int32 )

            return value;
        }
    }
}
