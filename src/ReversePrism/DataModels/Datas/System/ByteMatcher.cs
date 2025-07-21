using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Map                                      ModelClassType Hashtable Hashtable Hashtable Pointer
    // 018 Starts                                   ModelClassType Hashtable Hashtable Hashtable Pointer
    public partial class ByteMatcher : DataModel
    {
        public Hashtable?                               Map                                     { get; set; }
        public Hashtable?                               Starts                                  { get; set; }

        public static ByteMatcher? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ByteMatcher() { Pointer= p0 };

            value.Map                                       = GetObject<Hashtable>(new IntPtr(p + 0x010), ReversePrism.DataModels.Hashtable.FromPointer); // 0x10 Map                         ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.Starts                                    = GetObject<Hashtable>(new IntPtr(p + 0x018), ReversePrism.DataModels.Hashtable.FromPointer); // 0x18 Starts                      ( ModelClassType Hashtable Hashtable Hashtable Pointer )

            return value;
        }
    }
}
