using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 m_hebrewNumberParser                     MatchNumberDelegate IL2CPP_TYPE_CLASS
    // 008 dateParsingStates                        DS[][] IL2CPP_TYPE_SZARRAY
    public partial class DateTimeParse : DataModel
    {

        public static DateTimeParse? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DateTimeParse() { Pointer= p0 };


            return value;
        }
    }
}
