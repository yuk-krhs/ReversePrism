using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 088 ScrollAreaSize                           0001866656B0 ModelPrimitiveType float float float Single
    // 08C CellReductionRate                        0001866656B0 ModelPrimitiveType float float float Single
    // 090 CellOffsetX                              0001866656B0 ModelPrimitiveType float float float Single
    // 098 SeasonThemeThemeColorData                00018657E5F0 ModelClassType ProduceSeasonThemeColorData ProduceSeasonThemeColorData ProduceSeasonThemeColorData Pointer
    // 0A0 ScrollResetButton                        0001867224E0 ModelClassType ScrollResetButton ScrollResetButton ScrollResetButton Pointer
    public partial class ScheduleSelectionScheduleCarouselView
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
            var value   = new ScheduleSelectionScheduleCarouselView();

            value.ScrollAreaSize                            = GetSingle(new IntPtr(p + 0x088)); // 0270DA180778 0x88 ScrollAreaSize              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CellReductionRate                         = GetSingle(new IntPtr(p + 0x08C)); // 0270DA180798 0x8C CellReductionRate           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CellOffsetX                               = GetSingle(new IntPtr(p + 0x090)); // 0270DA1807B8 0x90 CellOffsetX                 ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.SeasonThemeThemeColorData                 = GetObject<ProduceSeasonThemeColorData>(new IntPtr(p + 0x098), ReversePrism.DataModels.ProduceSeasonThemeColorData.FromPointer); // 0270DA1807D8 0x98 SeasonThemeThemeColorData   ( 00018657E5F0 ModelClassType ProduceSeasonThemeColorData ProduceSeasonThemeColorData ProduceSeasonThemeColorData Pointer )
            value.ScrollResetButton                         = GetObject<ScrollResetButton>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ScrollResetButton.FromPointer); // 0270DA1807F8 0xA0 ScrollResetButton           ( 0001867224E0 ModelClassType ScrollResetButton ScrollResetButton ScrollResetButton Pointer )

            return value;
        }
    }
}
