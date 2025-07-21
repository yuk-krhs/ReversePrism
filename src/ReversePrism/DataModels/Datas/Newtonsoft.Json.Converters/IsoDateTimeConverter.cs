using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DefaultDateTimeFormat                    string IL2CPP_TYPE_STRING
    // 010 DateTimeStyles                           ModelEnumType DateTimeStyles DateTimeStyles DateTimeStyles Int32
    // 018 DateTimeFormat                           ModelPrimitiveType string string string String
    // 020 Culture                                  ModelClassType CultureInfo CultureInfo CultureInfo Pointer
    public partial class IsoDateTimeConverter : DataModel
    {
        public DateTimeStyles                           DateTimeStyles                          { get; set; }
        public string                                   DateTimeFormat                          { get; set; }
        public CultureInfo?                             Culture                                 { get; set; }

        public static IsoDateTimeConverter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IsoDateTimeConverter() { Pointer= p0 };

            value.DateTimeStyles                            = (DateTimeStyles)GetInt32(new IntPtr(p + 0x010)); // 0x10 DateTimeStyles              ( ModelEnumType DateTimeStyles DateTimeStyles DateTimeStyles Int32 )
            value.DateTimeFormat                            = GetString(new IntPtr(p + 0x018)); // 0x18 DateTimeFormat              ( ModelPrimitiveType string string string String )
            value.Culture                                   = GetObject<CultureInfo>(new IntPtr(p + 0x020), ReversePrism.DataModels.CultureInfo.FromPointer); // 0x20 Culture                     ( ModelClassType CultureInfo CultureInfo CultureInfo Pointer )

            return value;
        }
    }
}
