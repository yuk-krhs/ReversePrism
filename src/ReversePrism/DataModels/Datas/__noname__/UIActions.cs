using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Wrapper                                0001866B2FE0 ModelClassType DefaultInputActions DefaultInputActions DefaultInputActions Pointer
    public partial class UIActions : DataModel
    {
        public DefaultInputActions?                     M_Wrapper                               { get; set; }

        public static UIActions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIActions() { Pointer= p0 };

            value.M_Wrapper                                 = GetObject<DefaultInputActions>(new IntPtr(p + 0x010), ReversePrism.DataModels.DefaultInputActions.FromPointer); // 024667779EB8 0x10 M_Wrapper                   ( 0001866B2FE0 ModelClassType DefaultInputActions DefaultInputActions DefaultInputActions Pointer )

            return value;
        }
    }
}
