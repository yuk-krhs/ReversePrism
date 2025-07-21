using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IsShowing                                ModelPrimitiveType bool bool bool Bool
    public partial class ErrorDialogSelector : DataModel
    {
        public bool                                     IsShowing                               { get; set; }

        public static ErrorDialogSelector? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ErrorDialogSelector() { Pointer= p0 };

            value.IsShowing                                 = GetBool(new IntPtr(p + 0x020)); // 0x20 IsShowing                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
