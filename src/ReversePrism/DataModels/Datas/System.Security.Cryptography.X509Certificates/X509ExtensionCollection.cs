using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Empty                                    sbyte[] IL2CPP_TYPE_SZARRAY
    // 010 List                                     00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    public partial class X509ExtensionCollection
    {
        public ArrayList?                               List                                    { get; set; }

        public static X509ExtensionCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new X509ExtensionCollection();

            value.List                                      = GetObject<ArrayList>(new IntPtr(p + 0x010), ReversePrism.DataModels.ArrayList.FromPointer); // 0270D79E38C0 0x10 List                        ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )

            return value;
        }
    }
}
