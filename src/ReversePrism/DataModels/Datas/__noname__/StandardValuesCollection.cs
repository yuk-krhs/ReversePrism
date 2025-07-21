using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Values                                   ModelClassType ICollection ICollection ICollection Pointer
    // 018 ValueArray                               ModelClassType Array Array Array Pointer
    public partial class StandardValuesCollection : DataModel
    {
        public ICollection?                             Values                                  { get; set; }
        public Array?                                   ValueArray                              { get; set; }

        public static StandardValuesCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StandardValuesCollection() { Pointer= p0 };

            value.Values                                    = GetObject<ICollection>(new IntPtr(p + 0x010), ReversePrism.DataModels.ICollection.FromPointer); // 0x10 Values                      ( ModelClassType ICollection ICollection ICollection Pointer )
            value.ValueArray                                = GetObject<Array>(new IntPtr(p + 0x018), ReversePrism.DataModels.Array.FromPointer); // 0x18 ValueArray                  ( ModelClassType Array Array Array Pointer )

            return value;
        }
    }
}
