using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 InitialFavorite                          000186595960 ModelPrimitiveType bool bool bool Bool
    // 018 ToggleFavoriteAsync                      0001866F62D0 ModelClassType AsyncLazy AsyncLazy AsyncLazy Pointer
    public partial class AdvFavoriteInfo : DataModel
    {
        public bool                                     InitialFavorite                         { get; set; }
        public AsyncLazy?                               ToggleFavoriteAsync                     { get; set; }

        public static AdvFavoriteInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdvFavoriteInfo() { Pointer= p0 };

            value.InitialFavorite                           = GetBool(new IntPtr(p + 0x010)); // 024665E41E60 0x10 InitialFavorite             ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ToggleFavoriteAsync                       = GetObject<AsyncLazy>(new IntPtr(p + 0x018), ReversePrism.DataModels.AsyncLazy.FromPointer); // 024665E41E80 0x18 ToggleFavoriteAsync         ( 0001866F62D0 ModelClassType AsyncLazy AsyncLazy AsyncLazy Pointer )

            return value;
        }
    }
}
