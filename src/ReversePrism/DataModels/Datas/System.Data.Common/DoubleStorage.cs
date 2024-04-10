using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Values                                   000185B7CA20 ModelPrimitiveListType double[] double[] List<double> Pointer
    public partial class DoubleStorage : DataModel
    {
        public List<double>?                            Values                                  { get; set; }

        public static DoubleStorage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DoubleStorage() { Pointer= p0 };

            value.Values                                    = GetDoubleList(new IntPtr(p + 0x050)); // 024668A3B1D0 0x50 Values                      ( 000185B7CA20 ModelPrimitiveListType double[] double[] List<double> Pointer )

            return value;
        }
    }
}
