using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UnitID                                   ModelPrimitiveType int int int Int32
    // 014 EpisodeID                                ModelPrimitiveType int int int Int32
    // 018 Chapter                                  ModelPrimitiveType int int int Int32
    // 01C Difficulty                               ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32
    // 020 ProduceUnitModel                         ModelClassType ProduceUnitModel ProduceUnitModel ProduceUnitModel Pointer
    // 028 ProduceBoost                             ModelPrimitiveType int int int Int32
    public partial class LegacyProduceAutoModeParameter : DataModel
    {
        public int                                      UnitID                                  { get; set; }
        public int                                      EpisodeID                               { get; set; }
        public int                                      Chapter                                 { get; set; }
        public ProduceDifficultyType                    Difficulty                              { get; set; }
        public ProduceUnitModel?                        ProduceUnitModel                        { get; set; }
        public int                                      ProduceBoost                            { get; set; }

        public static LegacyProduceAutoModeParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LegacyProduceAutoModeParameter() { Pointer= p0 };

            value.UnitID                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 UnitID                      ( ModelPrimitiveType int int int Int32 )
            value.EpisodeID                                 = GetInt32(new IntPtr(p + 0x014)); // 0x14 EpisodeID                   ( ModelPrimitiveType int int int Int32 )
            value.Chapter                                   = GetInt32(new IntPtr(p + 0x018)); // 0x18 Chapter                     ( ModelPrimitiveType int int int Int32 )
            value.Difficulty                                = (ProduceDifficultyType)GetInt32(new IntPtr(p + 0x01C)); // 0x1C Difficulty                  ( ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32 )
            value.ProduceUnitModel                          = GetObject<ProduceUnitModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceUnitModel.FromPointer); // 0x20 ProduceUnitModel            ( ModelClassType ProduceUnitModel ProduceUnitModel ProduceUnitModel Pointer )
            value.ProduceBoost                              = GetInt32(new IntPtr(p + 0x028)); // 0x28 ProduceBoost                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
