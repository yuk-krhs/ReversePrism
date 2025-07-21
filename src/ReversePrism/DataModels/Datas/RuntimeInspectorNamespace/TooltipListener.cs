using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Manager                                  ModelClassType ITooltipManager ITooltipManager ITooltipManager Pointer
    // 028 HoveredDrawer                            ModelClassType ITooltipContent ITooltipContent ITooltipContent Pointer
    // 030 HoveringPointer                          ModelClassType PointerEventData PointerEventData PointerEventData Pointer
    // 038 HoveredDrawerTooltipShowTime             ModelPrimitiveType float float float Single
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

            value.Manager                                   = GetObject<ITooltipManager>(new IntPtr(p + 0x020), ReversePrism.DataModels.ITooltipManager.FromPointer); // 0x20 Manager                     ( ModelClassType ITooltipManager ITooltipManager ITooltipManager Pointer )
            value.HoveredDrawer                             = GetObject<ITooltipContent>(new IntPtr(p + 0x028), ReversePrism.DataModels.ITooltipContent.FromPointer); // 0x28 HoveredDrawer               ( ModelClassType ITooltipContent ITooltipContent ITooltipContent Pointer )
            value.HoveringPointer                           = GetObject<PointerEventData>(new IntPtr(p + 0x030), ReversePrism.DataModels.PointerEventData.FromPointer); // 0x30 HoveringPointer             ( ModelClassType PointerEventData PointerEventData PointerEventData Pointer )
            value.HoveredDrawerTooltipShowTime              = GetSingle(new IntPtr(p + 0x038)); // 0x38 HoveredDrawerTooltipShowTime ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
