using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScopedProxy                              0001866ED980 ModelClassType ScopedSavedataProxy ScopedSavedataProxy ScopedSavedataProxy Pointer
    public partial class SavablePropertyBase : DataModel
    {
        public ScopedSavedataProxy?                     ScopedProxy                             { get; set; }

        public static SavablePropertyBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SavablePropertyBase() { Pointer= p0 };

            value.ScopedProxy                               = GetObject<ScopedSavedataProxy>(new IntPtr(p + 0x010), ReversePrism.DataModels.ScopedSavedataProxy.FromPointer); // 0245A3DCE4C0 0x10 ScopedProxy                 ( 0001866ED980 ModelClassType ScopedSavedataProxy ScopedSavedataProxy ScopedSavedataProxy Pointer )

            return value;
        }
    }
}
