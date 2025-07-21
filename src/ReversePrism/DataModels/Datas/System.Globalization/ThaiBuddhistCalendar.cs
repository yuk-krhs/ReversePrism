using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 thaiBuddhistEraInfo                      EraInfo[] IL2CPP_TYPE_SZARRAY
    // 020 Helper                                   ModelClassType GregorianCalendarHelper GregorianCalendarHelper GregorianCalendarHelper Pointer
    public partial class ThaiBuddhistCalendar : DataModel
    {
        public GregorianCalendarHelper?                 Helper                                  { get; set; }

        public static ThaiBuddhistCalendar? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ThaiBuddhistCalendar() { Pointer= p0 };

            value.Helper                                    = GetObject<GregorianCalendarHelper>(new IntPtr(p + 0x020), ReversePrism.DataModels.GregorianCalendarHelper.FromPointer); // 0x20 Helper                      ( ModelClassType GregorianCalendarHelper GregorianCalendarHelper GregorianCalendarHelper Pointer )

            return value;
        }
    }
}
