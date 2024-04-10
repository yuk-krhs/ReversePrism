using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DefaultDecompssionSizeLimit              int IL2CPP_TYPE_I4
    // 000 Default                                  BrotliFormatter IL2CPP_TYPE_CLASS
    // 010 CompressionLevel                         0001865F4BD0 ModelEnumType CompressionLevel CompressionLevel CompressionLevel Int32
    // 014 Window                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 018 DecompressionSizeLimit                   0001865F4260 ModelPrimitiveType int int int Int32
    public partial class BrotliFormatter : DataModel
    {
        public CompressionLevel                         CompressionLevel                        { get; set; }
        public int                                      Window                                  { get; set; }
        public int                                      DecompressionSizeLimit                  { get; set; }

        public static BrotliFormatter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BrotliFormatter() { Pointer= p0 };

            value.CompressionLevel                          = (CompressionLevel)GetInt32(new IntPtr(p + 0x010)); // 02466B058E18 0x10 CompressionLevel            ( 0001865F4BD0 ModelEnumType CompressionLevel CompressionLevel CompressionLevel Int32 )
            value.Window                                    = GetInt32(new IntPtr(p + 0x014)); // 02466B058E38 0x14 Window                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.DecompressionSizeLimit                    = GetInt32(new IntPtr(p + 0x018)); // 02466B058E58 0x18 DecompressionSizeLimit      ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
