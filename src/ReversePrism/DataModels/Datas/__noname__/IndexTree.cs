using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 Index                                    0001866E0300 ModelClassType Index Index Index Pointer
    public partial class IndexTree
    {
        public Index?                                   Index                                   { get; set; }

        public static IndexTree? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IndexTree();

            value.Index                                     = GetObject<Index>(new IntPtr(p + 0x040), ReversePrism.DataModels.Index.FromPointer); // 0270D894EAD0 0x40 Index                       ( 0001866E0300 ModelClassType Index Index Index Pointer )

            return value;
        }
    }
}
