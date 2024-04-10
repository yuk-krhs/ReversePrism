using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DisplayName                              000186671910 ModelPrimitiveType string string string String
    // 018 BuildSettingsKey                         000186671910 ModelPrimitiveType string string string String
    public partial class AdaptivePerformanceConfigurationDataAttribute : DataModel
    {
        public string                                   DisplayName                             { get; set; }
        public string                                   BuildSettingsKey                        { get; set; }

        public static AdaptivePerformanceConfigurationDataAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdaptivePerformanceConfigurationDataAttribute() { Pointer= p0 };

            value.DisplayName                               = GetString(new IntPtr(p + 0x010)); // 02466B708B98 0x10 DisplayName                 ( 000186671910 ModelPrimitiveType string string string String )
            value.BuildSettingsKey                          = GetString(new IntPtr(p + 0x018)); // 02466B708BB8 0x18 BuildSettingsKey            ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
