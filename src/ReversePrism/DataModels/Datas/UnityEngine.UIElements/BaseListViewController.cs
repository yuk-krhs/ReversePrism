using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 ItemsSourceSizeChanged                   0001866792B0 ModelClassType Action Action Action Pointer
    // 038 itemsAdded                               Action`1<IEnumerable`1<int>> IL2CPP_TYPE_GENERICINST
    // 040 itemsRemoved                             Action`1<IEnumerable`1<int>> IL2CPP_TYPE_GENERICINST
    public partial class BaseListViewController : DataModel
    {
        public Action?                                  ItemsSourceSizeChanged                  { get; set; }

        public static BaseListViewController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BaseListViewController() { Pointer= p0 };

            value.ItemsSourceSizeChanged                    = GetObject<Action>(new IntPtr(p + 0x030), ReversePrism.DataModels.Action.FromPointer); // 0245A66A8B18 0x30 ItemsSourceSizeChanged      ( 0001866792B0 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
