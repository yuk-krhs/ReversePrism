using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Proxy                                    0001866ED980 ModelClassType ScopedSavedataProxy ScopedSavedataProxy ScopedSavedataProxy Pointer
    public partial class SavedataBase : DataModel
    {
        public ScopedSavedataProxy?                     Proxy                                   { get; set; }

        public static SavedataBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SavedataBase() { Pointer= p0 };

            value.Proxy                                     = GetObject<ScopedSavedataProxy>(new IntPtr(p + 0x010), ReversePrism.DataModels.ScopedSavedataProxy.FromPointer); // 0245A3DCAEA0 0x10 Proxy                       ( 0001866ED980 ModelClassType ScopedSavedataProxy ScopedSavedataProxy ScopedSavedataProxy Pointer )

            return value;
        }
    }
}
