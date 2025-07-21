using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 SwitchEnforceJapaneseEraYearRanges       string IL2CPP_TYPE_STRING
    // 008 SwitchFormatJapaneseFirstYearAsANumber   string IL2CPP_TYPE_STRING
    // 010 SwitchEnforceLegacyJapaneseDateParsing   ModelPrimitiveType string string string String
    public partial class AppContextDefaultValues : DataModel
    {
        public string                                   SwitchEnforceLegacyJapaneseDateParsing  { get; set; }

        public static AppContextDefaultValues? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AppContextDefaultValues() { Pointer= p0 };

            value.SwitchEnforceLegacyJapaneseDateParsing    = GetString(new IntPtr(p + 0x010)); // 0x10 SwitchEnforceLegacyJapaneseDateParsing ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
