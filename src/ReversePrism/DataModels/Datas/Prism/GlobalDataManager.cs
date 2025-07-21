using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ProduceUnitModel                         ModelClassType ProduceUnitModel ProduceUnitModel ProduceUnitModel Pointer
    // 018 GameMode                                 ModelEnumType GameMode GameMode GameMode Int32
    // 01C ProduceRank                              ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32
    // 020 CurrentProduceScenarioId                 ModelPrimitiveType int int int Int32
    // 028 CurrentEpisode                           ModelClassType IEpisodeStatus IEpisodeStatus IEpisodeStatus Pointer
    // 030 CurrentProduceDifficulty                 ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32
    // 038 Model3DScene                             ModelPrimitiveType string string string String
    // 000 dummyIdolArray                           UnitIdol[] IL2CPP_TYPE_SZARRAY
    // 040 SkitAction                               Action`1<bool> IL2CPP_TYPE_GENERICINST
    public partial class GlobalDataManager : DataModel
    {
        public ProduceUnitModel?                        ProduceUnitModel                        { get; set; }
        public GameMode                                 GameMode                                { get; set; }
        public ProduceParameterRank                     ProduceRank                             { get; set; }
        public int                                      CurrentProduceScenarioId                { get; set; }
        public IEpisodeStatus?                          CurrentEpisode                          { get; set; }
        public ProduceDifficultyType                    CurrentProduceDifficulty                { get; set; }
        public string                                   Model3DScene                            { get; set; }

        public static GlobalDataManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GlobalDataManager() { Pointer= p0 };

            value.ProduceUnitModel                          = GetObject<ProduceUnitModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProduceUnitModel.FromPointer); // 0x10 ProduceUnitModel            ( ModelClassType ProduceUnitModel ProduceUnitModel ProduceUnitModel Pointer )
            value.GameMode                                  = (GameMode)GetInt32(new IntPtr(p + 0x018)); // 0x18 GameMode                    ( ModelEnumType GameMode GameMode GameMode Int32 )
            value.ProduceRank                               = (ProduceParameterRank)GetInt32(new IntPtr(p + 0x01C)); // 0x1C ProduceRank                 ( ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32 )
            value.CurrentProduceScenarioId                  = GetInt32(new IntPtr(p + 0x020)); // 0x20 CurrentProduceScenarioId    ( ModelPrimitiveType int int int Int32 )
            value.CurrentEpisode                            = GetObject<IEpisodeStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IEpisodeStatus.FromPointer); // 0x28 CurrentEpisode              ( ModelClassType IEpisodeStatus IEpisodeStatus IEpisodeStatus Pointer )
            value.CurrentProduceDifficulty                  = (ProduceDifficultyType)GetInt32(new IntPtr(p + 0x030)); // 0x30 CurrentProduceDifficulty    ( ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32 )
            value.Model3DScene                              = GetString(new IntPtr(p + 0x038)); // 0x38 Model3DScene                ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
