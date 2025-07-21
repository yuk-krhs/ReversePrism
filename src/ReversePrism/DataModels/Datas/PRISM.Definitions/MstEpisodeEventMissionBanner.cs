using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 MstEpisodeId                             ModelPrimitiveType int int int Int32
    // 018 MstMissionGroupId                        ModelPrimitiveType int int int Int32
    public partial class MstEpisodeEventMissionBanner : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstEpisodeId                            { get; set; }
        public int                                      MstMissionGroupId                       { get; set; }

        public static MstEpisodeEventMissionBanner? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstEpisodeEventMissionBanner() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.MstEpisodeId                              = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstEpisodeId                ( ModelPrimitiveType int int int Int32 )
            value.MstMissionGroupId                         = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstMissionGroupId           ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
