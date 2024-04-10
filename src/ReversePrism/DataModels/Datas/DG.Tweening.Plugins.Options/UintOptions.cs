using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsNegativeChangeValue                    000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class UintOptions : DataModel
    {
        public bool                                     IsNegativeChangeValue                   { get; set; }

        public static UintOptions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UintOptions() { Pointer= p0 };

            value.IsNegativeChangeValue                     = GetBool(new IntPtr(p + 0x010)); // 02466B0C48F8 0x10 IsNegativeChangeValue       ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
