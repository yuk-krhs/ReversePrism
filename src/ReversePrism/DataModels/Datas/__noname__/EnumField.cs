using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 070 QuickSeparators                          000185B7D3F0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 078 M_Indexes                                000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 080 <getIndex>k__BackingField                Func`1<int> IL2CPP_TYPE_GENERICINST
    // 088 <setIndex>k__BackingField                Action`1<int> IL2CPP_TYPE_GENERICINST
    public partial class EnumField
    {
        public List<int>?                               QuickSeparators                         { get; set; }
        public List<int>?                               M_Indexes                               { get; set; }

        public static EnumField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnumField();

            value.QuickSeparators                           = GetInt32List(new IntPtr(p + 0x070)); // 0270D90F7D00 0x70 QuickSeparators             ( 000185B7D3F0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.M_Indexes                                 = GetInt32List(new IntPtr(p + 0x078)); // 0270D90F7D20 0x78 M_Indexes                   ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
