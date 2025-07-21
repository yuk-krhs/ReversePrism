using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Values                                   ModelPrimitiveListType int[] int[] List<int> Pointer
    public partial class Int32Storage : DataModel
    {
        public List<int>?                               Values                                  { get; set; }

        public static Int32Storage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Int32Storage() { Pointer= p0 };

            value.Values                                    = GetInt32List(new IntPtr(p + 0x050)); // 0x50 Values                      ( ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
