using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Q                                        000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    public partial class BoneAxisInt : DataModel
    {
        public List<int>?                               Q                                       { get; set; }

        public static BoneAxisInt? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BoneAxisInt() { Pointer= p0 };

            value.Q                                         = GetInt32List(new IntPtr(p + 0x010)); // 024664DF28B0 0x10 Q                           ( 000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
