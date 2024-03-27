using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 Rect                                     000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 040 ScheduleDetailContent                    0001866D1FB0 ModelClassType ScheduleDetailContent ScheduleDetailContent ScheduleDetailContent Pointer
    // 048 Animator                                 0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 050 OrderControllCanvas                      00018653FDA0 ModelClassType Canvas Canvas Canvas Pointer
    // 058 GraphicRaycaster                         0001866940A0 ModelClassType GraphicRaycaster GraphicRaycaster GraphicRaycaster Pointer
    // 060 RightMoveButton                          0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 068 LeftMoveButton                           0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 070 cacheSubject                             Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 078 cacheIsAuditionSubject                   Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 080 IsAudition                               000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ScheduleSelectionListCarouselCell
    {
        public RectTransform?                           Rect                                    { get; set; }
        public ScheduleDetailContent?                   ScheduleDetailContent                   { get; set; }
        public Animator?                                Animator                                { get; set; }
        public Canvas?                                  OrderControllCanvas                     { get; set; }
        public GraphicRaycaster?                        GraphicRaycaster                        { get; set; }
        public UIButton?                                RightMoveButton                         { get; set; }
        public UIButton?                                LeftMoveButton                          { get; set; }
        public bool                                     IsAudition                              { get; set; }

        public static ScheduleSelectionListCarouselCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleSelectionListCarouselCell();

            value.Rect                                      = GetObject<RectTransform>(new IntPtr(p + 0x038), ReversePrism.DataModels.RectTransform.FromPointer); // 0270DA176170 0x38 Rect                        ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.ScheduleDetailContent                     = GetObject<ScheduleDetailContent>(new IntPtr(p + 0x040), ReversePrism.DataModels.ScheduleDetailContent.FromPointer); // 0270DA176190 0x40 ScheduleDetailContent       ( 0001866D1FB0 ModelClassType ScheduleDetailContent ScheduleDetailContent ScheduleDetailContent Pointer )
            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x048), ReversePrism.DataModels.Animator.FromPointer); // 0270DA1761B0 0x48 Animator                    ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.OrderControllCanvas                       = GetObject<Canvas>(new IntPtr(p + 0x050), ReversePrism.DataModels.Canvas.FromPointer); // 0270DA1761D0 0x50 OrderControllCanvas         ( 00018653FDA0 ModelClassType Canvas Canvas Canvas Pointer )
            value.GraphicRaycaster                          = GetObject<GraphicRaycaster>(new IntPtr(p + 0x058), ReversePrism.DataModels.GraphicRaycaster.FromPointer); // 0270DA1761F0 0x58 GraphicRaycaster            ( 0001866940A0 ModelClassType GraphicRaycaster GraphicRaycaster GraphicRaycaster Pointer )
            value.RightMoveButton                           = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA176210 0x60 RightMoveButton             ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.LeftMoveButton                            = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA176230 0x68 LeftMoveButton              ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.IsAudition                                = GetBool(new IntPtr(p + 0x080)); // 0270DA176290 0x80 IsAudition                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
