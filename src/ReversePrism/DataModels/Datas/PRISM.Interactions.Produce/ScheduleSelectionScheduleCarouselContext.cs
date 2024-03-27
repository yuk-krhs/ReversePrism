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
    public partial class ScheduleSelectionScheduleCarouselContext
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
            var value   = new ScheduleSelectionScheduleCarouselContext();

            value.ScrollOffset                              = GetSingle(new IntPtr(p + 0x030)); // 0270DA17E440 0x30 ScrollOffset                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CellInterval                              = GetSingle(new IntPtr(p + 0x034)); // 0270DA17E460 0x34 CellInterval                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ScrollAreaSize                            = GetSingle(new IntPtr(p + 0x038)); // 0270DA17E480 0x38 ScrollAreaSize              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CellReductionRate                         = GetSingle(new IntPtr(p + 0x03C)); // 0270DA17E4A0 0x3C CellReductionRate           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CellOffsetX                               = GetSingle(new IntPtr(p + 0x040)); // 0270DA17E4C0 0x40 CellOffsetX                 ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.SeasonThemeColorData                      = GetObject<ProduceSeasonThemeColorData>(new IntPtr(p + 0x048), ReversePrism.DataModels.ProduceSeasonThemeColorData.FromPointer); // 0270DA17E4E0 0x48 SeasonThemeColorData        ( 00018657E5F0 ModelClassType ProduceSeasonThemeColorData ProduceSeasonThemeColorData ProduceSeasonThemeColorData Pointer )
            value.IsCurrentWeekCellOnDefaultPosition        = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x058), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 0270DA17E520 0x58 IsCurrentWeekCellOnDefaultPosition ( 0001867695E0 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )

            return value;
        }
    }
}
