using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Data                                     ModelEnumType MovedFromAttributeData MovedFromAttributeData MovedFromAttributeData Int32
    public partial class MovedFromAttribute : DataModel
    {
        public MovedFromAttributeData                   Data                                    { get; set; }

        public static MovedFromAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MovedFromAttribute() { Pointer= p0 };

            value.Data                                      = (MovedFromAttributeData)GetInt32(new IntPtr(p + 0x010)); // 0x10 Data                        ( ModelEnumType MovedFromAttributeData MovedFromAttributeData MovedFromAttributeData Int32 )

            return value;
        }
    }
}
