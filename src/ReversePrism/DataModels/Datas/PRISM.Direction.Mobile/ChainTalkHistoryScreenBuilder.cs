using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ViewPrefab                               000186562440 ModelClassType ChainTalkHistoryScreenView ChainTalkHistoryScreenView ChainTalkHistoryScreenView Pointer
    // 028 ViewParent                               0001866AA150 ModelClassType Transform Transform Transform Pointer
    public partial class ChainTalkHistoryScreenBuilder : DataModel
    {
        public ChainTalkHistoryScreenView?              ViewPrefab                              { get; set; }
        public Transform?                               ViewParent                              { get; set; }

        public static ChainTalkHistoryScreenBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkHistoryScreenBuilder() { Pointer= p0 };

            value.ViewPrefab                                = GetObject<ChainTalkHistoryScreenView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ChainTalkHistoryScreenView.FromPointer); // 02466B6D37E8 0x20 ViewPrefab                  ( 000186562440 ModelClassType ChainTalkHistoryScreenView ChainTalkHistoryScreenView ChainTalkHistoryScreenView Pointer )
            value.ViewParent                                = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 02466B6D3808 0x28 ViewParent                  ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
