using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Values                                   000185B8D650 ModelPrimitiveListType short[] short[] List<short> Pointer
    public partial class Int16Storage
    {
        public List<short>?                             Values                                  { get; set; }

        public static Int16Storage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Int16Storage();

            value.Values                                    = GetInt16List(new IntPtr(p + 0x050)); // 0270D89E0BE0 0x50 Values                      ( 000185B8D650 ModelPrimitiveListType short[] short[] List<short> Pointer )

            return value;
        }
    }
}
