using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Objects                                  000185B7D3F0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 018 NegObjects                               000185B7D3F0 ModelPrimitiveListType int[] int[] List<int> Pointer
    public partial class IntSizedArray
    {
        public List<int>?                               Objects                                 { get; set; }
        public List<int>?                               NegObjects                              { get; set; }

        public static IntSizedArray? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntSizedArray();

            value.Objects                                   = GetInt32List(new IntPtr(p + 0x010)); // 0270D6C54D78 0x10 Objects                     ( 000185B7D3F0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.NegObjects                                = GetInt32List(new IntPtr(p + 0x018)); // 0270D6C54D98 0x18 NegObjects                  ( 000185B7D3F0 ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
