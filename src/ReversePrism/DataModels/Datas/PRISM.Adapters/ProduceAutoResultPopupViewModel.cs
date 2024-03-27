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
    // 018 Difficulty                               00018660C3C0 ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32
    // 020 UnitIdols                                000185CAF558 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 028 ProduceUnitModel                         00018659BE50 ModelClassType ProduceUnitModel ProduceUnitModel ProduceUnitModel Pointer
    // 030 ProduceBoost                             0001865F4940 ModelPrimitiveType int int int Int32
    public partial class ProduceAutoResultPopupViewModel
    {
        public int                                      UnitID                                  { get; set; }
        public int                                      EpisodeID                               { get; set; }
        public ProduceDifficultyType                    Difficulty                              { get; set; }
        public List<UnitIdol>?                          UnitIdols                               { get; set; }
        public ProduceUnitModel?                        ProduceUnitModel                        { get; set; }
        public int                                      ProduceBoost                            { get; set; }

        public static ProduceAutoResultPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceAutoResultPopupViewModel();

            value.UnitID                                    = GetInt32(new IntPtr(p + 0x010)); // 0270D6451650 0x10 UnitID                      ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.EpisodeID                                 = GetInt32(new IntPtr(p + 0x014)); // 0270D6451670 0x14 EpisodeID                   ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.Difficulty                                = (ProduceDifficultyType)GetInt32(new IntPtr(p + 0x018)); // 0270D6451690 0x18 Difficulty                  ( 00018660C3C0 ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32 )
            value.UnitIdols                                 = GetObjectList<UnitIdol>(new IntPtr(p + 0x020), ReversePrism.DataModels.UnitIdol.FromPointer); // 0270D64516B0 0x20 UnitIdols                   ( 000185CAF558 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.ProduceUnitModel                          = GetObject<ProduceUnitModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceUnitModel.FromPointer); // 0270D64516D0 0x28 ProduceUnitModel            ( 00018659BE50 ModelClassType ProduceUnitModel ProduceUnitModel ProduceUnitModel Pointer )
            value.ProduceBoost                              = GetInt32(new IntPtr(p + 0x030)); // 0270D64516F0 0x30 ProduceBoost                ( 0001865F4940 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
