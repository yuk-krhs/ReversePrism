using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Text                                     ModelPrimitiveType string string string String
    public partial class GashaRatesTitleCellViewModel : DataModel
    {
        public string                                   Text                                    { get; set; }

        public static GashaRatesTitleCellViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaRatesTitleCellViewModel() { Pointer= p0 };

            value.Text                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Text                        ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
