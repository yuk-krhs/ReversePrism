using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Enumerator                               00018675F880 ModelClassType IEnumerator IEnumerator IEnumerator Pointer
    public partial class XmlSchemaObjectEnumerator : DataModel
    {
        public IEnumerator?                             Enumerator                              { get; set; }

        public static XmlSchemaObjectEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaObjectEnumerator() { Pointer= p0 };

            value.Enumerator                                = GetObject<IEnumerator>(new IntPtr(p + 0x010), ReversePrism.DataModels.IEnumerator.FromPointer); // 024667621578 0x10 Enumerator                  ( 00018675F880 ModelClassType IEnumerator IEnumerator IEnumerator Pointer )

            return value;
        }
    }
}
