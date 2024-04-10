using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SelectedUnitId                           0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 SelectedEpisodeId                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 SelectedDifficultyLevel                  00018660C140 ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32
    // 030 ReleasedDifficultyLevelDictionary        Dictionary`2<string, ProduceDifficultyType> IL2CPP_TYPE_GENERICINST
    // 038 LastPlayDifficultyLevelDictionary        Dictionary`2<string, ProduceDifficultyType> IL2CPP_TYPE_GENERICINST
    public partial class ProducePreparationEpisodeSelectSaveData : DataModel
    {
        public int                                      SelectedUnitId                          { get; set; }
        public int                                      SelectedEpisodeId                       { get; set; }
        public ProduceDifficultyType                    SelectedDifficultyLevel                 { get; set; }

        public static ProducePreparationEpisodeSelectSaveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProducePreparationEpisodeSelectSaveData() { Pointer= p0 };

            value.SelectedUnitId                            = GetInt32(new IntPtr(p + 0x020)); // 0245A3A80790 0x20 SelectedUnitId              ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SelectedEpisodeId                         = GetInt32(new IntPtr(p + 0x024)); // 0245A3A807B0 0x24 SelectedEpisodeId           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SelectedDifficultyLevel                   = (ProduceDifficultyType)GetInt32(new IntPtr(p + 0x028)); // 0245A3A807D0 0x28 SelectedDifficultyLevel     ( 00018660C140 ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32 )

            return value;
        }
    }
}
