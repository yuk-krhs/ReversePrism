using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Indexes                                  000185CECFD8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    public partial class ArrayMultipleIndexFilter : DataModel
    {
        public List<int>?                               Indexes                                 { get; set; }

        public static ArrayMultipleIndexFilter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ArrayMultipleIndexFilter() { Pointer= p0 };

            value.Indexes                                   = GetInt32List(new IntPtr(p + 0x010)); // 024668881D00 0x10 Indexes                     ( 000185CECFD8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )

            return value;
        }
    }
}
