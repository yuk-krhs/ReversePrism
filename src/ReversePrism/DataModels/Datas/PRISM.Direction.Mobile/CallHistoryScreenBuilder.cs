using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ViewPrefab                               00018652A1A0 ModelClassType CallHistoryScreenView CallHistoryScreenView CallHistoryScreenView Pointer
    // 028 ViewParent                               0001866AA150 ModelClassType Transform Transform Transform Pointer
    public partial class CallHistoryScreenBuilder : DataModel
    {
        public CallHistoryScreenView?                   ViewPrefab                              { get; set; }
        public Transform?                               ViewParent                              { get; set; }

        public static CallHistoryScreenBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CallHistoryScreenBuilder() { Pointer= p0 };

            value.ViewPrefab                                = GetObject<CallHistoryScreenView>(new IntPtr(p + 0x020), ReversePrism.DataModels.CallHistoryScreenView.FromPointer); // 02466B6D36A8 0x20 ViewPrefab                  ( 00018652A1A0 ModelClassType CallHistoryScreenView CallHistoryScreenView CallHistoryScreenView Pointer )
            value.ViewParent                                = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 02466B6D36C8 0x28 ViewParent                  ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
