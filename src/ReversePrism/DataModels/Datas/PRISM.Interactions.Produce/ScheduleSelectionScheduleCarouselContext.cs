using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 ScrollOffset                             0001866656B0 ModelPrimitiveType float float float Single
    // 034 CellInterval                             0001866656B0 ModelPrimitiveType float float float Single
    // 038 ScrollAreaSize                           0001866656B0 ModelPrimitiveType float float float Single
    // 03C CellReductionRate                        0001866656B0 ModelPrimitiveType float float float Single
    // 040 CellOffsetX                              0001866656B0 ModelPrimitiveType float float float Single
    // 048 SeasonThemeColorData                     00018657E5F0 ModelClassType ProduceSeasonThemeColorData ProduceSeasonThemeColorData ProduceSeasonThemeColorData Pointer
    // 050 <OnClickSchedulePanel>k__BackingField    Subject`1<ValueTuple`3<ScheduleType, int, int>> IL2CPP_TYPE_GENERICINST
    // 058 IsCurrentWeekCellOnDefaultPosition       0001867695E0 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
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

            value.ScrollOffset                              = GetSingle(new IntPtr(p + 0x030)); // 02466A1E9510 0x30 ScrollOffset                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CellInterval                              = GetSingle(new IntPtr(p + 0x034)); // 02466A1E9530 0x34 CellInterval                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ScrollAreaSize                            = GetSingle(new IntPtr(p + 0x038)); // 02466A1E9550 0x38 ScrollAreaSize              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CellReductionRate                         = GetSingle(new IntPtr(p + 0x03C)); // 02466A1E9570 0x3C CellReductionRate           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CellOffsetX                               = GetSingle(new IntPtr(p + 0x040)); // 02466A1E9590 0x40 CellOffsetX                 ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.SeasonThemeColorData                      = GetObject<ProduceSeasonThemeColorData>(new IntPtr(p + 0x048), ReversePrism.DataModels.ProduceSeasonThemeColorData.FromPointer); // 02466A1E95B0 0x48 SeasonThemeColorData        ( 00018657E5F0 ModelClassType ProduceSeasonThemeColorData ProduceSeasonThemeColorData ProduceSeasonThemeColorData Pointer )
            value.IsCurrentWeekCellOnDefaultPosition        = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x058), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 02466A1E95F0 0x58 IsCurrentWeekCellOnDefaultPosition ( 0001867695E0 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )

            return value;
        }
    }
}
