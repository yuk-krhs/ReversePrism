using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ProfileTag                               string IL2CPP_TYPE_STRING
    // 008 ShaderTagIdList                          List`1<ShaderTagId> IL2CPP_TYPE_GENERICINST
    // 010 FilteringSettings                        ModelEnumType FilteringSettings FilteringSettings FilteringSettings Int32
    public partial class PrismDrawUI : DataModel
    {
        public FilteringSettings                        FilteringSettings                       { get; set; }

        public static PrismDrawUI? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrismDrawUI() { Pointer= p0 };

            value.FilteringSettings                         = (FilteringSettings)GetInt32(new IntPtr(p + 0x010)); // 0x10 FilteringSettings           ( ModelEnumType FilteringSettings FilteringSettings FilteringSettings Int32 )

            return value;
        }
    }
}
