using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MovieCategory                            0001866570F0 ModelEnumType MovieCategory MovieCategory MovieCategory Int32
    // 014 MstProduceIdolId                         0001865F4260 ModelPrimitiveType int int int Int32
    // 018 MstSupportCharacterId                    0001865F4260 ModelPrimitiveType int int int Int32
    // 01C MstCharacterInfoId                       0001865F4260 ModelPrimitiveType int int int Int32
    // 020 Star                                     0001865F4260 ModelPrimitiveType int int int Int32
    // 024 UnitId                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 028 MoviePlayerModel                         000186659670 ModelClassType MoviePlayerModel MoviePlayerModel MoviePlayerModel Pointer
    // 030 SupportCharacterRarity                   0001866201C0 ModelEnumType SupportCharacterRarity SupportCharacterRarity SupportCharacterRarity Int32
    public partial class MovieCategoryGridCellViewModel
    {
        public MovieCategory                            MovieCategory                           { get; set; }
        public int                                      MstProduceIdolId                        { get; set; }
        public int                                      MstSupportCharacterId                   { get; set; }
        public int                                      MstCharacterInfoId                      { get; set; }
        public int                                      Star                                    { get; set; }
        public int                                      UnitId                                  { get; set; }
        public MoviePlayerModel?                        MoviePlayerModel                        { get; set; }
        public SupportCharacterRarity                   SupportCharacterRarity                  { get; set; }

        public static MovieCategoryGridCellViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MovieCategoryGridCellViewModel();

            value.MovieCategory                             = (MovieCategory)GetInt32(new IntPtr(p + 0x010)); // 0270D6124A60 0x10 MovieCategory               ( 0001866570F0 ModelEnumType MovieCategory MovieCategory MovieCategory Int32 )
            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x014)); // 0270D6124A80 0x14 MstProduceIdolId            ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstSupportCharacterId                     = GetInt32(new IntPtr(p + 0x018)); // 0270D6124AA0 0x18 MstSupportCharacterId       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x01C)); // 0270D6124AC0 0x1C MstCharacterInfoId          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Star                                      = GetInt32(new IntPtr(p + 0x020)); // 0270D6124AE0 0x20 Star                        ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.UnitId                                    = GetInt32(new IntPtr(p + 0x024)); // 0270D6124B00 0x24 UnitId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MoviePlayerModel                          = GetObject<MoviePlayerModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.MoviePlayerModel.FromPointer); // 0270D6124B20 0x28 MoviePlayerModel            ( 000186659670 ModelClassType MoviePlayerModel MoviePlayerModel MoviePlayerModel Pointer )
            value.SupportCharacterRarity                    = (SupportCharacterRarity)GetInt32(new IntPtr(p + 0x030)); // 0270D6124B40 0x30 SupportCharacterRarity      ( 0001866201C0 ModelEnumType SupportCharacterRarity SupportCharacterRarity SupportCharacterRarity Int32 )

            return value;
        }
    }
}
