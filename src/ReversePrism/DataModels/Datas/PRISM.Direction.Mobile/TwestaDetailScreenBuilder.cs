using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ViewPrefab                               0001866C99F0 ModelClassType TwestaDetailScreenView TwestaDetailScreenView TwestaDetailScreenView Pointer
    // 028 ViewParent                               0001866AA150 ModelClassType Transform Transform Transform Pointer
    public partial class TwestaDetailScreenBuilder : DataModel
    {
        public TwestaDetailScreenView?                  ViewPrefab                              { get; set; }
        public Transform?                               ViewParent                              { get; set; }

        public static TwestaDetailScreenBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwestaDetailScreenBuilder() { Pointer= p0 };

            value.ViewPrefab                                = GetObject<TwestaDetailScreenView>(new IntPtr(p + 0x020), ReversePrism.DataModels.TwestaDetailScreenView.FromPointer); // 02466B6D5860 0x20 ViewPrefab                  ( 0001866C99F0 ModelClassType TwestaDetailScreenView TwestaDetailScreenView TwestaDetailScreenView Pointer )
            value.ViewParent                                = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 02466B6D5880 0x28 ViewParent                  ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
