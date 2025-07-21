using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Offset0000                               ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 020 Offset0016                               ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 030 Offset0032                               ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 040 Offset0048                               ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 050 Offset0064                               ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 060 Offset0080                               ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 070 Offset0096                               ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 080 Byte0112                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 081 Byte0113                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 082 Byte0114                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 083 Byte0115                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 084 Byte0116                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 085 Byte0117                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 086 Byte0118                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 087 Byte0119                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 088 Byte0120                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 089 Byte0121                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 08A Byte0122                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 08B Byte0123                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 08C Byte0124                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 08D Byte0125                                 ModelPrimitiveType sbyte sbyte sbyte SByte
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

            value.Offset0000                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x010)); // 0x10 Offset0000                  ( ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0016                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x020)); // 0x20 Offset0016                  ( ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0032                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x030)); // 0x30 Offset0032                  ( ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0048                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x040)); // 0x40 Offset0048                  ( ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0064                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x050)); // 0x50 Offset0064                  ( ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0080                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x060)); // 0x60 Offset0080                  ( ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0096                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x070)); // 0x70 Offset0096                  ( ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Byte0112                                  = GetSByte(new IntPtr(p + 0x080)); // 0x80 Byte0112                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0113                                  = GetSByte(new IntPtr(p + 0x081)); // 0x81 Byte0113                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0114                                  = GetSByte(new IntPtr(p + 0x082)); // 0x82 Byte0114                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0115                                  = GetSByte(new IntPtr(p + 0x083)); // 0x83 Byte0115                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0116                                  = GetSByte(new IntPtr(p + 0x084)); // 0x84 Byte0116                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0117                                  = GetSByte(new IntPtr(p + 0x085)); // 0x85 Byte0117                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0118                                  = GetSByte(new IntPtr(p + 0x086)); // 0x86 Byte0118                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0119                                  = GetSByte(new IntPtr(p + 0x087)); // 0x87 Byte0119                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0120                                  = GetSByte(new IntPtr(p + 0x088)); // 0x88 Byte0120                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0121                                  = GetSByte(new IntPtr(p + 0x089)); // 0x89 Byte0121                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0122                                  = GetSByte(new IntPtr(p + 0x08A)); // 0x8A Byte0122                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0123                                  = GetSByte(new IntPtr(p + 0x08B)); // 0x8B Byte0123                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0124                                  = GetSByte(new IntPtr(p + 0x08C)); // 0x8C Byte0124                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte0125                                  = GetSByte(new IntPtr(p + 0x08D)); // 0x8D Byte0125                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
