using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Unit                                     000186671910 ModelPrimitiveType string string string String
    // 018 <From>k__BackingField                    Nullable`1<long> IL2CPP_TYPE_GENERICINST
    // 028 <Length>k__BackingField                  Nullable`1<long> IL2CPP_TYPE_GENERICINST
    // 038 <To>k__BackingField                      Nullable`1<long> IL2CPP_TYPE_GENERICINST
    public partial class ContentRangeHeaderValue
    {
        public string                                   Unit                                    { get; set; }

        public static ContentRangeHeaderValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ContentRangeHeaderValue();

            value.Unit                                      = GetString(new IntPtr(p + 0x010)); // 0270DB8562D0 0x10 Unit                        ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
