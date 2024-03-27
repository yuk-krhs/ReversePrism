using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 <DefaultSettings>k__BackingField         Func`1<JsonSerializerSettings> IL2CPP_TYPE_GENERICINST
    // 008 True                                     string IL2CPP_TYPE_STRING
    // 010 False                                    000186674040 ModelPrimitiveType string string string String
    // 018 Null                                     000186674040 ModelPrimitiveType string string string String
    // 020 Undefined                                000186674040 ModelPrimitiveType string string string String
    // 028 PositiveInfinity                         000186674040 ModelPrimitiveType string string string String
    // 030 NegativeInfinity                         000186674040 ModelPrimitiveType string string string String
    // 038 NaN                                      000186674040 ModelPrimitiveType string string string String
    public partial class JsonConvert
    {
        public string                                   False                                   { get; set; }
        public string                                   Null                                    { get; set; }
        public string                                   Undefined                               { get; set; }
        public string                                   PositiveInfinity                        { get; set; }
        public string                                   NegativeInfinity                        { get; set; }
        public string                                   NaN                                     { get; set; }

        public static JsonConvert? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonConvert();

            value.False                                     = GetString(new IntPtr(p + 0x010)); // 027005FCCB60 0x10 False                       ( 000186674040 ModelPrimitiveType string string string String )
            value.Null                                      = GetString(new IntPtr(p + 0x018)); // 027005FCCB80 0x18 Null                        ( 000186674040 ModelPrimitiveType string string string String )
            value.Undefined                                 = GetString(new IntPtr(p + 0x020)); // 027005FCCBA0 0x20 Undefined                   ( 000186674040 ModelPrimitiveType string string string String )
            value.PositiveInfinity                          = GetString(new IntPtr(p + 0x028)); // 027005FCCBC0 0x28 PositiveInfinity            ( 000186674040 ModelPrimitiveType string string string String )
            value.NegativeInfinity                          = GetString(new IntPtr(p + 0x030)); // 027005FCCBE0 0x30 NegativeInfinity            ( 000186674040 ModelPrimitiveType string string string String )
            value.NaN                                       = GetString(new IntPtr(p + 0x038)); // 027005FCCC00 0x38 NaN                         ( 000186674040 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
