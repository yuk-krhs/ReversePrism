using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ViewPrefab                               0001866CAF50 ModelClassType TwestaFavoriteScreenView TwestaFavoriteScreenView TwestaFavoriteScreenView Pointer
    // 028 ViewParent                               0001866AA150 ModelClassType Transform Transform Transform Pointer
    public partial class TwestaFavoriteScreenBuilder
    {
        public TwestaFavoriteScreenView?                ViewPrefab                              { get; set; }
        public Transform?                               ViewParent                              { get; set; }

        public static TwestaFavoriteScreenBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwestaFavoriteScreenBuilder();

            value.ViewPrefab                                = GetObject<TwestaFavoriteScreenView>(new IntPtr(p + 0x020), ReversePrism.DataModels.TwestaFavoriteScreenView.FromPointer); // 0270DB651840 0x20 ViewPrefab                  ( 0001866CAF50 ModelClassType TwestaFavoriteScreenView TwestaFavoriteScreenView TwestaFavoriteScreenView Pointer )
            value.ViewParent                                = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0270DB651860 0x28 ViewParent                  ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
