using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 taiwanEraInfo                            EraInfo[] IL2CPP_TYPE_SZARRAY
    // 008 s_defaultInstance                        Calendar IL2CPP_TYPE_CLASS
    // 020 Helper                                   ModelClassType GregorianCalendarHelper GregorianCalendarHelper GregorianCalendarHelper Pointer
    // 010 CalendarMinValue                         ModelPrimitiveType DateTime DateTime DateTime DateTime
    public partial class TaiwanCalendar : DataModel
    {
        public GregorianCalendarHelper?                 Helper                                  { get; set; }
        public DateTime                                 CalendarMinValue                        { get; set; }

        public static TaiwanCalendar? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TaiwanCalendar() { Pointer= p0 };

            value.Helper                                    = GetObject<GregorianCalendarHelper>(new IntPtr(p + 0x020), ReversePrism.DataModels.GregorianCalendarHelper.FromPointer); // 0x20 Helper                      ( ModelClassType GregorianCalendarHelper GregorianCalendarHelper GregorianCalendarHelper Pointer )
            value.CalendarMinValue                          = GetDateTime(new IntPtr(p + 0x010)); // 0x10 CalendarMinValue            ( ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
