using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Enumerator                               ModelClassType IDictionaryEnumerator IDictionaryEnumerator IDictionaryEnumerator Pointer
    public partial class XmlSchemaCollectionEnumerator : DataModel
    {
        public IDictionaryEnumerator?                   Enumerator                              { get; set; }

        public static XmlSchemaCollectionEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaCollectionEnumerator() { Pointer= p0 };

            value.Enumerator                                = GetObject<IDictionaryEnumerator>(new IntPtr(p + 0x010), ReversePrism.DataModels.IDictionaryEnumerator.FromPointer); // 0x10 Enumerator                  ( ModelClassType IDictionaryEnumerator IDictionaryEnumerator IDictionaryEnumerator Pointer )

            return value;
        }
    }
}
