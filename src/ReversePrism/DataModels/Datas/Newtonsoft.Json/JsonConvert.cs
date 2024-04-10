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
    public partial class JsonConvert : DataModel
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
            var value   = new JsonConvert() { Pointer= p0 };

            value.False                                     = GetString(new IntPtr(p + 0x010)); // 0245A5FA8230 0x10 False                       ( 000186674040 ModelPrimitiveType string string string String )
            value.Null                                      = GetString(new IntPtr(p + 0x018)); // 0245A5FA8250 0x18 Null                        ( 000186674040 ModelPrimitiveType string string string String )
            value.Undefined                                 = GetString(new IntPtr(p + 0x020)); // 0245A5FA8270 0x20 Undefined                   ( 000186674040 ModelPrimitiveType string string string String )
            value.PositiveInfinity                          = GetString(new IntPtr(p + 0x028)); // 0245A5FA8290 0x28 PositiveInfinity            ( 000186674040 ModelPrimitiveType string string string String )
            value.NegativeInfinity                          = GetString(new IntPtr(p + 0x030)); // 0245A5FA82B0 0x30 NegativeInfinity            ( 000186674040 ModelPrimitiveType string string string String )
            value.NaN                                       = GetString(new IntPtr(p + 0x038)); // 0245A5FA82D0 0x38 NaN                         ( 000186674040 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
