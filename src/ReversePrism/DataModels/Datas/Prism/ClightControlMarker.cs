using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Id                                       000186648E00 ModelEnumType PropertyName PropertyName PropertyName Int32
    // 02C Type                                     0001865B87C0 ModelEnumType ClightControlType ClightControlType ClightControlType Int32
    // 030 Values                                   000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    public partial class ClightControlMarker : DataModel
    {
        public PropertyName                             Id                                      { get; set; }
        public ClightControlType                        Type                                    { get; set; }
        public List<int>?                               Values                                  { get; set; }

        public static ClightControlMarker? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ClightControlMarker() { Pointer= p0 };

            value.Id                                        = (PropertyName)GetInt32(new IntPtr(p + 0x028)); // 024664E3E618 0x28 Id                          ( 000186648E00 ModelEnumType PropertyName PropertyName PropertyName Int32 )
            value.Type                                      = (ClightControlType)GetInt32(new IntPtr(p + 0x02C)); // 024664E3E638 0x2C Type                        ( 0001865B87C0 ModelEnumType ClightControlType ClightControlType ClightControlType Int32 )
            value.Values                                    = GetInt32List(new IntPtr(p + 0x030)); // 024664E3E658 0x30 Values                      ( 000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
