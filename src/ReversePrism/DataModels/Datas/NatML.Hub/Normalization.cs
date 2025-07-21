using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Mean                                     ModelPrimitiveListType float[] float[] List<float> Pointer
    // 018 Std                                      ModelPrimitiveListType float[] float[] List<float> Pointer
    public partial class Normalization : DataModel
    {
        public List<float>?                             Mean                                    { get; set; }
        public List<float>?                             Std                                     { get; set; }

        public static Normalization? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Normalization() { Pointer= p0 };

            value.Mean                                      = GetSingleList(new IntPtr(p + 0x010)); // 0x10 Mean                        ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.Std                                       = GetSingleList(new IntPtr(p + 0x018)); // 0x18 Std                         ( ModelPrimitiveListType float[] float[] List<float> Pointer )

            return value;
        }
    }
}
