using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 DeviceToken                              000186671910 ModelPrimitiveType string string string String
    public partial class LiveTokenSaveData
    {
        public string                                   DeviceToken                             { get; set; }

        public static LiveTokenSaveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveTokenSaveData();

            value.DeviceToken                               = GetString(new IntPtr(p + 0x020)); // 027003A72C20 0x20 DeviceToken                 ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
