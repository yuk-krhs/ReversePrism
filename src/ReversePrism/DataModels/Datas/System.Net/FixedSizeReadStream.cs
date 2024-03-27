using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 ContentLength                            0001865F8300 ModelPrimitiveType long long long Int64
    // 048 Position                                 0001865F7700 ModelPrimitiveType long long long Int64
    public partial class FixedSizeReadStream
    {
        public long                                     ContentLength                           { get; set; }
        public long                                     Position                                { get; set; }

        public static FixedSizeReadStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FixedSizeReadStream();

            value.ContentLength                             = GetInt64(new IntPtr(p + 0x040)); // 0270D7A621B8 0x40 ContentLength               ( 0001865F8300 ModelPrimitiveType long long long Int64 )
            value.Position                                  = GetInt64(new IntPtr(p + 0x048)); // 0270D7A621D8 0x48 Position                    ( 0001865F7700 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
