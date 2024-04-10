using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ViewPrefab                               0001866CC580 ModelClassType TwestaProfileScreenView TwestaProfileScreenView TwestaProfileScreenView Pointer
    // 028 ViewParent                               0001866AA150 ModelClassType Transform Transform Transform Pointer
    public partial class TwestaProfileScreenBuilder : DataModel
    {
        public TwestaProfileScreenView?                 ViewPrefab                              { get; set; }
        public Transform?                               ViewParent                              { get; set; }

        public static TwestaProfileScreenBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwestaProfileScreenBuilder() { Pointer= p0 };

            value.ViewPrefab                                = GetObject<TwestaProfileScreenView>(new IntPtr(p + 0x020), ReversePrism.DataModels.TwestaProfileScreenView.FromPointer); // 02466B6D5950 0x20 ViewPrefab                  ( 0001866CC580 ModelClassType TwestaProfileScreenView TwestaProfileScreenView TwestaProfileScreenView Pointer )
            value.ViewParent                                = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 02466B6D5970 0x28 ViewParent                  ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
