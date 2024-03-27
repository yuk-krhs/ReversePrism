using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ViewPrefab                               000186530170 ModelClassType CallTopScreenView CallTopScreenView CallTopScreenView Pointer
    // 028 ViewParent                               0001866AA150 ModelClassType Transform Transform Transform Pointer
    public partial class CallTopScreenBuilder
    {
        public CallTopScreenView?                       ViewPrefab                              { get; set; }
        public Transform?                               ViewParent                              { get; set; }

        public static CallTopScreenBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CallTopScreenBuilder();

            value.ViewPrefab                                = GetObject<CallTopScreenView>(new IntPtr(p + 0x020), ReversePrism.DataModels.CallTopScreenView.FromPointer); // 0270DB6475C8 0x20 ViewPrefab                  ( 000186530170 ModelClassType CallTopScreenView CallTopScreenView CallTopScreenView Pointer )
            value.ViewParent                                = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0270DB6475E8 0x28 ViewParent                  ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
