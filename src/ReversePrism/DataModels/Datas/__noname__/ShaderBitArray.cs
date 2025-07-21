using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_BitsPerElement                         int IL2CPP_TYPE_I4
    // 000 k_ElementShift                           int IL2CPP_TYPE_I4
    // 000 k_ElementMask                            int IL2CPP_TYPE_I4
    // 010 M_Data                                   ModelPrimitiveListType float[] float[] List<float> Pointer
    public partial class ShaderBitArray : DataModel
    {
        public List<float>?                             M_Data                                  { get; set; }

        public static ShaderBitArray? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShaderBitArray() { Pointer= p0 };

            value.M_Data                                    = GetSingleList(new IntPtr(p + 0x010)); // 0x10 M_Data                      ( ModelPrimitiveListType float[] float[] List<float> Pointer )

            return value;
        }
    }
}
