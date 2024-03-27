using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_PendingTopElementUnderPointer          000185CB1C28 ModelClassListType VisualElement[] VisualElement[] List<VisualElement> Pointer
    // 018 M_TopElementUnderPointer                 000185CB1C28 ModelClassListType VisualElement[] VisualElement[] List<VisualElement> Pointer
    // 020 M_TriggerPointerEvent                    000185B887E0 ModelClassListType IPointerEvent[] IPointerEvent[] List<IPointerEvent> Pointer
    // 028 M_TriggerMouseEvent                      000185B87E90 ModelClassListType IMouseEvent[] IMouseEvent[] List<IMouseEvent> Pointer
    // 030 M_PickingPointerPositions                000185CB0648 ModelEnumListType Vector2[] Vector2[] List<Vector2> Pointer
    // 038 M_IsPickingPointerTemporaries            000185B78CA0 ModelPrimitiveListType bool[] bool[] List<bool> Pointer
    public partial class ElementUnderPointer
    {
        public List<VisualElement>?                     M_PendingTopElementUnderPointer         { get; set; }
        public List<VisualElement>?                     M_TopElementUnderPointer                { get; set; }
        public List<IPointerEvent>?                     M_TriggerPointerEvent                   { get; set; }
        public List<IMouseEvent>?                       M_TriggerMouseEvent                     { get; set; }
        public List<Vector2>?                           M_PickingPointerPositions               { get; set; }
        public List<bool>?                              M_IsPickingPointerTemporaries           { get; set; }

        public static ElementUnderPointer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ElementUnderPointer();

            value.M_PendingTopElementUnderPointer           = GetObjectList<VisualElement>(new IntPtr(p + 0x010), ReversePrism.DataModels.VisualElement.FromPointer); // 027006765DB0 0x10 M_PendingTopElementUnderPointer ( 000185CB1C28 ModelClassListType VisualElement[] VisualElement[] List<VisualElement> Pointer )
            value.M_TopElementUnderPointer                  = GetObjectList<VisualElement>(new IntPtr(p + 0x018), ReversePrism.DataModels.VisualElement.FromPointer); // 027006765DD0 0x18 M_TopElementUnderPointer    ( 000185CB1C28 ModelClassListType VisualElement[] VisualElement[] List<VisualElement> Pointer )
            value.M_TriggerPointerEvent                     = GetObjectList<IPointerEvent>(new IntPtr(p + 0x020), ReversePrism.DataModels.IPointerEvent.FromPointer); // 027006765DF0 0x20 M_TriggerPointerEvent       ( 000185B887E0 ModelClassListType IPointerEvent[] IPointerEvent[] List<IPointerEvent> Pointer )
            value.M_TriggerMouseEvent                       = GetObjectList<IMouseEvent>(new IntPtr(p + 0x028), ReversePrism.DataModels.IMouseEvent.FromPointer); // 027006765E10 0x28 M_TriggerMouseEvent         ( 000185B87E90 ModelClassListType IMouseEvent[] IMouseEvent[] List<IMouseEvent> Pointer )
            value.M_PickingPointerPositions                 = GetEnumList<Vector2>(new IntPtr(p + 0x030)); // 027006765E30 0x30 M_PickingPointerPositions   ( 000185CB0648 ModelEnumListType Vector2[] Vector2[] List<Vector2> Pointer )
            value.M_IsPickingPointerTemporaries             = GetBoolList(new IntPtr(p + 0x038)); // 027006765E50 0x38 M_IsPickingPointerTemporaries ( 000185B78CA0 ModelPrimitiveListType bool[] bool[] List<bool> Pointer )

            return value;
        }
    }
}
