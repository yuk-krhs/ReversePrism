using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_GooglePlayConfigurationInternal        ModelClassType IGooglePlayConfigurationInternal IGooglePlayConfigurationInternal IGooglePlayConfigurationInternal Pointer
    public partial class GooglePlayProductCallback : DataModel
    {
        public IGooglePlayConfigurationInternal?        M_GooglePlayConfigurationInternal       { get; set; }

        public static GooglePlayProductCallback? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GooglePlayProductCallback() { Pointer= p0 };

            value.M_GooglePlayConfigurationInternal         = GetObject<IGooglePlayConfigurationInternal>(new IntPtr(p + 0x010), ReversePrism.DataModels.IGooglePlayConfigurationInternal.FromPointer); // 0x10 M_GooglePlayConfigurationInternal ( ModelClassType IGooglePlayConfigurationInternal IGooglePlayConfigurationInternal IGooglePlayConfigurationInternal Pointer )

            return value;
        }
    }
}
