using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Attributes                               ModelClassType Hashtable Hashtable Hashtable Pointer
    // 018 Elements                                 ModelClassType Hashtable Hashtable Hashtable Pointer
    public partial class TypeInfo : DataModel
    {
        public Hashtable?                               Attributes                              { get; set; }
        public Hashtable?                               Elements                                { get; set; }

        public static TypeInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeInfo() { Pointer= p0 };

            value.Attributes                                = GetObject<Hashtable>(new IntPtr(p + 0x010), ReversePrism.DataModels.Hashtable.FromPointer); // 0x10 Attributes                  ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.Elements                                  = GetObject<Hashtable>(new IntPtr(p + 0x018), ReversePrism.DataModels.Hashtable.FromPointer); // 0x18 Elements                    ( ModelClassType Hashtable Hashtable Hashtable Pointer )

            return value;
        }
    }
}
