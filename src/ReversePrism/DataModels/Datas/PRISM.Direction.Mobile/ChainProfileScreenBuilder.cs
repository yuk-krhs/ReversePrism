using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ViewPrefab                               00018655A1F0 ModelClassType ChainProfileScreenView ChainProfileScreenView ChainProfileScreenView Pointer
    // 028 ViewParent                               0001866AA150 ModelClassType Transform Transform Transform Pointer
    public partial class ChainProfileScreenBuilder
    {
        public ChainProfileScreenView?                  ViewPrefab                              { get; set; }
        public Transform?                               ViewParent                              { get; set; }

        public static ChainProfileScreenBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainProfileScreenBuilder();

            value.ViewPrefab                                = GetObject<ChainProfileScreenView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ChainProfileScreenView.FromPointer); // 0270DB647648 0x20 ViewPrefab                  ( 00018655A1F0 ModelClassType ChainProfileScreenView ChainProfileScreenView ChainProfileScreenView Pointer )
            value.ViewParent                                = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0270DB647668 0x28 ViewParent                  ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
