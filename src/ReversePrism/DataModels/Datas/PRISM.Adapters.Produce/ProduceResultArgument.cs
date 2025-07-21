using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UnitID                                   ModelPrimitiveType int int int Int32
    // 014 MstEpisodeID                             ModelPrimitiveType int int int Int32
    // 018 EpisodeDifficultyType                    ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32
    // 01C UnitIdolCount                            ModelPrimitiveType int int int Int32
    // 020 TotalParameter                           ModelPrimitiveType int int int Int32
    // 028 ParameterVariation                       ModelClassType IParameterVariationStatus IParameterVariationStatus IParameterVariationStatus Pointer
    // 030 Rewards                                  IEnumerable`1<IProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 038 FesUnit                                  ModelClassType IFesUnitStatus IFesUnitStatus IFesUnitStatus Pointer
    // 040 CharacterIds                             IEnumerable`1<int> IL2CPP_TYPE_GENERICINST
    // 048 UnitIdols                                ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 050 CsIDs                                    IEnumerable`1<string> IL2CPP_TYPE_GENERICINST
    // 058 IsArEffect                               ModelPrimitiveType bool bool bool Bool
    // 05C ClearCount                               ModelPrimitiveType int int int Int32
    public partial class ProduceResultArgument : DataModel
    {
        public int                                      UnitID                                  { get; set; }
        public int                                      MstEpisodeID                            { get; set; }
        public ProduceDifficultyType                    EpisodeDifficultyType                   { get; set; }
        public int                                      UnitIdolCount                           { get; set; }
        public int                                      TotalParameter                          { get; set; }
        public IParameterVariationStatus?               ParameterVariation                      { get; set; }
        public IFesUnitStatus?                          FesUnit                                 { get; set; }
        public List<UnitIdol>?                          UnitIdols                               { get; set; }
        public bool                                     IsArEffect                              { get; set; }
        public int                                      ClearCount                              { get; set; }

        public static ProduceResultArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceResultArgument() { Pointer= p0 };

            value.UnitID                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 UnitID                      ( ModelPrimitiveType int int int Int32 )
            value.MstEpisodeID                              = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstEpisodeID                ( ModelPrimitiveType int int int Int32 )
            value.EpisodeDifficultyType                     = (ProduceDifficultyType)GetInt32(new IntPtr(p + 0x018)); // 0x18 EpisodeDifficultyType       ( ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32 )
            value.UnitIdolCount                             = GetInt32(new IntPtr(p + 0x01C)); // 0x1C UnitIdolCount               ( ModelPrimitiveType int int int Int32 )
            value.TotalParameter                            = GetInt32(new IntPtr(p + 0x020)); // 0x20 TotalParameter              ( ModelPrimitiveType int int int Int32 )
            value.ParameterVariation                        = GetObject<IParameterVariationStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IParameterVariationStatus.FromPointer); // 0x28 ParameterVariation          ( ModelClassType IParameterVariationStatus IParameterVariationStatus IParameterVariationStatus Pointer )
            value.FesUnit                                   = GetObject<IFesUnitStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IFesUnitStatus.FromPointer); // 0x38 FesUnit                     ( ModelClassType IFesUnitStatus IFesUnitStatus IFesUnitStatus Pointer )
            value.UnitIdols                                 = GetObjectList<UnitIdol>(new IntPtr(p + 0x048), ReversePrism.DataModels.UnitIdol.FromPointer); // 0x48 UnitIdols                   ( ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.IsArEffect                                = GetBool(new IntPtr(p + 0x058)); // 0x58 IsArEffect                  ( ModelPrimitiveType bool bool bool Bool )
            value.ClearCount                                = GetInt32(new IntPtr(p + 0x05C)); // 0x5C ClearCount                  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
