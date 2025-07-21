using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Overrides                                ModelClassType Hashtable Hashtable Hashtable Pointer
    public partial class XmlAttributeOverrides : DataModel
    {
        public Hashtable?                               Overrides                               { get; set; }

        public static XmlAttributeOverrides? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlAttributeOverrides() { Pointer= p0 };

            value.Overrides                                 = GetObject<Hashtable>(new IntPtr(p + 0x010), ReversePrism.DataModels.Hashtable.FromPointer); // 0x10 Overrides                   ( ModelClassType Hashtable Hashtable Hashtable Pointer )

            return value;
        }
    }
}
