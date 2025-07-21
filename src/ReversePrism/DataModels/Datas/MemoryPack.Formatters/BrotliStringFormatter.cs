using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // FFFFFFFF threadStaticConsumedBox                  StrongBox`1<int> IL2CPP_TYPE_GENERICINST
    // 000 DefaultDecompssionSizeLimit              int IL2CPP_TYPE_I4
    // 000 Default                                  BrotliStringFormatter IL2CPP_TYPE_CLASS
    // 010 CompressionLevel                         ModelEnumType CompressionLevel CompressionLevel CompressionLevel Int32
    // 014 Window                                   ModelPrimitiveType int int int Int32
    // 018 DecompressionSizeLimit                   ModelPrimitiveType int int int Int32
    public partial class BrotliStringFormatter : DataModel
    {
        public CompressionLevel                         CompressionLevel                        { get; set; }
        public int                                      Window                                  { get; set; }
        public int                                      DecompressionSizeLimit                  { get; set; }

        public static BrotliStringFormatter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BrotliStringFormatter() { Pointer= p0 };

            value.CompressionLevel                          = (CompressionLevel)GetInt32(new IntPtr(p + 0x010)); // 0x10 CompressionLevel            ( ModelEnumType CompressionLevel CompressionLevel CompressionLevel Int32 )
            value.Window                                    = GetInt32(new IntPtr(p + 0x014)); // 0x14 Window                      ( ModelPrimitiveType int int int Int32 )
            value.DecompressionSizeLimit                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 DecompressionSizeLimit      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
