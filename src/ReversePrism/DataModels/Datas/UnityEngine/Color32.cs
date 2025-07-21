using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Rgba                                     ModelPrimitiveType int int int Int32
    // 010 R                                        ModelPrimitiveType sbyte sbyte sbyte SByte
    // 011 G                                        ModelPrimitiveType sbyte sbyte sbyte SByte
    // 012 B                                        ModelPrimitiveType sbyte sbyte sbyte SByte
    // 013 A                                        ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class Color32 : DataModel
    {
        public int                                      Rgba                                    { get; set; }
        public sbyte                                    R                                       { get; set; }
        public sbyte                                    G                                       { get; set; }
        public sbyte                                    B                                       { get; set; }
        public sbyte                                    A                                       { get; set; }

        public static Color32? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Color32() { Pointer= p0 };

            value.Rgba                                      = GetInt32(new IntPtr(p + 0x010)); // 0x10 Rgba                        ( ModelPrimitiveType int int int Int32 )
            value.R                                         = GetSByte(new IntPtr(p + 0x010)); // 0x10 R                           ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.G                                         = GetSByte(new IntPtr(p + 0x011)); // 0x11 G                           ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B                                         = GetSByte(new IntPtr(p + 0x012)); // 0x12 B                           ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.A                                         = GetSByte(new IntPtr(p + 0x013)); // 0x13 A                           ( ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
