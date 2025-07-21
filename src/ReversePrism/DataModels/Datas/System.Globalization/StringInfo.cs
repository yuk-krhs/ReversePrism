using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_str                                    ModelPrimitiveType string string string String
    // 018 M_indexes                                ModelPrimitiveListType int[] int[] List<int> Pointer
    public partial class StringInfo : DataModel
    {
        public string                                   M_str                                   { get; set; }
        public List<int>?                               M_indexes                               { get; set; }

        public static StringInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StringInfo() { Pointer= p0 };

            value.M_str                                     = GetString(new IntPtr(p + 0x010)); // 0x10 M_str                       ( ModelPrimitiveType string string string String )
            value.M_indexes                                 = GetInt32List(new IntPtr(p + 0x018)); // 0x18 M_indexes                   ( ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
