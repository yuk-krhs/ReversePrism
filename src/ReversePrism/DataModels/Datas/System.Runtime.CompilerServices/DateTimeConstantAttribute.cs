using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Date                                     0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime
    public partial class DateTimeConstantAttribute : DataModel
    {
        public DateTime                                 Date                                    { get; set; }

        public static DateTimeConstantAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DateTimeConstantAttribute() { Pointer= p0 };

            value.Date                                      = GetDateTime(new IntPtr(p + 0x010)); // 024666D063E0 0x10 Date                        ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
