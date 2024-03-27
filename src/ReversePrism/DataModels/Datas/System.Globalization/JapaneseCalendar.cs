using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 calendarMinValue                         DateTime IL2CPP_TYPE_VALUETYPE
    // 008 japaneseEraInfo                          EraInfo[] IL2CPP_TYPE_SZARRAY
    // 010 S_defaultInstance                        0001865A1630 ModelClassType Calendar Calendar Calendar Pointer
    // 020 Helper                                   0001866991E0 ModelClassType GregorianCalendarHelper GregorianCalendarHelper GregorianCalendarHelper Pointer
    public partial class JapaneseCalendar
    {
        public Calendar?                                S_defaultInstance                       { get; set; }
        public GregorianCalendarHelper?                 Helper                                  { get; set; }

        public static JapaneseCalendar? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JapaneseCalendar();

            value.S_defaultInstance                         = GetObject<Calendar>(new IntPtr(p + 0x010), ReversePrism.DataModels.Calendar.FromPointer); // 0270D306A240 0x10 S_defaultInstance           ( 0001865A1630 ModelClassType Calendar Calendar Calendar Pointer )
            value.Helper                                    = GetObject<GregorianCalendarHelper>(new IntPtr(p + 0x020), ReversePrism.DataModels.GregorianCalendarHelper.FromPointer); // 0270D306A260 0x20 Helper                      ( 0001866991E0 ModelClassType GregorianCalendarHelper GregorianCalendarHelper GregorianCalendarHelper Pointer )

            return value;
        }
    }
}
