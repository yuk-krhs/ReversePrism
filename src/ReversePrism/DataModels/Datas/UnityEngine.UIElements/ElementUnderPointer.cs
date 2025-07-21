using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_PendingTopElementUnderPointer          ModelClassListType VisualElement[] VisualElement[] List<VisualElement> Pointer
    // 018 M_TopElementUnderPointer                 ModelClassListType VisualElement[] VisualElement[] List<VisualElement> Pointer
    // 020 M_TriggerPointerEvent                    ModelClassListType IPointerEvent[] IPointerEvent[] List<IPointerEvent> Pointer
    // 028 M_TriggerMouseEvent                      ModelClassListType IMouseEvent[] IMouseEvent[] List<IMouseEvent> Pointer
    // 030 M_PickingPointerPositions                ModelEnumListType Vector2[] Vector2[] List<Vector2> Pointer
    // 038 M_IsPickingPointerTemporaries            ModelPrimitiveListType bool[] bool[] List<bool> Pointer
    public partial class ElementUnderPointer : DataModel
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
            var value   = new ElementUnderPointer() { Pointer= p0 };

            value.M_PendingTopElementUnderPointer           = GetObjectList<VisualElement>(new IntPtr(p + 0x010), ReversePrism.DataModels.VisualElement.FromPointer); // 0x10 M_PendingTopElementUnderPointer ( ModelClassListType VisualElement[] VisualElement[] List<VisualElement> Pointer )
            value.M_TopElementUnderPointer                  = GetObjectList<VisualElement>(new IntPtr(p + 0x018), ReversePrism.DataModels.VisualElement.FromPointer); // 0x18 M_TopElementUnderPointer    ( ModelClassListType VisualElement[] VisualElement[] List<VisualElement> Pointer )
            value.M_TriggerPointerEvent                     = GetObjectList<IPointerEvent>(new IntPtr(p + 0x020), ReversePrism.DataModels.IPointerEvent.FromPointer); // 0x20 M_TriggerPointerEvent       ( ModelClassListType IPointerEvent[] IPointerEvent[] List<IPointerEvent> Pointer )
            value.M_TriggerMouseEvent                       = GetObjectList<IMouseEvent>(new IntPtr(p + 0x028), ReversePrism.DataModels.IMouseEvent.FromPointer); // 0x28 M_TriggerMouseEvent         ( ModelClassListType IMouseEvent[] IMouseEvent[] List<IMouseEvent> Pointer )
            value.M_PickingPointerPositions                 = GetEnumList<Vector2>(new IntPtr(p + 0x030)); // 0x30 M_PickingPointerPositions   ( ModelEnumListType Vector2[] Vector2[] List<Vector2> Pointer )
            value.M_IsPickingPointerTemporaries             = GetBoolList(new IntPtr(p + 0x038)); // 0x38 M_IsPickingPointerTemporaries ( ModelPrimitiveListType bool[] bool[] List<bool> Pointer )

            return value;
        }
    }
}
