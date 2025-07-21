using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Id                                       ModelEnumType PropertyName PropertyName PropertyName Int32
    // 02C Type                                     ModelEnumType ClightControlType ClightControlType ClightControlType Int32
    // 030 Values                                   ModelPrimitiveListType int[] int[] List<int> Pointer
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

            value.Id                                        = (PropertyName)GetInt32(new IntPtr(p + 0x028)); // 0x28 Id                          ( ModelEnumType PropertyName PropertyName PropertyName Int32 )
            value.Type                                      = (ClightControlType)GetInt32(new IntPtr(p + 0x02C)); // 0x2C Type                        ( ModelEnumType ClightControlType ClightControlType ClightControlType Int32 )
            value.Values                                    = GetInt32List(new IntPtr(p + 0x030)); // 0x30 Values                      ( ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
