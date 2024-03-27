using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Enumerator                               00018675F880 ModelClassType IEnumerator IEnumerator IEnumerator Pointer
    public partial class X509ChainElementEnumerator
    {
        public IEnumerator?                             Enumerator                              { get; set; }

        public static X509ChainElementEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new X509ChainElementEnumerator();

            value.Enumerator                                = GetObject<IEnumerator>(new IntPtr(p + 0x010), ReversePrism.DataModels.IEnumerator.FromPointer); // 0270D79EB068 0x10 Enumerator                  ( 00018675F880 ModelClassType IEnumerator IEnumerator IEnumerator Pointer )

            return value;
        }
    }
}
