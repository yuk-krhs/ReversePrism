using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Values                                   ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class ByteStorage : DataModel
    {
        public List<sbyte>?                             Values                                  { get; set; }

        public static ByteStorage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ByteStorage() { Pointer= p0 };

            value.Values                                    = GetSByteList(new IntPtr(p + 0x050)); // 0x50 Values                      ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
