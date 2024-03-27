using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Data                                     00018658A840 ModelClassType ArrayList ArrayList ArrayList Pointer
    public partial class StringCollection
    {
        public ArrayList?                               Data                                    { get; set; }

        public static StringCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StringCollection();

            value.Data                                      = GetObject<ArrayList>(new IntPtr(p + 0x010), ReversePrism.DataModels.ArrayList.FromPointer); // 0270D7B6AE98 0x10 Data                        ( 00018658A840 ModelClassType ArrayList ArrayList ArrayList Pointer )

            return value;
        }
    }
}
