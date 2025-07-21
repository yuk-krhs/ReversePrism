using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 HijriEra                                 int IL2CPP_TYPE_I4
    // 008 HijriMonthDays                           int[] IL2CPP_TYPE_SZARRAY
    // 020 M_HijriAdvance                           ModelPrimitiveType int int int Int32
    // 010 CalendarMinValue                         ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 018 CalendarMaxValue                         ModelPrimitiveType DateTime DateTime DateTime DateTime
    public partial class HijriCalendar : DataModel
    {
        public int                                      M_HijriAdvance                          { get; set; }
        public DateTime                                 CalendarMinValue                        { get; set; }
        public DateTime                                 CalendarMaxValue                        { get; set; }

        public static HijriCalendar? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HijriCalendar() { Pointer= p0 };

            value.M_HijriAdvance                            = GetInt32(new IntPtr(p + 0x020)); // 0x20 M_HijriAdvance              ( ModelPrimitiveType int int int Int32 )
            value.CalendarMinValue                          = GetDateTime(new IntPtr(p + 0x010)); // 0x10 CalendarMinValue            ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.CalendarMaxValue                          = GetDateTime(new IntPtr(p + 0x018)); // 0x18 CalendarMaxValue            ( ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
