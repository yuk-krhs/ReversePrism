using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Enumerator                               ModelClassType IEnumerator IEnumerator IEnumerator Pointer
    public partial class X509ChainElementEnumerator : DataModel
    {
        public IEnumerator?                             Enumerator                              { get; set; }

        public static X509ChainElementEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new X509ChainElementEnumerator() { Pointer= p0 };

            value.Enumerator                                = GetObject<IEnumerator>(new IntPtr(p + 0x010), ReversePrism.DataModels.IEnumerator.FromPointer); // 0x10 Enumerator                  ( ModelClassType IEnumerator IEnumerator IEnumerator Pointer )

            return value;
        }
    }
}
