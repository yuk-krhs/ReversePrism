using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Text                                     000186672F10 ModelPrimitiveType string string string String
    public partial class StepUpGashaRatesTitleCellViewModel
    {
        public string                                   Text                                    { get; set; }

        public static StepUpGashaRatesTitleCellViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StepUpGashaRatesTitleCellViewModel();

            value.Text                                      = GetString(new IntPtr(p + 0x010)); // 0270D53FE260 0x10 Text                        ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
