using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ViewPrefab                               000186639570 ModelClassType MobileTopScreenView MobileTopScreenView MobileTopScreenView Pointer
    // 028 ViewParent                               0001866AA150 ModelClassType Transform Transform Transform Pointer
    public partial class MobileTopScreenBuilder : DataModel
    {
        public MobileTopScreenView?                     ViewPrefab                              { get; set; }
        public Transform?                               ViewParent                              { get; set; }

        public static MobileTopScreenBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MobileTopScreenBuilder() { Pointer= p0 };

            value.ViewPrefab                                = GetObject<MobileTopScreenView>(new IntPtr(p + 0x020), ReversePrism.DataModels.MobileTopScreenView.FromPointer); // 02466B6D38F8 0x20 ViewPrefab                  ( 000186639570 ModelClassType MobileTopScreenView MobileTopScreenView MobileTopScreenView Pointer )
            value.ViewParent                                = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 02466B6D3918 0x28 ViewParent                  ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
