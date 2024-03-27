using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 MaxSize                                  0001865F8300 ModelPrimitiveType long long long Int64
    public partial class FixedMemoryStream
    {
        public long                                     MaxSize                                 { get; set; }

        public static FixedMemoryStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FixedMemoryStream();

            value.MaxSize                                   = GetInt64(new IntPtr(p + 0x050)); // 0270DB82CC20 0x50 MaxSize                     ( 0001865F8300 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
