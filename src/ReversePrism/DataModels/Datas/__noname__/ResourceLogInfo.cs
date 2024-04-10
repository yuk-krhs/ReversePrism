using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 name                                     string IL2CPP_TYPE_STRING
    // 000 size                                     long IL2CPP_TYPE_I8
    public partial class ResourceLogInfo : DataModel
    {

        public static ResourceLogInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ResourceLogInfo() { Pointer= p0 };


            return value;
        }
    }
}
