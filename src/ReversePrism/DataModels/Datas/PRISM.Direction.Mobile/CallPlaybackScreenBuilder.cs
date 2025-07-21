using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ViewPrefab                               ModelClassType CallPlaybackScreenView CallPlaybackScreenView CallPlaybackScreenView Pointer
    // 028 ViewParent                               ModelClassType Transform Transform Transform Pointer
    public partial class CallPlaybackScreenBuilder : DataModel
    {
        public CallPlaybackScreenView?                  ViewPrefab                              { get; set; }
        public Transform?                               ViewParent                              { get; set; }

        public static CallPlaybackScreenBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CallPlaybackScreenBuilder() { Pointer= p0 };

            value.ViewPrefab                                = GetObject<CallPlaybackScreenView>(new IntPtr(p + 0x020), ReversePrism.DataModels.CallPlaybackScreenView.FromPointer); // 0x20 ViewPrefab                  ( ModelClassType CallPlaybackScreenView CallPlaybackScreenView CallPlaybackScreenView Pointer )
            value.ViewParent                                = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0x28 ViewParent                  ( ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
