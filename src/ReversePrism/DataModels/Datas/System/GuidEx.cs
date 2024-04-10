using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 A                                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 B                                        0001865F1060 ModelPrimitiveType short short short Int16
    // 016 C                                        0001865F1060 ModelPrimitiveType short short short Int16
    // 018 D                                        00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 019 E                                        00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01A F                                        00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01B G                                        00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01C H                                        00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01D I                                        00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01E J                                        00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01F K                                        00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class GuidEx : DataModel
    {
        public int                                      A                                       { get; set; }
        public short                                    B                                       { get; set; }
        public short                                    C                                       { get; set; }
        public sbyte                                    D                                       { get; set; }
        public sbyte                                    E                                       { get; set; }
        public sbyte                                    F                                       { get; set; }
        public sbyte                                    G                                       { get; set; }
        public sbyte                                    H                                       { get; set; }
        public sbyte                                    I                                       { get; set; }
        public sbyte                                    J                                       { get; set; }
        public sbyte                                    K                                       { get; set; }

        public static GuidEx? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GuidEx() { Pointer= p0 };

            value.A                                         = GetInt32(new IntPtr(p + 0x010)); // 02466AB0E8C8 0x10 A                           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.B                                         = GetInt16(new IntPtr(p + 0x014)); // 02466AB0E8E8 0x14 B                           ( 0001865F1060 ModelPrimitiveType short short short Int16 )
            value.C                                         = GetInt16(new IntPtr(p + 0x016)); // 02466AB0E908 0x16 C                           ( 0001865F1060 ModelPrimitiveType short short short Int16 )
            value.D                                         = GetSByte(new IntPtr(p + 0x018)); // 02466AB0E928 0x18 D                           ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.E                                         = GetSByte(new IntPtr(p + 0x019)); // 02466AB0E948 0x19 E                           ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.F                                         = GetSByte(new IntPtr(p + 0x01A)); // 02466AB0E968 0x1A F                           ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.G                                         = GetSByte(new IntPtr(p + 0x01B)); // 02466AB0E988 0x1B G                           ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.H                                         = GetSByte(new IntPtr(p + 0x01C)); // 02466AB0E9A8 0x1C H                           ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.I                                         = GetSByte(new IntPtr(p + 0x01D)); // 02466AB0E9C8 0x1D I                           ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.J                                         = GetSByte(new IntPtr(p + 0x01E)); // 02466AB0E9E8 0x1E J                           ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.K                                         = GetSByte(new IntPtr(p + 0x01F)); // 02466AB0EA08 0x1F K                           ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
