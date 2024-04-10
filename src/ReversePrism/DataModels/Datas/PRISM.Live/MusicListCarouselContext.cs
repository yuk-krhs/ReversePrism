using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 <DisplayType>k__BackingField             ReactiveProperty`1<MusicListSwitchDisplayType> IL2CPP_TYPE_GENERICINST
    // 038 Difficulty                               00018661C520 ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32
    // 03C CellInterval                             0001866656B0 ModelPrimitiveType float float float Single
    // 040 CenterCellXOffset                        0001866656B0 ModelPrimitiveType float float float Single
    // 044 IsListUnderDragging                      000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class MusicListCarouselContext : DataModel
    {
        public SongDifficultyLevel                      Difficulty                              { get; set; }
        public float                                    CellInterval                            { get; set; }
        public float                                    CenterCellXOffset                       { get; set; }
        public bool                                     IsListUnderDragging                     { get; set; }

        public static MusicListCarouselContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicListCarouselContext() { Pointer= p0 };

            value.Difficulty                                = (SongDifficultyLevel)GetInt32(new IntPtr(p + 0x038)); // 0246651E3AC8 0x38 Difficulty                  ( 00018661C520 ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32 )
            value.CellInterval                              = GetSingle(new IntPtr(p + 0x03C)); // 0246651E3AE8 0x3C CellInterval                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CenterCellXOffset                         = GetSingle(new IntPtr(p + 0x040)); // 0246651E3B08 0x40 CenterCellXOffset           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.IsListUnderDragging                       = GetBool(new IntPtr(p + 0x044)); // 0246651E3B28 0x44 IsListUnderDragging         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
