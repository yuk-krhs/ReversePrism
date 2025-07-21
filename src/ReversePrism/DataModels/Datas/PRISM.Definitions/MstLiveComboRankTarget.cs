using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstSongId                                ModelPrimitiveType int int int Int32
    // 014 DifficultyLevel                          ModelPrimitiveType int int int Int32
    // 018 Rank1                                    ModelPrimitiveType int int int Int32
    // 01C Rank2                                    ModelPrimitiveType int int int Int32
    // 020 Rank3                                    ModelPrimitiveType int int int Int32
    // 024 Rank4                                    ModelPrimitiveType int int int Int32
    // 028 Rank5                                    ModelPrimitiveType int int int Int32
    // 02C Rank6                                    ModelPrimitiveType int int int Int32
    public partial class MstLiveComboRankTarget : DataModel
    {
        public int                                      MstSongId                               { get; set; }
        public int                                      DifficultyLevel                         { get; set; }
        public int                                      Rank1                                   { get; set; }
        public int                                      Rank2                                   { get; set; }
        public int                                      Rank3                                   { get; set; }
        public int                                      Rank4                                   { get; set; }
        public int                                      Rank5                                   { get; set; }
        public int                                      Rank6                                   { get; set; }

        public static MstLiveComboRankTarget? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstLiveComboRankTarget() { Pointer= p0 };

            value.MstSongId                                 = GetInt32(new IntPtr(p + 0x010)); // 0x10 MstSongId                   ( ModelPrimitiveType int int int Int32 )
            value.DifficultyLevel                           = GetInt32(new IntPtr(p + 0x014)); // 0x14 DifficultyLevel             ( ModelPrimitiveType int int int Int32 )
            value.Rank1                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 Rank1                       ( ModelPrimitiveType int int int Int32 )
            value.Rank2                                     = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Rank2                       ( ModelPrimitiveType int int int Int32 )
            value.Rank3                                     = GetInt32(new IntPtr(p + 0x020)); // 0x20 Rank3                       ( ModelPrimitiveType int int int Int32 )
            value.Rank4                                     = GetInt32(new IntPtr(p + 0x024)); // 0x24 Rank4                       ( ModelPrimitiveType int int int Int32 )
            value.Rank5                                     = GetInt32(new IntPtr(p + 0x028)); // 0x28 Rank5                       ( ModelPrimitiveType int int int Int32 )
            value.Rank6                                     = GetInt32(new IntPtr(p + 0x02C)); // 0x2C Rank6                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
