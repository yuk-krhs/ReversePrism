using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 MstEpisodeId                             0001865F4260 ModelPrimitiveType int int int Int32
    // 018 MstMissionGroupId                        0001865F4260 ModelPrimitiveType int int int Int32
    public partial class MstEpisodeEventMissionBanner
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstEpisodeId                            { get; set; }
        public int                                      MstMissionGroupId                       { get; set; }

        public static MstEpisodeEventMissionBanner? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstEpisodeEventMissionBanner();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 02700461DB30 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstEpisodeId                              = GetInt32(new IntPtr(p + 0x014)); // 02700461DB50 0x14 MstEpisodeId                ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstMissionGroupId                         = GetInt32(new IntPtr(p + 0x018)); // 02700461DB70 0x18 MstMissionGroupId           ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
