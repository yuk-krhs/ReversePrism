using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 parent                                   ZipLatestObservable`8<<var>, <var>, <var>, <var>, <var>, <var>, <var>, <var>> IL2CPP_TYPE_GENERICINST
    // 000 gate                                     <object> IL2CPP_TYPE_OBJECT
    // 000 c1                                       ZipLatestObserver`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 c2                                       ZipLatestObserver`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 c3                                       ZipLatestObserver`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 c4                                       ZipLatestObserver`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 c5                                       ZipLatestObserver`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 c6                                       ZipLatestObserver`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 c7                                       ZipLatestObserver`1<<var>> IL2CPP_TYPE_GENERICINST
    public partial class ZipLatest
    {

        public static ZipLatest? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ZipLatest();


            return value;
        }
    }
}
