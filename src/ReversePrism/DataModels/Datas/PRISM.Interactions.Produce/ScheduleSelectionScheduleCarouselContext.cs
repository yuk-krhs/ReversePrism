using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 ScrollOffset                             ModelPrimitiveType float float float Single
    // 03C CellInterval                             ModelPrimitiveType float float float Single
    // 040 ScrollAreaSize                           ModelPrimitiveType float float float Single
    // 044 CellReductionRate                        ModelPrimitiveType float float float Single
    // 048 CellOffsetX                              ModelPrimitiveType float float float Single
    // 050 SeasonThemeColorData                     ModelClassType ProduceSeasonThemeColorData ProduceSeasonThemeColorData ProduceSeasonThemeColorData Pointer
    // 058 <OnClickSchedulePanel>k__BackingField    Subject`1<ValueTuple`3<ScheduleType, int, int>> IL2CPP_TYPE_GENERICINST
    // 060 IsCurrentWeekCellOnDefaultPosition       ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    public partial class ScheduleSelectionScheduleCarouselContext : DataModel
    {
        public float                                    ScrollOffset                            { get; set; }
        public float                                    CellInterval                            { get; set; }
        public float                                    ScrollAreaSize                          { get; set; }
        public float                                    CellReductionRate                       { get; set; }
        public float                                    CellOffsetX                             { get; set; }
        public ProduceSeasonThemeColorData?             SeasonThemeColorData                    { get; set; }
        public BoolReactiveProperty?                    IsCurrentWeekCellOnDefaultPosition      { get; set; }

        public static ScheduleSelectionScheduleCarouselContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleSelectionScheduleCarouselContext() { Pointer= p0 };

            value.ScrollOffset                              = GetSingle(new IntPtr(p + 0x038)); // 0x38 ScrollOffset                ( ModelPrimitiveType float float float Single )
            value.CellInterval                              = GetSingle(new IntPtr(p + 0x03C)); // 0x3C CellInterval                ( ModelPrimitiveType float float float Single )
            value.ScrollAreaSize                            = GetSingle(new IntPtr(p + 0x040)); // 0x40 ScrollAreaSize              ( ModelPrimitiveType float float float Single )
            value.CellReductionRate                         = GetSingle(new IntPtr(p + 0x044)); // 0x44 CellReductionRate           ( ModelPrimitiveType float float float Single )
            value.CellOffsetX                               = GetSingle(new IntPtr(p + 0x048)); // 0x48 CellOffsetX                 ( ModelPrimitiveType float float float Single )
            value.SeasonThemeColorData                      = GetObject<ProduceSeasonThemeColorData>(new IntPtr(p + 0x050), ReversePrism.DataModels.ProduceSeasonThemeColorData.FromPointer); // 0x50 SeasonThemeColorData        ( ModelClassType ProduceSeasonThemeColorData ProduceSeasonThemeColorData ProduceSeasonThemeColorData Pointer )
            value.IsCurrentWeekCellOnDefaultPosition        = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x060), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 0x60 IsCurrentWeekCellOnDefaultPosition ( ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )

            return value;
        }
    }
}
