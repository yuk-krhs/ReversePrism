using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Self                                     string IL2CPP_TYPE_STRING
    // 000 Friends                                  string IL2CPP_TYPE_STRING
    // 000 All                                      string IL2CPP_TYPE_STRING
    public partial class OpenSocialSelector : DataModel
    {

        public static OpenSocialSelector? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OpenSocialSelector() { Pointer= p0 };


            return value;
        }
    }
}
