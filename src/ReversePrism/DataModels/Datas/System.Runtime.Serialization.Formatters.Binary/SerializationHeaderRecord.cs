using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BinaryFormatterMajorVersion              ModelPrimitiveType int int int Int32
    // 014 BinaryFormatterMinorVersion              ModelPrimitiveType int int int Int32
    // 018 BinaryHeaderEnum                         ModelEnumType BinaryHeaderEnum BinaryHeaderEnum BinaryHeaderEnum Int32
    // 01C TopId                                    ModelPrimitiveType int int int Int32
    // 020 HeaderId                                 ModelPrimitiveType int int int Int32
    // 024 MajorVersion                             ModelPrimitiveType int int int Int32
    // 028 MinorVersion                             ModelPrimitiveType int int int Int32
    public partial class SerializationHeaderRecord : DataModel
    {
        public int                                      BinaryFormatterMajorVersion             { get; set; }
        public int                                      BinaryFormatterMinorVersion             { get; set; }
        public BinaryHeaderEnum                         BinaryHeaderEnum                        { get; set; }
        public int                                      TopId                                   { get; set; }
        public int                                      HeaderId                                { get; set; }
        public int                                      MajorVersion                            { get; set; }
        public int                                      MinorVersion                            { get; set; }

        public static SerializationHeaderRecord? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SerializationHeaderRecord() { Pointer= p0 };

            value.BinaryFormatterMajorVersion               = GetInt32(new IntPtr(p + 0x010)); // 0x10 BinaryFormatterMajorVersion ( ModelPrimitiveType int int int Int32 )
            value.BinaryFormatterMinorVersion               = GetInt32(new IntPtr(p + 0x014)); // 0x14 BinaryFormatterMinorVersion ( ModelPrimitiveType int int int Int32 )
            value.BinaryHeaderEnum                          = (BinaryHeaderEnum)GetInt32(new IntPtr(p + 0x018)); // 0x18 BinaryHeaderEnum            ( ModelEnumType BinaryHeaderEnum BinaryHeaderEnum BinaryHeaderEnum Int32 )
            value.TopId                                     = GetInt32(new IntPtr(p + 0x01C)); // 0x1C TopId                       ( ModelPrimitiveType int int int Int32 )
            value.HeaderId                                  = GetInt32(new IntPtr(p + 0x020)); // 0x20 HeaderId                    ( ModelPrimitiveType int int int Int32 )
            value.MajorVersion                              = GetInt32(new IntPtr(p + 0x024)); // 0x24 MajorVersion                ( ModelPrimitiveType int int int Int32 )
            value.MinorVersion                              = GetInt32(new IntPtr(p + 0x028)); // 0x28 MinorVersion                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
