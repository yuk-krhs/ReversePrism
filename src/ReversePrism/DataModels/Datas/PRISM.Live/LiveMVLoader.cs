using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 AssetKey                                 string IL2CPP_TYPE_STRING
    // 000 ResourceTag                              string IL2CPP_TYPE_STRING
    public partial class LiveMVLoader : DataModel
    {

        public static LiveMVLoader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMVLoader() { Pointer= p0 };


            return value;
        }
    }
}
