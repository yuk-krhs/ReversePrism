using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Text                                     ModelPrimitiveType string string string String
    public partial class StepUpGashaRatesTitleCellViewModel : DataModel
    {
        public string                                   Text                                    { get; set; }

        public static StepUpGashaRatesTitleCellViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StepUpGashaRatesTitleCellViewModel() { Pointer= p0 };

            value.Text                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Text                        ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
