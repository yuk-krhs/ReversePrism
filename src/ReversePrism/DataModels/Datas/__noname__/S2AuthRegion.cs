using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 KOREA                                    int IL2CPP_TYPE_I4
    // 000 JAPAN                                    int IL2CPP_TYPE_I4
    // 000 CHINA                                    int IL2CPP_TYPE_I4
    public partial class S2AuthRegion : DataModel
    {

        public static S2AuthRegion? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new S2AuthRegion() { Pointer= p0 };


            return value;
        }
    }
}
