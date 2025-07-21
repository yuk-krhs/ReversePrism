using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Out                                      ModelClassType StringBuilder StringBuilder StringBuilder Pointer
    // 018 _ids                                     Dictionary`2<<object>, int> IL2CPP_TYPE_GENERICINST
    public partial class ExpressionStringBuilder : DataModel
    {
        public StringBuilder?                           Out                                     { get; set; }

        public static ExpressionStringBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExpressionStringBuilder() { Pointer= p0 };

            value.Out                                       = GetObject<StringBuilder>(new IntPtr(p + 0x010), ReversePrism.DataModels.StringBuilder.FromPointer); // 0x10 Out                         ( ModelClassType StringBuilder StringBuilder StringBuilder Pointer )

            return value;
        }
    }
}
