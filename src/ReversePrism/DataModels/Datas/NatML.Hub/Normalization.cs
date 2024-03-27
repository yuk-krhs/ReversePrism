using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Mean                                     000185B80920 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 018 Std                                      000185B80920 ModelPrimitiveListType float[] float[] List<float> Pointer
    public partial class Normalization
    {
        public List<float>?                             Mean                                    { get; set; }
        public List<float>?                             Std                                     { get; set; }

        public static Normalization? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Normalization();

            value.Mean                                      = GetSingleList(new IntPtr(p + 0x010)); // 0270DBDB7A40 0x10 Mean                        ( 000185B80920 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.Std                                       = GetSingleList(new IntPtr(p + 0x018)); // 0270DBDB7A60 0x18 Std                         ( 000185B80920 ModelPrimitiveListType float[] float[] List<float> Pointer )

            return value;
        }
    }
}
