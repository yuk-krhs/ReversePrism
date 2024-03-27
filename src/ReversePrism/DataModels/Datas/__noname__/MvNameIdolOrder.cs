using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MvName                                   0001866722E0 ModelPrimitiveType string string string String
    // 018 Ids                                      000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    public partial class MvNameIdolOrder
    {
        public string                                   MvName                                  { get; set; }
        public List<int>?                               Ids                                     { get; set; }

        public static MvNameIdolOrder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MvNameIdolOrder();

            value.MvName                                    = GetString(new IntPtr(p + 0x010)); // 0270D5C6ADC8 0x10 MvName                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Ids                                       = GetInt32List(new IntPtr(p + 0x018)); // 0270D5C6ADE8 0x18 Ids                         ( 000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
