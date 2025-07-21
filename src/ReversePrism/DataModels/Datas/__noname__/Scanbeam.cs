using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Y                                        ModelPrimitiveType long long long Int64
    // 018 Next                                     ModelClassType Scanbeam Scanbeam Scanbeam Pointer
    public partial class Scanbeam : DataModel
    {
        public long                                     Y                                       { get; set; }
        public Scanbeam?                                Next                                    { get; set; }

        public static Scanbeam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Scanbeam() { Pointer= p0 };

            value.Y                                         = GetInt64(new IntPtr(p + 0x010)); // 0x10 Y                           ( ModelPrimitiveType long long long Int64 )
            value.Next                                      = GetObject<Scanbeam>(new IntPtr(p + 0x018), ReversePrism.DataModels.Scanbeam.FromPointer); // 0x18 Next                        ( ModelClassType Scanbeam Scanbeam Scanbeam Pointer )

            return value;
        }
    }
}
