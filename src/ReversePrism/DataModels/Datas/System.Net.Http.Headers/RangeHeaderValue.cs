using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Ranges                                   ModelClassListType List`1<RangeItemHeaderValue> List`1<RangeItemHeaderValue> List<RangeItemHeaderValue> Pointer
    // 018 Unit                                     ModelPrimitiveType string string string String
    public partial class RangeHeaderValue : DataModel
    {
        public List<RangeItemHeaderValue>?              Ranges                                  { get; set; }
        public string                                   Unit                                    { get; set; }

        public static RangeHeaderValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RangeHeaderValue() { Pointer= p0 };

            value.Ranges                                    = GetObjectList<RangeItemHeaderValue>(new IntPtr(p + 0x010), ReversePrism.DataModels.RangeItemHeaderValue.FromPointer); // 0x10 Ranges                      ( ModelClassListType List`1<RangeItemHeaderValue> List`1<RangeItemHeaderValue> List<RangeItemHeaderValue> Pointer )
            value.Unit                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Unit                        ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
