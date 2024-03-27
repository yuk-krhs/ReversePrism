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
    // 030 Rewards                                  IEnumerable`1<IProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 038 FesUnit                                  00018650A5E0 ModelClassType IFesUnitStatus IFesUnitStatus IFesUnitStatus Pointer
    // 040 CharacterIds                             IEnumerable`1<int> IL2CPP_TYPE_GENERICINST
    // 048 UnitIdols                                000185CAF558 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 050 CsIDs                                    IEnumerable`1<string> IL2CPP_TYPE_GENERICINST
    // 058 IsArEffect                               000186596AF0 ModelPrimitiveType bool bool bool Bool
    // 05C ClearCount                               0001865F4940 ModelPrimitiveType int int int Int32
    public partial class ProduceResultArgument
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
            var value   = new ProduceResultArgument();

            value.UnitID                                    = GetInt32(new IntPtr(p + 0x010)); // 0270D68396A8 0x10 UnitID                      ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.MstEpisodeID                              = GetInt32(new IntPtr(p + 0x014)); // 0270D68396C8 0x14 MstEpisodeID                ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.EpisodeDifficultyType                     = (ProduceDifficultyType)GetInt32(new IntPtr(p + 0x018)); // 0270D68396E8 0x18 EpisodeDifficultyType       ( 00018660C3C0 ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32 )
            value.UnitIdolCount                             = GetInt32(new IntPtr(p + 0x01C)); // 0270D6839708 0x1C UnitIdolCount               ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.TotalParameter                            = GetInt32(new IntPtr(p + 0x020)); // 0270D6839728 0x20 TotalParameter              ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.ParameterVariation                        = GetObject<IParameterVariationStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IParameterVariationStatus.FromPointer); // 0270D6839748 0x28 ParameterVariation          ( 0001865D2650 ModelClassType IParameterVariationStatus IParameterVariationStatus IParameterVariationStatus Pointer )
            value.FesUnit                                   = GetObject<IFesUnitStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IFesUnitStatus.FromPointer); // 0270D6839788 0x38 FesUnit                     ( 00018650A5E0 ModelClassType IFesUnitStatus IFesUnitStatus IFesUnitStatus Pointer )
            value.UnitIdols                                 = GetObjectList<UnitIdol>(new IntPtr(p + 0x048), ReversePrism.DataModels.UnitIdol.FromPointer); // 0270D68397C8 0x48 UnitIdols                   ( 000185CAF558 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.IsArEffect                                = GetBool(new IntPtr(p + 0x058)); // 0270D6839808 0x58 IsArEffect                  ( 000186596AF0 ModelPrimitiveType bool bool bool Bool )
            value.ClearCount                                = GetInt32(new IntPtr(p + 0x05C)); // 0270D6839828 0x5C ClearCount                  ( 0001865F4940 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
