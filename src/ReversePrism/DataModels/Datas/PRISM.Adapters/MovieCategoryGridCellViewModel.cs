using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MovieCategory                            ModelEnumType MovieCategory MovieCategory MovieCategory Int32
    // 014 MstProduceIdolId                         ModelPrimitiveType int int int Int32
    // 018 MstSupportCharacterId                    ModelPrimitiveType int int int Int32
    // 01C MstCharacterInfoId                       ModelPrimitiveType int int int Int32
    // 020 Star                                     ModelPrimitiveType int int int Int32
    // 024 UnitId                                   ModelPrimitiveType int int int Int32
    // 028 MoviePlayerModel                         ModelClassType MoviePlayerModel MoviePlayerModel MoviePlayerModel Pointer
    // 030 SupportCharacterRarity                   ModelEnumType SupportCharacterRarity SupportCharacterRarity SupportCharacterRarity Int32
    public partial class MovieCategoryGridCellViewModel : DataModel
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
            var value   = new MovieCategoryGridCellViewModel() { Pointer= p0 };

            value.MovieCategory                             = (MovieCategory)GetInt32(new IntPtr(p + 0x010)); // 0x10 MovieCategory               ( ModelEnumType MovieCategory MovieCategory MovieCategory Int32 )
            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstProduceIdolId            ( ModelPrimitiveType int int int Int32 )
            value.MstSupportCharacterId                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstSupportCharacterId       ( ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MstCharacterInfoId          ( ModelPrimitiveType int int int Int32 )
            value.Star                                      = GetInt32(new IntPtr(p + 0x020)); // 0x20 Star                        ( ModelPrimitiveType int int int Int32 )
            value.UnitId                                    = GetInt32(new IntPtr(p + 0x024)); // 0x24 UnitId                      ( ModelPrimitiveType int int int Int32 )
            value.MoviePlayerModel                          = GetObject<MoviePlayerModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.MoviePlayerModel.FromPointer); // 0x28 MoviePlayerModel            ( ModelClassType MoviePlayerModel MoviePlayerModel MoviePlayerModel Pointer )
            value.SupportCharacterRarity                    = (SupportCharacterRarity)GetInt32(new IntPtr(p + 0x030)); // 0x30 SupportCharacterRarity      ( ModelEnumType SupportCharacterRarity SupportCharacterRarity SupportCharacterRarity Int32 )

            return value;
        }
    }
}
