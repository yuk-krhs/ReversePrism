using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Offset0000                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 020 Offset0016                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 030 Offset0032                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 040 Offset0048                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 050 Offset0064                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 060 Offset0080                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 070 Offset0096                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 080 Byte0112                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 081 Byte0113                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 082 Byte0114                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 083 Byte0115                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 084 Byte0116                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 085 Byte0117                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 086 Byte0118                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 087 Byte0119                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 088 Byte0120                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 089 Byte0121                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 08A Byte0122                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 08B Byte0123                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 08C Byte0124                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 08D Byte0125                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class FixedBytes126 : DataModel
    {
        public FixedBytes16                             Offset0000                              { get; set; }
        public FixedBytes16                             Offset0016                              { get; set; }
        public FixedBytes16                             Offset0032                              { get; set; }
        public FixedBytes16                             Offset0048                              { get; set; }
        public FixedBytes16                             Offset0064                              { get; set; }
        public FixedBytes16                             Offset0080                              { get; set; }
        public FixedBytes16                             Offset0096                              { get; set; }
        public sbyte                                    Byte0112                                { get; set; }
        public sbyte                                    Byte0113                                { get; set; }
        public sbyte                                    Byte0114                                { get; set; }
        public sbyte                                    Byte0115                                { get; set; }
        public sbyte                                    Byte0116                                { get; set; }
        public sbyte                                    Byte0117                                { get; set; }
        public sbyte                                    Byte0118                                { get; set; }
        public sbyte                                    Byte0119                                { get; set; }
        public sbyte                                    Byte0120                                { get; set; }
        public sbyte                                    Byte0121                                { get; set; }
        public sbyte                                    Byte0122                                { get; set; }
        public sbyte                                    Byte0123                                { get; set; }
        public sbyte                                    Byte0124                                { get; set; }
        public sbyte                                    Byte0125                                { get; set; }

        public static FixedBytes126? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FixedBytes126() { Pointer= p0 };

            value.Offset0000                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x010)); // 02466990FDE0 0x10 Offset0000                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0016                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x020)); // 02466990FE00 0x20 Offset0016                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0032                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x030)); // 02466990FE20 0x30 Offset0032                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0048                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x040)); // 02466990FE40 0x40 Offset0048                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0064                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x050)); // 02466990FE60 0x50 Offset0064                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0080                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x060)); // 02466990FE80 0x60 Offset0080                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0096                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x070)); // 02466990FEA0 0x70 Offset0096                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Byte0112                                  = GetSByte(new IntPtr(p + 0x080)); // 02466990FEC0 0x80 Byte0112                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0113                                  = GetSByte(new IntPtr(p + 0x081)); // 02466990FEE0 0x81 Byte0113                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0114                                  = GetSByte(new IntPtr(p + 0x082)); // 02466990FF00 0x82 Byte0114                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0115                                  = GetSByte(new IntPtr(p + 0x083)); // 02466990FF20 0x83 Byte0115                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0116                                  = GetSByte(new IntPtr(p + 0x084)); // 02466990FF40 0x84 Byte0116                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0117                                  = GetSByte(new IntPtr(p + 0x085)); // 02466990FF60 0x85 Byte0117                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0118                                  = GetSByte(new IntPtr(p + 0x086)); // 02466990FF80 0x86 Byte0118                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0119                                  = GetSByte(new IntPtr(p + 0x087)); // 02466990FFA0 0x87 Byte0119                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0120                                  = GetSByte(new IntPtr(p + 0x088)); // 02466990FFC0 0x88 Byte0120                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0121                                  = GetSByte(new IntPtr(p + 0x089)); // 02466990FFE0 0x89 Byte0121                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0122                                  = GetSByte(new IntPtr(p + 0x08A)); // 024669910000 0x8A Byte0122                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0123                                  = GetSByte(new IntPtr(p + 0x08B)); // 024669910020 0x8B Byte0123                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0124                                  = GetSByte(new IntPtr(p + 0x08C)); // 024669910040 0x8C Byte0124                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0125                                  = GetSByte(new IntPtr(p + 0x08D)); // 024669910060 0x8D Byte0125                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
