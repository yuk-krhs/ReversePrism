using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 088 ScrollAreaSize                           ModelPrimitiveType float float float Single
    // 08C CellReductionRate                        ModelPrimitiveType float float float Single
    // 090 CellOffsetX                              ModelPrimitiveType float float float Single
    // 098 SeasonThemeThemeColorData                ModelClassType ProduceSeasonThemeColorData ProduceSeasonThemeColorData ProduceSeasonThemeColorData Pointer
    // 0A0 ScrollResetButton                        ModelClassType ScrollResetButton ScrollResetButton ScrollResetButton Pointer
    public partial class ScheduleSelectionScheduleCarouselView : DataModel
    {
        public float                                    ScrollAreaSize                          { get; set; }
        public float                                    CellReductionRate                       { get; set; }
        public float                                    CellOffsetX                             { get; set; }
        public ProduceSeasonThemeColorData?             SeasonThemeThemeColorData               { get; set; }
        public ScrollResetButton?                       ScrollResetButton                       { get; set; }

        public static ScheduleSelectionScheduleCarouselView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleSelectionScheduleCarouselView() { Pointer= p0 };

            value.ScrollAreaSize                            = GetSingle(new IntPtr(p + 0x088)); // 0x88 ScrollAreaSize              ( ModelPrimitiveType float float float Single )
            value.CellReductionRate                         = GetSingle(new IntPtr(p + 0x08C)); // 0x8C CellReductionRate           ( ModelPrimitiveType float float float Single )
            value.CellOffsetX                               = GetSingle(new IntPtr(p + 0x090)); // 0x90 CellOffsetX                 ( ModelPrimitiveType float float float Single )
            value.SeasonThemeThemeColorData                 = GetObject<ProduceSeasonThemeColorData>(new IntPtr(p + 0x098), ReversePrism.DataModels.ProduceSeasonThemeColorData.FromPointer); // 0x98 SeasonThemeThemeColorData   ( ModelClassType ProduceSeasonThemeColorData ProduceSeasonThemeColorData ProduceSeasonThemeColorData Pointer )
            value.ScrollResetButton                         = GetObject<ScrollResetButton>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ScrollResetButton.FromPointer); // 0xA0 ScrollResetButton           ( ModelClassType ScrollResetButton ScrollResetButton ScrollResetButton Pointer )

            return value;
        }
    }
}
