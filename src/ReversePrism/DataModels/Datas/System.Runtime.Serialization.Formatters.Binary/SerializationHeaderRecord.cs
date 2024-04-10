using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BinaryFormatterMajorVersion              0001865F2F90 ModelPrimitiveType int int int Int32
    // 014 BinaryFormatterMinorVersion              0001865F2F90 ModelPrimitiveType int int int Int32
    // 018 BinaryHeaderEnum                         000186758300 ModelEnumType BinaryHeaderEnum BinaryHeaderEnum BinaryHeaderEnum Int32
    // 01C TopId                                    0001865F2F90 ModelPrimitiveType int int int Int32
    // 020 HeaderId                                 0001865F2F90 ModelPrimitiveType int int int Int32
    // 024 MajorVersion                             0001865F2F90 ModelPrimitiveType int int int Int32
    // 028 MinorVersion                             0001865F2F90 ModelPrimitiveType int int int Int32
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

            value.BinaryFormatterMajorVersion               = GetInt32(new IntPtr(p + 0x010)); // 024666CA0E88 0x10 BinaryFormatterMajorVersion ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.BinaryFormatterMinorVersion               = GetInt32(new IntPtr(p + 0x014)); // 024666CA0EA8 0x14 BinaryFormatterMinorVersion ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.BinaryHeaderEnum                          = (BinaryHeaderEnum)GetInt32(new IntPtr(p + 0x018)); // 024666CA0EC8 0x18 BinaryHeaderEnum            ( 000186758300 ModelEnumType BinaryHeaderEnum BinaryHeaderEnum BinaryHeaderEnum Int32 )
            value.TopId                                     = GetInt32(new IntPtr(p + 0x01C)); // 024666CA0EE8 0x1C TopId                       ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.HeaderId                                  = GetInt32(new IntPtr(p + 0x020)); // 024666CA0F08 0x20 HeaderId                    ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.MajorVersion                              = GetInt32(new IntPtr(p + 0x024)); // 024666CA0F28 0x24 MajorVersion                ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.MinorVersion                              = GetInt32(new IntPtr(p + 0x028)); // 024666CA0F48 0x28 MinorVersion                ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
