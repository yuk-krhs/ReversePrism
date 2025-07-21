using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstEpisodeId                             ModelPrimitiveType int int int Int32
    // 014 Season                                   ModelPrimitiveType int int int Int32
    // 018 MstSubSeasonId                           ModelPrimitiveType int int int Int32
    // 01C MstIdolId                                ModelPrimitiveType int int int Int32
    public partial class SelectSubSeasonData : DataModel
    {
        public int                                      MstEpisodeId                            { get; set; }
        public int                                      Season                                  { get; set; }
        public int                                      MstSubSeasonId                          { get; set; }
        public int                                      MstIdolId                               { get; set; }

        public static SelectSubSeasonData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SelectSubSeasonData() { Pointer= p0 };

            value.MstEpisodeId                              = GetInt32(new IntPtr(p + 0x010)); // 0x10 MstEpisodeId                ( ModelPrimitiveType int int int Int32 )
            value.Season                                    = GetInt32(new IntPtr(p + 0x014)); // 0x14 Season                      ( ModelPrimitiveType int int int Int32 )
            value.MstSubSeasonId                            = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstSubSeasonId              ( ModelPrimitiveType int int int Int32 )
            value.MstIdolId                                 = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MstIdolId                   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
