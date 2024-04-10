using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UnitID                                   0001865F4940 ModelPrimitiveType int int int Int32
    // 014 MstEpisodeID                             0001865F4940 ModelPrimitiveType int int int Int32
    // 018 EpisodeDifficultyType                    00018660C3C0 ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32
    // 01C UnitIdolCount                            0001865F4940 ModelPrimitiveType int int int Int32
    // 020 TotalParameter                           0001865F4940 ModelPrimitiveType int int int Int32
    // 028 ParameterVariation                       0001865D2650 ModelClassType IParameterVariationStatus IParameterVariationStatus IParameterVariationStatus Pointer
    // 030 UnitRank                                 00018660E020 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32
    // 038 Rewards                                  IEnumerable`1<IProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    public partial class ProduceResultRewardViewModel : DataModel
    {
        public int                                      UnitID                                  { get; set; }
        public int                                      MstEpisodeID                            { get; set; }
        public ProduceDifficultyType                    EpisodeDifficultyType                   { get; set; }
        public int                                      UnitIdolCount                           { get; set; }
        public int                                      TotalParameter                          { get; set; }
        public IParameterVariationStatus?               ParameterVariation                      { get; set; }
        public ProduceParameterRank                     UnitRank                                { get; set; }

        public static ProduceResultRewardViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceResultRewardViewModel() { Pointer= p0 };

            value.UnitID                                    = GetInt32(new IntPtr(p + 0x010)); // 02466689C178 0x10 UnitID                      ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.MstEpisodeID                              = GetInt32(new IntPtr(p + 0x014)); // 02466689C198 0x14 MstEpisodeID                ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.EpisodeDifficultyType                     = (ProduceDifficultyType)GetInt32(new IntPtr(p + 0x018)); // 02466689C1B8 0x18 EpisodeDifficultyType       ( 00018660C3C0 ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32 )
            value.UnitIdolCount                             = GetInt32(new IntPtr(p + 0x01C)); // 02466689C1D8 0x1C UnitIdolCount               ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.TotalParameter                            = GetInt32(new IntPtr(p + 0x020)); // 02466689C1F8 0x20 TotalParameter              ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.ParameterVariation                        = GetObject<IParameterVariationStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IParameterVariationStatus.FromPointer); // 02466689C218 0x28 ParameterVariation          ( 0001865D2650 ModelClassType IParameterVariationStatus IParameterVariationStatus IParameterVariationStatus Pointer )
            value.UnitRank                                  = (ProduceParameterRank)GetInt32(new IntPtr(p + 0x030)); // 02466689C238 0x30 UnitRank                    ( 00018660E020 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32 )

            return value;
        }
    }
}
