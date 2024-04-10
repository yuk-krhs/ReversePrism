using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_type                                   0001866996C0 ModelEnumType GregorianCalendarTypes GregorianCalendarTypes GregorianCalendarTypes Int32
    // 000 DaysToMonth365                           int[] IL2CPP_TYPE_SZARRAY
    // 008 DaysToMonth366                           int[] IL2CPP_TYPE_SZARRAY
    // 010 S_defaultInstance                        0001865A1400 ModelClassType Calendar Calendar Calendar Pointer
    public partial class GregorianCalendar : DataModel
    {
        public GregorianCalendarTypes                   M_type                                  { get; set; }
        public Calendar?                                S_defaultInstance                       { get; set; }

        public static GregorianCalendar? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GregorianCalendar() { Pointer= p0 };

            value.M_type                                    = (GregorianCalendarTypes)GetInt32(new IntPtr(p + 0x020)); // 0245A3CB5648 0x20 M_type                      ( 0001866996C0 ModelEnumType GregorianCalendarTypes GregorianCalendarTypes GregorianCalendarTypes Int32 )
            value.S_defaultInstance                         = GetObject<Calendar>(new IntPtr(p + 0x010), ReversePrism.DataModels.Calendar.FromPointer); // 0245A3CB56A8 0x10 S_defaultInstance           ( 0001865A1400 ModelClassType Calendar Calendar Calendar Pointer )

            return value;
        }
    }
}
