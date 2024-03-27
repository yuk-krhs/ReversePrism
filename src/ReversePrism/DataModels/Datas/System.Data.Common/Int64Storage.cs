using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Values                                   000185B7E2C0 ModelPrimitiveListType long[] long[] List<long> Pointer
    public partial class Int64Storage
    {
        public List<long>?                              Values                                  { get; set; }

        public static Int64Storage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Int64Storage();

            value.Values                                    = GetInt64List(new IntPtr(p + 0x050)); // 0270D89E1810 0x50 Values                      ( 000185B7E2C0 ModelPrimitiveListType long[] long[] List<long> Pointer )

            return value;
        }
    }
}
