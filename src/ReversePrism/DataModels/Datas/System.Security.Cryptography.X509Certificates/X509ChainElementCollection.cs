using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 List                                     00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    public partial class X509ChainElementCollection
    {
        public ArrayList?                               List                                    { get; set; }

        public static X509ChainElementCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new X509ChainElementCollection();

            value.List                                      = GetObject<ArrayList>(new IntPtr(p + 0x010), ReversePrism.DataModels.ArrayList.FromPointer); // 0270D78F6D58 0x10 List                        ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )

            return value;
        }
    }
}
