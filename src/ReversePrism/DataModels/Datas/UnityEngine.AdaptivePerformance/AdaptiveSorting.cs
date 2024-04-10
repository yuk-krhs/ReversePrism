using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 M_DefaultSorting                         000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class AdaptiveSorting : DataModel
    {
        public bool                                     M_DefaultSorting                        { get; set; }

        public static AdaptiveSorting? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdaptiveSorting() { Pointer= p0 };

            value.M_DefaultSorting                          = GetBool(new IntPtr(p + 0x040)); // 02466B715E98 0x40 M_DefaultSorting            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
