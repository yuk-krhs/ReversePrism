using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Values                                   000185CA2298 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class SByteStorage
    {
        public List<sbyte>?                             Values                                  { get; set; }

        public static SByteStorage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SByteStorage();

            value.Values                                    = GetSByteList(new IntPtr(p + 0x050)); // 0270D89E8718 0x50 Values                      ( 000185CA2298 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
