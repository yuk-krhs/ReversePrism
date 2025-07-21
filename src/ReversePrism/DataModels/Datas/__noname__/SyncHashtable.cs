using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Table                                    ModelClassType Hashtable Hashtable Hashtable Pointer
    public partial class SyncHashtable : DataModel
    {
        public Hashtable?                               Table                                   { get; set; }

        public static SyncHashtable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SyncHashtable() { Pointer= p0 };

            value.Table                                     = GetObject<Hashtable>(new IntPtr(p + 0x050), ReversePrism.DataModels.Hashtable.FromPointer); // 0x50 Table                       ( ModelClassType Hashtable Hashtable Hashtable Pointer )

            return value;
        }
    }
}
