using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Guid                                     0001866722E0 ModelPrimitiveType string string string String
    // 030 Selector                                 0001866722E0 ModelPrimitiveType string string string String
    // 038 AppId                                    0001866722E0 ModelPrimitiveType string string string String
    // 040 Title                                    0001866722E0 ModelPrimitiveType string string string String
    // 048 Url                                      0001866722E0 ModelPrimitiveType string string string String
    // 050 MobileUrl                                0001866722E0 ModelPrimitiveType string string string String
    // 058 TouchUrl                                 0001866722E0 ModelPrimitiveType string string string String
    public partial class ActivityParameter : DataModel
    {
        public string                                   Guid                                    { get; set; }
        public string                                   Selector                                { get; set; }
        public string                                   AppId                                   { get; set; }
        public string                                   Title                                   { get; set; }
        public string                                   Url                                     { get; set; }
        public string                                   MobileUrl                               { get; set; }
        public string                                   TouchUrl                                { get; set; }

        public static ActivityParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ActivityParameter() { Pointer= p0 };

            value.Guid                                      = GetString(new IntPtr(p + 0x028)); // 02466B5167F0 0x28 Guid                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Selector                                  = GetString(new IntPtr(p + 0x030)); // 02466B516810 0x30 Selector                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.AppId                                     = GetString(new IntPtr(p + 0x038)); // 02466B516830 0x38 AppId                       ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Title                                     = GetString(new IntPtr(p + 0x040)); // 02466B516850 0x40 Title                       ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Url                                       = GetString(new IntPtr(p + 0x048)); // 02466B516870 0x48 Url                         ( 0001866722E0 ModelPrimitiveType string string string String )
            value.MobileUrl                                 = GetString(new IntPtr(p + 0x050)); // 02466B516890 0x50 MobileUrl                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.TouchUrl                                  = GetString(new IntPtr(p + 0x058)); // 02466B5168B0 0x58 TouchUrl                    ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
