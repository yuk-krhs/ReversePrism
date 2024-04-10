using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Array                                    000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    public partial class IntArray : DataModel
    {
        public List<int>?                               Array                                   { get; set; }

        public static IntArray? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntArray() { Pointer= p0 };

            value.Array                                     = GetInt32List(new IntPtr(p + 0x010)); // 024667C9EBC0 0x10 Array                       ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
