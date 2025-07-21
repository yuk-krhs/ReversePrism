using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 X                                        ModelPrimitiveType long long long Int64
    // 018 Next                                     ModelClassType Maxima Maxima Maxima Pointer
    // 020 Prev                                     ModelClassType Maxima Maxima Maxima Pointer
    public partial class Maxima : DataModel
    {
        public long                                     X                                       { get; set; }
        public Maxima?                                  Next                                    { get; set; }
        public Maxima?                                  Prev                                    { get; set; }

        public static Maxima? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Maxima() { Pointer= p0 };

            value.X                                         = GetInt64(new IntPtr(p + 0x010)); // 0x10 X                           ( ModelPrimitiveType long long long Int64 )
            value.Next                                      = GetObject<Maxima>(new IntPtr(p + 0x018), ReversePrism.DataModels.Maxima.FromPointer); // 0x18 Next                        ( ModelClassType Maxima Maxima Maxima Pointer )
            value.Prev                                      = GetObject<Maxima>(new IntPtr(p + 0x020), ReversePrism.DataModels.Maxima.FromPointer); // 0x20 Prev                        ( ModelClassType Maxima Maxima Maxima Pointer )

            return value;
        }
    }
}
