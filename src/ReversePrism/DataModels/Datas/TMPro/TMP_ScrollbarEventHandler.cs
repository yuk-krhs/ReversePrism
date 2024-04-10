using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IsSelected                               000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class TMP_ScrollbarEventHandler : DataModel
    {
        public bool                                     IsSelected                              { get; set; }

        public static TMP_ScrollbarEventHandler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TMP_ScrollbarEventHandler() { Pointer= p0 };

            value.IsSelected                                = GetBool(new IntPtr(p + 0x020)); // 02466A696500 0x20 IsSelected                  ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
