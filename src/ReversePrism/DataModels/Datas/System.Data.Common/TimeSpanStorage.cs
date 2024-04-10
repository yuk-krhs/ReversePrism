using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_defaultValue                           TimeSpan IL2CPP_TYPE_VALUETYPE
    // 050 Values                                   000185CABAB8 ModelEnumListType TimeSpan[] TimeSpan[] List<TimeSpan> Pointer
    public partial class TimeSpanStorage : DataModel
    {
        public List<TimeSpan>?                          Values                                  { get; set; }

        public static TimeSpanStorage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimeSpanStorage() { Pointer= p0 };

            value.Values                                    = GetEnumList<TimeSpan>(new IntPtr(p + 0x050)); // 024668A60180 0x50 Values                      ( 000185CABAB8 ModelEnumListType TimeSpan[] TimeSpan[] List<TimeSpan> Pointer )

            return value;
        }
    }
}
