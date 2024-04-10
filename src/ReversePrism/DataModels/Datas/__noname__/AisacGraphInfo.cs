using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     000186546F70 ModelEnumType AisacGraphType AisacGraphType AisacGraphType Int32
    public partial class AisacGraphInfo : DataModel
    {
        public AisacGraphType                           Type                                    { get; set; }

        public static AisacGraphInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AisacGraphInfo() { Pointer= p0 };

            value.Type                                      = (AisacGraphType)GetInt32(new IntPtr(p + 0x010)); // 02466ACDAA28 0x10 Type                        ( 000186546F70 ModelEnumType AisacGraphType AisacGraphType AisacGraphType Int32 )

            return value;
        }
    }
}
