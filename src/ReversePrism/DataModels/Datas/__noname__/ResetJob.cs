using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 point                                    NativeArray`1<Point> IL2CPP_TYPE_GENERICINST
    // 020 idx                                      NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    public partial class ResetJob
    {

        public static ResetJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ResetJob();


            return value;
        }
    }
}
