using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Objects                                  ModelPrimitiveListType int[] int[] List<int> Pointer
    // 018 NegObjects                               ModelPrimitiveListType int[] int[] List<int> Pointer
    public partial class IntSizedArray : DataModel
    {
        public List<int>?                               Objects                                 { get; set; }
        public List<int>?                               NegObjects                              { get; set; }

        public static IntSizedArray? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntSizedArray() { Pointer= p0 };

            value.Objects                                   = GetInt32List(new IntPtr(p + 0x010)); // 0x10 Objects                     ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.NegObjects                                = GetInt32List(new IntPtr(p + 0x018)); // 0x18 NegObjects                  ( ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
