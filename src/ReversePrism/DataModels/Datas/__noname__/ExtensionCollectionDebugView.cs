using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 List                                     ModelClassType ExtensionCollection ExtensionCollection ExtensionCollection Pointer
    public partial class ExtensionCollectionDebugView : DataModel
    {
        public ExtensionCollection?                     List                                    { get; set; }

        public static ExtensionCollectionDebugView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExtensionCollectionDebugView() { Pointer= p0 };

            value.List                                      = GetObject<ExtensionCollection>(new IntPtr(p + 0x010), ReversePrism.DataModels.ExtensionCollection.FromPointer); // 0x10 List                        ( ModelClassType ExtensionCollection ExtensionCollection ExtensionCollection Pointer )

            return value;
        }
    }
}
