using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 <DisplayType>k__BackingField             ReactiveProperty`1<MusicListSwitchDisplayType> IL2CPP_TYPE_GENERICINST
    // 040 Difficulty                               ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32
    // 044 CellInterval                             ModelPrimitiveType float float float Single
    // 048 CenterCellXOffset                        ModelPrimitiveType float float float Single
    // 04C IsListUnderDragging                      ModelPrimitiveType bool bool bool Bool
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

            value.Difficulty                                = (SongDifficultyLevel)GetInt32(new IntPtr(p + 0x040)); // 0x40 Difficulty                  ( ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32 )
            value.CellInterval                              = GetSingle(new IntPtr(p + 0x044)); // 0x44 CellInterval                ( ModelPrimitiveType float float float Single )
            value.CenterCellXOffset                         = GetSingle(new IntPtr(p + 0x048)); // 0x48 CenterCellXOffset           ( ModelPrimitiveType float float float Single )
            value.IsListUnderDragging                       = GetBool(new IntPtr(p + 0x04C)); // 0x4C IsListUnderDragging         ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
