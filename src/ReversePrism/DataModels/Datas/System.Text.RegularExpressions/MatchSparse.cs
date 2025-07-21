using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 078 Caps                                     ModelClassType Hashtable Hashtable Hashtable Pointer
    public partial class MatchSparse : DataModel
    {
        public Hashtable?                               Caps                                    { get; set; }

        public static MatchSparse? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MatchSparse() { Pointer= p0 };

            value.Caps                                      = GetObject<Hashtable>(new IntPtr(p + 0x078), ReversePrism.DataModels.Hashtable.FromPointer); // 0x78 Caps                        ( ModelClassType Hashtable Hashtable Hashtable Pointer )

            return value;
        }
    }
}
