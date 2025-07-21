using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ContentParent                            ModelClassType Transform Transform Transform Pointer
    // 028 GoContentPrefab                          ModelClassType LimitLvContentView LimitLvContentView LimitLvContentView Pointer
    public partial class LimitLvView : DataModel
    {
        public Transform?                               ContentParent                           { get; set; }
        public LimitLvContentView?                      GoContentPrefab                         { get; set; }

        public static LimitLvView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LimitLvView() { Pointer= p0 };

            value.ContentParent                             = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 0x20 ContentParent               ( ModelClassType Transform Transform Transform Pointer )
            value.GoContentPrefab                           = GetObject<LimitLvContentView>(new IntPtr(p + 0x028), ReversePrism.DataModels.LimitLvContentView.FromPointer); // 0x28 GoContentPrefab             ( ModelClassType LimitLvContentView LimitLvContentView LimitLvContentView Pointer )

            return value;
        }
    }
}
