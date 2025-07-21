using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Left                                     ModelPrimitiveType long long long Int64
    // 018 Top                                      ModelPrimitiveType long long long Int64
    // 020 Right                                    ModelPrimitiveType long long long Int64
    // 028 Bottom                                   ModelPrimitiveType long long long Int64
    public partial class IntRect : DataModel
    {
        public long                                     Left                                    { get; set; }
        public long                                     Top                                     { get; set; }
        public long                                     Right                                   { get; set; }
        public long                                     Bottom                                  { get; set; }

        public static IntRect? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntRect() { Pointer= p0 };

            value.Left                                      = GetInt64(new IntPtr(p + 0x010)); // 0x10 Left                        ( ModelPrimitiveType long long long Int64 )
            value.Top                                       = GetInt64(new IntPtr(p + 0x018)); // 0x18 Top                         ( ModelPrimitiveType long long long Int64 )
            value.Right                                     = GetInt64(new IntPtr(p + 0x020)); // 0x20 Right                       ( ModelPrimitiveType long long long Int64 )
            value.Bottom                                    = GetInt64(new IntPtr(p + 0x028)); // 0x28 Bottom                      ( ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
