using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 parent                                   ScanObservable`2<<var>, <var>> IL2CPP_TYPE_GENERICINST
    // 000 accumulation                             <var> IL2CPP_TYPE_VAR
    // 000 isFirst                                  bool IL2CPP_TYPE_BOOLEAN
    public partial class Scan
    {

        public static Scan? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Scan();


            return value;
        }
    }
}
