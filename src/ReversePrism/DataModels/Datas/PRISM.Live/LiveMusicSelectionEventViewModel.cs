using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EventId                                  ModelPrimitiveType int int int Int32
    // 018 EventStartDate                           ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 028 EventEndDate                             ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    public partial class LiveMusicSelectionEventViewModel : DataModel
    {
        public int                                      EventId                                 { get; set; }
        public DateTime                                 EventStartDate                          { get; set; }
        public DateTime                                 EventEndDate                            { get; set; }

        public static LiveMusicSelectionEventViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMusicSelectionEventViewModel() { Pointer= p0 };

            value.EventId                                   = GetInt32(new IntPtr(p + 0x010)); // 0x10 EventId                     ( ModelPrimitiveType int int int Int32 )
            value.EventStartDate                            = GetDateTime(new IntPtr(p + 0x018)); // 0x18 EventStartDate              ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.EventEndDate                              = GetDateTime(new IntPtr(p + 0x028)); // 0x28 EventEndDate                ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )

            return value;
        }
    }
}
