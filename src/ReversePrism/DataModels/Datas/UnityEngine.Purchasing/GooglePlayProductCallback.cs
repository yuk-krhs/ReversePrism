using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_GooglePlayConfigurationInternal        00018655D2D0 ModelClassType IGooglePlayConfigurationInternal IGooglePlayConfigurationInternal IGooglePlayConfigurationInternal Pointer
    public partial class GooglePlayProductCallback
    {
        public IGooglePlayConfigurationInternal?        M_GooglePlayConfigurationInternal       { get; set; }

        public static GooglePlayProductCallback? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GooglePlayProductCallback();

            value.M_GooglePlayConfigurationInternal         = GetObject<IGooglePlayConfigurationInternal>(new IntPtr(p + 0x010), ReversePrism.DataModels.IGooglePlayConfigurationInternal.FromPointer); // 0270069096F8 0x10 M_GooglePlayConfigurationInternal ( 00018655D2D0 ModelClassType IGooglePlayConfigurationInternal IGooglePlayConfigurationInternal IGooglePlayConfigurationInternal Pointer )

            return value;
        }
    }
}
