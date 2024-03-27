using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_MediaType                              00018660B260 ModelEnumType MediaType MediaType MediaType Int32
    public partial class TrackMediaType
    {
        public MediaType                                M_MediaType                             { get; set; }

        public static TrackMediaType? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TrackMediaType();

            value.M_MediaType                               = (MediaType)GetInt32(new IntPtr(p + 0x010)); // 0270DB2A4618 0x10 M_MediaType                 ( 00018660B260 ModelEnumType MediaType MediaType MediaType Int32 )

            return value;
        }
    }
}
