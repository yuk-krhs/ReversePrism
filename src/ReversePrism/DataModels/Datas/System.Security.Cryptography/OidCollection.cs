using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 List                                     000185CF6A48 ModelClassListType List`1<Oid> List`1<Oid> List<Oid> Pointer
    public partial class OidCollection
    {
        public List<Oid>?                               List                                    { get; set; }

        public static OidCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OidCollection();

            value.List                                      = GetObjectList<Oid>(new IntPtr(p + 0x010), ReversePrism.DataModels.Oid.FromPointer); // 0270D79A4D80 0x10 List                        ( 000185CF6A48 ModelClassListType List`1<Oid> List`1<Oid> List<Oid> Pointer )

            return value;
        }
    }
}
