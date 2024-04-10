using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EventPoint                               0001865F4260 ModelPrimitiveType int int int Int32
    // 014 Rank                                     0001865F4260 ModelPrimitiveType int int int Int32
    // 018 HighScoreRank                            0001865F4260 ModelPrimitiveType int int int Int32
    public partial class ProfileEventArchiveInfoLivePopupViewModel : DataModel
    {
        public int                                      EventPoint                              { get; set; }
        public int                                      Rank                                    { get; set; }
        public int                                      HighScoreRank                           { get; set; }

        public static ProfileEventArchiveInfoLivePopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileEventArchiveInfoLivePopupViewModel() { Pointer= p0 };

            value.EventPoint                                = GetInt32(new IntPtr(p + 0x010)); // 02466560B008 0x10 EventPoint                  ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Rank                                      = GetInt32(new IntPtr(p + 0x014)); // 02466560B028 0x14 Rank                        ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.HighScoreRank                             = GetInt32(new IntPtr(p + 0x018)); // 02466560B048 0x18 HighScoreRank               ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
