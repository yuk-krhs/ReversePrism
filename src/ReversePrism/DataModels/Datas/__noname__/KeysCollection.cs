using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Coll                                     ModelClassType NameObjectCollectionBase NameObjectCollectionBase NameObjectCollectionBase Pointer
    public partial class KeysCollection : DataModel
    {
        public NameObjectCollectionBase?                Coll                                    { get; set; }

        public static KeysCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new KeysCollection() { Pointer= p0 };

            value.Coll                                      = GetObject<NameObjectCollectionBase>(new IntPtr(p + 0x010), ReversePrism.DataModels.NameObjectCollectionBase.FromPointer); // 0x10 Coll                        ( ModelClassType NameObjectCollectionBase NameObjectCollectionBase NameObjectCollectionBase Pointer )

            return value;
        }
    }
}
