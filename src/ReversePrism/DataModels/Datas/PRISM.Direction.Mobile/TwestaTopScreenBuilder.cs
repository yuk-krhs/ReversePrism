using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ViewPrefab                               0001866CE3E0 ModelClassType TwestaTopScreenView TwestaTopScreenView TwestaTopScreenView Pointer
    // 028 ViewParent                               0001866AA150 ModelClassType Transform Transform Transform Pointer
    public partial class TwestaTopScreenBuilder : DataModel
    {
        public TwestaTopScreenView?                     ViewPrefab                              { get; set; }
        public Transform?                               ViewParent                              { get; set; }

        public static TwestaTopScreenBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwestaTopScreenBuilder() { Pointer= p0 };

            value.ViewPrefab                                = GetObject<TwestaTopScreenView>(new IntPtr(p + 0x020), ReversePrism.DataModels.TwestaTopScreenView.FromPointer); // 02466B6D59C8 0x20 ViewPrefab                  ( 0001866CE3E0 ModelClassType TwestaTopScreenView TwestaTopScreenView TwestaTopScreenView Pointer )
            value.ViewParent                                = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 02466B6D59E8 0x28 ViewParent                  ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
