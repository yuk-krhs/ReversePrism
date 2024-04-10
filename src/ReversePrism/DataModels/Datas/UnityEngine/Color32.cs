using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Rgba                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 010 R                                        00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 011 G                                        00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 012 B                                        00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 013 A                                        00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
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

            value.Rgba                                      = GetInt32(new IntPtr(p + 0x010)); // 0245A21893C8 0x10 Rgba                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.R                                         = GetSByte(new IntPtr(p + 0x010)); // 0245A21893E8 0x10 R                           ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.G                                         = GetSByte(new IntPtr(p + 0x011)); // 0245A2189408 0x11 G                           ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.B                                         = GetSByte(new IntPtr(p + 0x012)); // 0245A2189428 0x12 B                           ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.A                                         = GetSByte(new IntPtr(p + 0x013)); // 0245A2189448 0x13 A                           ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
