using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 parent                                   GroupByObservable`3<<var>, <var>, <var>> IL2CPP_TYPE_GENERICINST
    // 000 map                                      Dictionary`2<<var>, ISubject`1<<var>>> IL2CPP_TYPE_GENERICINST
    // 000 nullKeySubject                           ISubject`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 groupDisposable                          CompositeDisposable IL2CPP_TYPE_CLASS
    // 000 refCountDisposable                       RefCountDisposable IL2CPP_TYPE_CLASS
    public partial class GroupBy
    {

        public static GroupBy? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GroupBy();


            return value;
        }
    }
}
