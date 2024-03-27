using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UnitID                                   0001865F4940 ModelPrimitiveType int int int Int32
    // 014 EpisodeID                                0001865F4940 ModelPrimitiveType int int int Int32
    // 018 Chapter                                  0001865F4940 ModelPrimitiveType int int int Int32
    // 01C Difficulty                               00018660C140 ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32
    // 020 ProduceUnitModel                         00018659BE50 ModelClassType ProduceUnitModel ProduceUnitModel ProduceUnitModel Pointer
    // 028 ProduceBoost                             0001865F4940 ModelPrimitiveType int int int Int32
    public partial class ProduceAutoModeArgument
    {
        public int                                      UnitID                                  { get; set; }
        public int                                      EpisodeID                               { get; set; }
        public int                                      Chapter                                 { get; set; }
        public ProduceDifficultyType                    Difficulty                              { get; set; }
        public ProduceUnitModel?                        ProduceUnitModel                        { get; set; }
        public int                                      ProduceBoost                            { get; set; }

        public static ProduceAutoModeArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceAutoModeArgument();

            value.UnitID                                    = GetInt32(new IntPtr(p + 0x010)); // 0270D64704B8 0x10 UnitID                      ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.EpisodeID                                 = GetInt32(new IntPtr(p + 0x014)); // 0270D64704D8 0x14 EpisodeID                   ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.Chapter                                   = GetInt32(new IntPtr(p + 0x018)); // 0270D64704F8 0x18 Chapter                     ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.Difficulty                                = (ProduceDifficultyType)GetInt32(new IntPtr(p + 0x01C)); // 0270D6470518 0x1C Difficulty                  ( 00018660C140 ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32 )
            value.ProduceUnitModel                          = GetObject<ProduceUnitModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceUnitModel.FromPointer); // 0270D6470538 0x20 ProduceUnitModel            ( 00018659BE50 ModelClassType ProduceUnitModel ProduceUnitModel ProduceUnitModel Pointer )
            value.ProduceBoost                              = GetInt32(new IntPtr(p + 0x028)); // 0270D6470558 0x28 ProduceBoost                ( 0001865F4940 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
