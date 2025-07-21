using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 078 Delegates                                ModelClassListType Delegate[] Delegate[] List<Delegate> Pointer
    public partial class MulticastDelegate : DataModel
    {
        public List<Delegate>?                          Delegates                               { get; set; }

        public static MulticastDelegate? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MulticastDelegate() { Pointer= p0 };

            value.Delegates                                 = GetObjectList<Delegate>(new IntPtr(p + 0x078), ReversePrism.DataModels.Delegate.FromPointer); // 0x78 Delegates                   ( ModelClassListType Delegate[] Delegate[] List<Delegate> Pointer )

            return value;
        }
    }
}
