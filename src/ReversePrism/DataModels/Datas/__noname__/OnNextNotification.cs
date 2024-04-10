using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 value                                    <var> IL2CPP_TYPE_VAR
    public partial class OnNextNotification : DataModel
    {

        public static OnNextNotification? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OnNextNotification() { Pointer= p0 };


            return value;
        }
    }
}
