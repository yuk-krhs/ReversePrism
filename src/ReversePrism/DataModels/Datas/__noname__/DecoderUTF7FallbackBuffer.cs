using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 cFallback                                char IL2CPP_TYPE_CHAR
    // 024 ICount                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 ISize                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class DecoderUTF7FallbackBuffer : DataModel
    {
        public int                                      ICount                                  { get; set; }
        public int                                      ISize                                   { get; set; }

        public static DecoderUTF7FallbackBuffer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DecoderUTF7FallbackBuffer() { Pointer= p0 };

            value.ICount                                    = GetInt32(new IntPtr(p + 0x024)); // 024666BDD9E8 0x24 ICount                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ISize                                     = GetInt32(new IntPtr(p + 0x028)); // 024666BDDA08 0x28 ISize                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
