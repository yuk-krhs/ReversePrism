using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Values                                   ModelPrimitiveListType float[] float[] List<float> Pointer
    public partial class SingleStorage : DataModel
    {
        public List<float>?                             Values                                  { get; set; }

        public static SingleStorage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SingleStorage() { Pointer= p0 };

            value.Values                                    = GetSingleList(new IntPtr(p + 0x050)); // 0x50 Values                      ( ModelPrimitiveListType float[] float[] List<float> Pointer )

            return value;
        }
    }
}
