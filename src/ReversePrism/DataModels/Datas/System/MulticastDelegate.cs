using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 078 Delegates                                000185B7A080 ModelClassListType Delegate[] Delegate[] List<Delegate> Pointer
    public partial class MulticastDelegate
    {
        public List<Delegate>?                          Delegates                               { get; set; }

        public static MulticastDelegate? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MulticastDelegate();

            value.Delegates                                 = GetObjectList<Delegate>(new IntPtr(p + 0x078), ReversePrism.DataModels.Delegate.FromPointer); // 027001540C18 0x78 Delegates                   ( 000185B7A080 ModelClassListType Delegate[] Delegate[] List<Delegate> Pointer )

            return value;
        }
    }
}
