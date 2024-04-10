using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ProduceUnitModel                         00018659B940 ModelClassType ProduceUnitModel ProduceUnitModel ProduceUnitModel Pointer
    // 018 GameMode                                 0001865EA840 ModelEnumType GameMode GameMode GameMode Int32
    // 01C ProduceRank                              00018660DB60 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32
    // 020 CurrentProduceScenarioId                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 CurrentEpisode                           0001867618B0 ModelClassType IEpisodeStatus IEpisodeStatus IEpisodeStatus Pointer
    // 030 CurrentProduceDifficulty                 00018660BEF0 ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32
    // 038 Model3DScene                             000186671910 ModelPrimitiveType string string string String
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

            value.ProduceUnitModel                          = GetObject<ProduceUnitModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProduceUnitModel.FromPointer); // 024660B1B2B0 0x10 ProduceUnitModel            ( 00018659B940 ModelClassType ProduceUnitModel ProduceUnitModel ProduceUnitModel Pointer )
            value.GameMode                                  = (GameMode)GetInt32(new IntPtr(p + 0x018)); // 024660B1B2D0 0x18 GameMode                    ( 0001865EA840 ModelEnumType GameMode GameMode GameMode Int32 )
            value.ProduceRank                               = (ProduceParameterRank)GetInt32(new IntPtr(p + 0x01C)); // 024660B1B2F0 0x1C ProduceRank                 ( 00018660DB60 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32 )
            value.CurrentProduceScenarioId                  = GetInt32(new IntPtr(p + 0x020)); // 024660B1B310 0x20 CurrentProduceScenarioId    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentEpisode                            = GetObject<IEpisodeStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IEpisodeStatus.FromPointer); // 024660B1B330 0x28 CurrentEpisode              ( 0001867618B0 ModelClassType IEpisodeStatus IEpisodeStatus IEpisodeStatus Pointer )
            value.CurrentProduceDifficulty                  = (ProduceDifficultyType)GetInt32(new IntPtr(p + 0x030)); // 024660B1B350 0x30 CurrentProduceDifficulty    ( 00018660BEF0 ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32 )
            value.Model3DScene                              = GetString(new IntPtr(p + 0x038)); // 024660B1B370 0x38 Model3DScene                ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
