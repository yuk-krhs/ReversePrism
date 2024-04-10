using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_AllowedCharactersForFloat              string IL2CPP_TYPE_STRING
    // 008 k_AllowedCharactersForInt                string IL2CPP_TYPE_STRING
    // 010 K_DoubleFieldFormatString                000186674040 ModelPrimitiveType string string string String
    // 018 K_FloatFieldFormatString                 000186674040 ModelPrimitiveType string string string String
    // 020 K_IntFieldFormatString                   000186674040 ModelPrimitiveType string string string String
    public partial class UINumericFieldsUtils : DataModel
    {
        public string                                   K_DoubleFieldFormatString               { get; set; }
        public string                                   K_FloatFieldFormatString                { get; set; }
        public string                                   K_IntFieldFormatString                  { get; set; }

        public static UINumericFieldsUtils? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UINumericFieldsUtils() { Pointer= p0 };

            value.K_DoubleFieldFormatString                 = GetString(new IntPtr(p + 0x010)); // 0245A6881B80 0x10 K_DoubleFieldFormatString   ( 000186674040 ModelPrimitiveType string string string String )
            value.K_FloatFieldFormatString                  = GetString(new IntPtr(p + 0x018)); // 0245A6881BA0 0x18 K_FloatFieldFormatString    ( 000186674040 ModelPrimitiveType string string string String )
            value.K_IntFieldFormatString                    = GetString(new IntPtr(p + 0x020)); // 0245A6881BC0 0x20 K_IntFieldFormatString      ( 000186674040 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
