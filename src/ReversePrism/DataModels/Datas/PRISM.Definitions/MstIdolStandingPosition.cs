using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstUnitId                                ModelPrimitiveType int int int Int32
    // 018 Order                                    ModelPrimitiveListType int[] int[] List<int> Pointer
    public partial class MstIdolStandingPosition : DataModel
    {
        public int                                      MstUnitId                               { get; set; }
        public List<int>?                               Order                                   { get; set; }

        public static MstIdolStandingPosition? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstIdolStandingPosition() { Pointer= p0 };

            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x010)); // 0x10 MstUnitId                   ( ModelPrimitiveType int int int Int32 )
            value.Order                                     = GetInt32List(new IntPtr(p + 0x018)); // 0x18 Order                       ( ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
