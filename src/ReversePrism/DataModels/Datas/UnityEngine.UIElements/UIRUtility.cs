using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_DefaultShaderName                      string IL2CPP_TYPE_STRING
    // 008 k_DefaultWorldSpaceShaderName            string IL2CPP_TYPE_STRING
    public partial class UIRUtility
    {

        public static UIRUtility? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIRUtility();


            return value;
        }
    }
}
