using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ContentParent                            0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 028 GoContentPrefab                          00018652D370 ModelClassType LimitLvContentView LimitLvContentView LimitLvContentView Pointer
    public partial class LimitLvView
    {
        public Transform?                               ContentParent                           { get; set; }
        public LimitLvContentView?                      GoContentPrefab                         { get; set; }

        public static LimitLvView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LimitLvView();

            value.ContentParent                             = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 0270DA28FC30 0x20 ContentParent               ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.GoContentPrefab                           = GetObject<LimitLvContentView>(new IntPtr(p + 0x028), ReversePrism.DataModels.LimitLvContentView.FromPointer); // 0270DA28FC50 0x28 GoContentPrefab             ( 00018652D370 ModelClassType LimitLvContentView LimitLvContentView LimitLvContentView Pointer )

            return value;
        }
    }
}
