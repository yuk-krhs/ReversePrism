using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Field                                    000186573870 ModelClassType FieldInfo FieldInfo FieldInfo Pointer
    public partial class FieldExpression : DataModel
    {
        public FieldInfo?                               Field                                   { get; set; }

        public static FieldExpression? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FieldExpression() { Pointer= p0 };

            value.Field                                     = GetObject<FieldInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.FieldInfo.FromPointer); // 024669FCF228 0x18 Field                       ( 000186573870 ModelClassType FieldInfo FieldInfo FieldInfo Pointer )

            return value;
        }
    }
}
