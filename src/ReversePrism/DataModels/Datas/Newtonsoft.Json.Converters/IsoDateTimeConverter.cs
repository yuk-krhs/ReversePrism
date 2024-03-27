using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DefaultDateTimeFormat                    string IL2CPP_TYPE_STRING
    // 010 DateTimeStyles                           0001865BE5C0 ModelEnumType DateTimeStyles DateTimeStyles DateTimeStyles Int32
    // 018 DateTimeFormat                           000186671910 ModelPrimitiveType string string string String
    // 020 Culture                                  0001865B47C0 ModelClassType CultureInfo CultureInfo CultureInfo Pointer
    public partial class IsoDateTimeConverter
    {
        public DateTimeStyles                           DateTimeStyles                          { get; set; }
        public string                                   DateTimeFormat                          { get; set; }
        public CultureInfo?                             Culture                                 { get; set; }

        public static IsoDateTimeConverter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IsoDateTimeConverter();

            value.DateTimeStyles                            = (DateTimeStyles)GetInt32(new IntPtr(p + 0x010)); // 0270D8869708 0x10 DateTimeStyles              ( 0001865BE5C0 ModelEnumType DateTimeStyles DateTimeStyles DateTimeStyles Int32 )
            value.DateTimeFormat                            = GetString(new IntPtr(p + 0x018)); // 0270D8869728 0x18 DateTimeFormat              ( 000186671910 ModelPrimitiveType string string string String )
            value.Culture                                   = GetObject<CultureInfo>(new IntPtr(p + 0x020), ReversePrism.DataModels.CultureInfo.FromPointer); // 0270D8869748 0x20 Culture                     ( 0001865B47C0 ModelClassType CultureInfo CultureInfo CultureInfo Pointer )

            return value;
        }
    }
}
