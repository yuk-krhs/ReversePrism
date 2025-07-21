using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Pool                                   ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 018 M_Current                                ModelPrimitiveType int int int Int32
    public partial class TargetPool : DataModel
    {
        public List<int>?                               M_Pool                                  { get; set; }
        public int                                      M_Current                               { get; set; }

        public static TargetPool? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TargetPool() { Pointer= p0 };

            value.M_Pool                                    = GetInt32List(new IntPtr(p + 0x010)); // 0x10 M_Pool                      ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.M_Current                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 M_Current                   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
