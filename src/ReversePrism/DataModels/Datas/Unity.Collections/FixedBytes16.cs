using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Byte0000                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 011 Byte0001                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 012 Byte0002                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 013 Byte0003                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 014 Byte0004                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 015 Byte0005                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 016 Byte0006                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 017 Byte0007                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 018 Byte0008                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 019 Byte0009                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01A Byte0010                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01B Byte0011                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01C Byte0012                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01D Byte0013                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01E Byte0014                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01F Byte0015                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class FixedBytes16 : DataModel
    {
        public sbyte                                    Byte0000                                { get; set; }
        public sbyte                                    Byte0001                                { get; set; }
        public sbyte                                    Byte0002                                { get; set; }
        public sbyte                                    Byte0003                                { get; set; }
        public sbyte                                    Byte0004                                { get; set; }
        public sbyte                                    Byte0005                                { get; set; }
        public sbyte                                    Byte0006                                { get; set; }
        public sbyte                                    Byte0007                                { get; set; }
        public sbyte                                    Byte0008                                { get; set; }
        public sbyte                                    Byte0009                                { get; set; }
        public sbyte                                    Byte0010                                { get; set; }
        public sbyte                                    Byte0011                                { get; set; }
        public sbyte                                    Byte0012                                { get; set; }
        public sbyte                                    Byte0013                                { get; set; }
        public sbyte                                    Byte0014                                { get; set; }
        public sbyte                                    Byte0015                                { get; set; }

        public static FixedBytes16? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FixedBytes16() { Pointer= p0 };

            value.Byte0000                                  = GetSByte(new IntPtr(p + 0x010)); // 02466990BED8 0x10 Byte0000                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0001                                  = GetSByte(new IntPtr(p + 0x011)); // 02466990BEF8 0x11 Byte0001                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0002                                  = GetSByte(new IntPtr(p + 0x012)); // 02466990BF18 0x12 Byte0002                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0003                                  = GetSByte(new IntPtr(p + 0x013)); // 02466990BF38 0x13 Byte0003                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0004                                  = GetSByte(new IntPtr(p + 0x014)); // 02466990BF58 0x14 Byte0004                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0005                                  = GetSByte(new IntPtr(p + 0x015)); // 02466990BF78 0x15 Byte0005                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0006                                  = GetSByte(new IntPtr(p + 0x016)); // 02466990BF98 0x16 Byte0006                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0007                                  = GetSByte(new IntPtr(p + 0x017)); // 02466990BFB8 0x17 Byte0007                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0008                                  = GetSByte(new IntPtr(p + 0x018)); // 02466990BFD8 0x18 Byte0008                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0009                                  = GetSByte(new IntPtr(p + 0x019)); // 02466990BFF8 0x19 Byte0009                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0010                                  = GetSByte(new IntPtr(p + 0x01A)); // 02466990C018 0x1A Byte0010                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0011                                  = GetSByte(new IntPtr(p + 0x01B)); // 02466990C038 0x1B Byte0011                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0012                                  = GetSByte(new IntPtr(p + 0x01C)); // 02466990C058 0x1C Byte0012                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0013                                  = GetSByte(new IntPtr(p + 0x01D)); // 02466990C078 0x1D Byte0013                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0014                                  = GetSByte(new IntPtr(p + 0x01E)); // 02466990C098 0x1E Byte0014                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0015                                  = GetSByte(new IntPtr(p + 0x01F)); // 02466990C0B8 0x1F Byte0015                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
