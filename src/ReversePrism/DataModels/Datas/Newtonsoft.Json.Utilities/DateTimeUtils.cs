using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 InitialJavaScriptDateTicks               long IL2CPP_TYPE_I8
    // 000 IsoDateFormat                            string IL2CPP_TYPE_STRING
    // 000 DaysPer100Years                          int IL2CPP_TYPE_I4
    // 000 DaysPer400Years                          int IL2CPP_TYPE_I4
    // 000 DaysPer4Years                            int IL2CPP_TYPE_I4
    // 000 DaysPerYear                              int IL2CPP_TYPE_I4
    // 000 TicksPerDay                              long IL2CPP_TYPE_I8
    // 008 DaysToMonth365                           int[] IL2CPP_TYPE_SZARRAY
    // 010 DaysToMonth366                           000185B7DCD0 ModelPrimitiveListType int[] int[] List<int> Pointer
    public partial class DateTimeUtils : DataModel
    {
        public List<int>?                               DaysToMonth366                          { get; set; }

        public static DateTimeUtils? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DateTimeUtils() { Pointer= p0 };

            value.DaysToMonth366                            = GetInt32List(new IntPtr(p + 0x010)); // 0245A60C10E0 0x10 DaysToMonth366              ( 000185B7DCD0 ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
