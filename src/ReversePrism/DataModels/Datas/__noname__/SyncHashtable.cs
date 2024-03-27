using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Table                                    0001865DE820 ModelClassType Hashtable Hashtable Hashtable Pointer
    public partial class SyncHashtable
    {
        public Hashtable?                               Table                                   { get; set; }

        public static SyncHashtable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SyncHashtable();

            value.Table                                     = GetObject<Hashtable>(new IntPtr(p + 0x050), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D6D85558 0x50 Table                       ( 0001865DE820 ModelClassType Hashtable Hashtable Hashtable Pointer )

            return value;
        }
    }
}
