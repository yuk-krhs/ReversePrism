using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Manager                                  000186677860 ModelClassType ITooltipManager ITooltipManager ITooltipManager Pointer
    // 028 HoveredDrawer                            000186677380 ModelClassType ITooltipContent ITooltipContent ITooltipContent Pointer
    // 030 HoveringPointer                          000186642240 ModelClassType PointerEventData PointerEventData PointerEventData Pointer
    // 038 HoveredDrawerTooltipShowTime             0001866656B0 ModelPrimitiveType float float float Single
    public partial class TooltipListener : DataModel
    {
        public ITooltipManager?                         Manager                                 { get; set; }
        public ITooltipContent?                         HoveredDrawer                           { get; set; }
        public PointerEventData?                        HoveringPointer                         { get; set; }
        public float                                    HoveredDrawerTooltipShowTime            { get; set; }

        public static TooltipListener? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TooltipListener() { Pointer= p0 };

            value.Manager                                   = GetObject<ITooltipManager>(new IntPtr(p + 0x020), ReversePrism.DataModels.ITooltipManager.FromPointer); // 02466B1E3790 0x20 Manager                     ( 000186677860 ModelClassType ITooltipManager ITooltipManager ITooltipManager Pointer )
            value.HoveredDrawer                             = GetObject<ITooltipContent>(new IntPtr(p + 0x028), ReversePrism.DataModels.ITooltipContent.FromPointer); // 02466B1E37B0 0x28 HoveredDrawer               ( 000186677380 ModelClassType ITooltipContent ITooltipContent ITooltipContent Pointer )
            value.HoveringPointer                           = GetObject<PointerEventData>(new IntPtr(p + 0x030), ReversePrism.DataModels.PointerEventData.FromPointer); // 02466B1E37D0 0x30 HoveringPointer             ( 000186642240 ModelClassType PointerEventData PointerEventData PointerEventData Pointer )
            value.HoveredDrawerTooltipShowTime              = GetSingle(new IntPtr(p + 0x038)); // 02466B1E37F0 0x38 HoveredDrawerTooltipShowTime ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
