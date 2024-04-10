using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ssd                                      NativeArray`1<SwayStringData> IL2CPP_TYPE_GENERICINST
    // 020 point                                    NativeArray`1<Point> IL2CPP_TYPE_GENERICINST
    public partial class CopyJob : DataModel
    {

        public static CopyJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CopyJob() { Pointer= p0 };


            return value;
        }
    }
}
