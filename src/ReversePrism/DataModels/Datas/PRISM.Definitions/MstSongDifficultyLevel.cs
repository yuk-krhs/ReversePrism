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
    // 018 SongLevel                                ModelPrimitiveType int int int Int32
    // 01C Notes                                    ModelPrimitiveType int int int Int32
    public partial class MstSongDifficultyLevel : DataModel
    {
        public int                                      MstSongId                               { get; set; }
        public int                                      DifficultyLevel                         { get; set; }
        public int                                      SongLevel                               { get; set; }
        public int                                      Notes                                   { get; set; }

        public static MstSongDifficultyLevel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstSongDifficultyLevel() { Pointer= p0 };

            value.MstSongId                                 = GetInt32(new IntPtr(p + 0x010)); // 0x10 MstSongId                   ( ModelPrimitiveType int int int Int32 )
            value.DifficultyLevel                           = GetInt32(new IntPtr(p + 0x014)); // 0x14 DifficultyLevel             ( ModelPrimitiveType int int int Int32 )
            value.SongLevel                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 SongLevel                   ( ModelPrimitiveType int int int Int32 )
            value.Notes                                     = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Notes                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
