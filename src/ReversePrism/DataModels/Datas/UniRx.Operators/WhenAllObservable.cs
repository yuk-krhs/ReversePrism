using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 sources                                  IObservable`1<Unit>[] IL2CPP_TYPE_SZARRAY
    // 020 sourcesEnumerable                        IEnumerable`1<IObservable`1<Unit>> IL2CPP_TYPE_GENERICINST
    public partial class WhenAllObservable : DataModel
    {

        public static WhenAllObservable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WhenAllObservable() { Pointer= p0 };


            return value;
        }
    }
}
