using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ReturnBytes                              000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class PrismStreamReadBuffer : DataModel
    {
        public List<sbyte>?                             ReturnBytes                             { get; set; }

        public static PrismStreamReadBuffer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrismStreamReadBuffer() { Pointer= p0 };

            value.ReturnBytes                               = GetSByteList(new IntPtr(p + 0x010)); // 024664F73D88 0x10 ReturnBytes                 ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
