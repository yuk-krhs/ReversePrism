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
    // 018 Difficulty                               ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32
    // 020 UnitIdols                                ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 028 ProduceUnitModel                         ModelClassType ProduceUnitModel ProduceUnitModel ProduceUnitModel Pointer
    // 030 ProduceBoost                             ModelPrimitiveType int int int Int32
    public partial class ProduceAutoResultPopupViewModel : DataModel
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
            var value   = new ProduceAutoResultPopupViewModel() { Pointer= p0 };

            value.UnitID                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 UnitID                      ( ModelPrimitiveType int int int Int32 )
            value.EpisodeID                                 = GetInt32(new IntPtr(p + 0x014)); // 0x14 EpisodeID                   ( ModelPrimitiveType int int int Int32 )
            value.Difficulty                                = (ProduceDifficultyType)GetInt32(new IntPtr(p + 0x018)); // 0x18 Difficulty                  ( ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32 )
            value.UnitIdols                                 = GetObjectList<UnitIdol>(new IntPtr(p + 0x020), ReversePrism.DataModels.UnitIdol.FromPointer); // 0x20 UnitIdols                   ( ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.ProduceUnitModel                          = GetObject<ProduceUnitModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceUnitModel.FromPointer); // 0x28 ProduceUnitModel            ( ModelClassType ProduceUnitModel ProduceUnitModel ProduceUnitModel Pointer )
            value.ProduceBoost                              = GetInt32(new IntPtr(p + 0x030)); // 0x30 ProduceBoost                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
