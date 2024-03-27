using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Enabled                                  000186595960 ModelPrimitiveType bool bool bool Bool
    // 018 Id                                       0001866722E0 ModelPrimitiveType string string string String
    // 020 Version                                  0001866722E0 ModelPrimitiveType string string string String
    // 028 CustomData                               0001866722E0 ModelPrimitiveType string string string String
    public partial class ProviderData
    {
        public bool                                     Enabled                                 { get; set; }
        public string                                   Id                                      { get; set; }
        public string                                   Version                                 { get; set; }
        public string                                   CustomData                              { get; set; }

        public static ProviderData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProviderData();

            value.Enabled                                   = GetBool(new IntPtr(p + 0x010)); // 0270D0913408 0x10 Enabled                     ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Id                                        = GetString(new IntPtr(p + 0x018)); // 0270D0913428 0x18 Id                          ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Version                                   = GetString(new IntPtr(p + 0x020)); // 0270D0913448 0x20 Version                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.CustomData                                = GetString(new IntPtr(p + 0x028)); // 0270D0913468 0x28 CustomData                  ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
