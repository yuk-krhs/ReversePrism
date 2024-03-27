using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EventId                                  0001865F4260 ModelPrimitiveType int int int Int32
    // 018 EventStartDate                           000185D00B98 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 028 EventEndDate                             000185D00B98 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    public partial class LiveMusicSelectionEventViewModel
    {
        public int                                      EventId                                 { get; set; }
        public DateTime                                 EventStartDate                          { get; set; }
        public DateTime                                 EventEndDate                            { get; set; }

        public static LiveMusicSelectionEventViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMusicSelectionEventViewModel();

            value.EventId                                   = GetInt32(new IntPtr(p + 0x010)); // 0270D5135AD8 0x10 EventId                     ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.EventStartDate                            = GetDateTime(new IntPtr(p + 0x018)); // 0270D5135AF8 0x18 EventStartDate              ( 000185D00B98 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.EventEndDate                              = GetDateTime(new IntPtr(p + 0x028)); // 0270D5135B18 0x28 EventEndDate                ( 000185D00B98 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )

            return value;
        }
    }
}
