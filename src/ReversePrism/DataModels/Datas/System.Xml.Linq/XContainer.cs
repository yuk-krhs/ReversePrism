using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 content                                  <object> IL2CPP_TYPE_OBJECT
    public partial class XContainer : DataModel
    {

        public static XContainer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XContainer() { Pointer= p0 };


            return value;
        }
    }
}
