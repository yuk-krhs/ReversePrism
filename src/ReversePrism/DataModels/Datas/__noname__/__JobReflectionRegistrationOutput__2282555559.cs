using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public partial class __JobReflectionRegistrationOutput__2282555559 : DataModel
    {

        public static __JobReflectionRegistrationOutput__2282555559? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new __JobReflectionRegistrationOutput__2282555559() { Pointer= p0 };


            return value;
        }
    }
}
