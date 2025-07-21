using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 ScrollCorrectionDuration                 ModelPrimitiveType float float float Single
    // 094 ScrollCorrectionEase                     ModelEnumType Ease Ease Ease Int32
    public partial class ProducePreparationEpisodeSelectUnitListView : DataModel
    {
        public float                                    ScrollCorrectionDuration                { get; set; }
        public Ease                                     ScrollCorrectionEase                    { get; set; }

        public static ProducePreparationEpisodeSelectUnitListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProducePreparationEpisodeSelectUnitListView() { Pointer= p0 };

            value.ScrollCorrectionDuration                  = GetSingle(new IntPtr(p + 0x090)); // 0x90 ScrollCorrectionDuration    ( ModelPrimitiveType float float float Single )
            value.ScrollCorrectionEase                      = (Ease)GetInt32(new IntPtr(p + 0x094)); // 0x94 ScrollCorrectionEase        ( ModelEnumType Ease Ease Ease Int32 )

            return value;
        }
    }
}
