using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CardContent                              000186756D50 ModelClassType PlayerUsePCardContent PlayerUsePCardContent PlayerUsePCardContent Pointer
    // 018 SpaceKeeper                              000186630B70 ModelClassType RectTransform RectTransform RectTransform Pointer
    public partial class PCardDisplayModel
    {
        public PlayerUsePCardContent?                   CardContent                             { get; set; }
        public RectTransform?                           SpaceKeeper                             { get; set; }

        public static PCardDisplayModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PCardDisplayModel();

            value.CardContent                               = GetObject<PlayerUsePCardContent>(new IntPtr(p + 0x010), ReversePrism.DataModels.PlayerUsePCardContent.FromPointer); // 0270D5B08F68 0x10 CardContent                 ( 000186756D50 ModelClassType PlayerUsePCardContent PlayerUsePCardContent PlayerUsePCardContent Pointer )
            value.SpaceKeeper                               = GetObject<RectTransform>(new IntPtr(p + 0x018), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D5B08F88 0x18 SpaceKeeper                 ( 000186630B70 ModelClassType RectTransform RectTransform RectTransform Pointer )

            return value;
        }
    }
}
