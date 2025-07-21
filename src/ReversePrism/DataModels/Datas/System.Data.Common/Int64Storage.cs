using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Values                                   ModelPrimitiveListType long[] long[] List<long> Pointer
    public partial class Int64Storage : DataModel
    {
        public List<long>?                              Values                                  { get; set; }

        public static Int64Storage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Int64Storage() { Pointer= p0 };

            value.Values                                    = GetInt64List(new IntPtr(p + 0x050)); // 0x50 Values                      ( ModelPrimitiveListType long[] long[] List<long> Pointer )

            return value;
        }
    }
}
