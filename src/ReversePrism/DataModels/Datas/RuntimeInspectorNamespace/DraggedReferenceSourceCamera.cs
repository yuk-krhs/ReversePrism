using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Camera                                   ModelClassType Camera Camera Camera Pointer
    // 028 DraggedReferenceSkin                     ModelClassType UISkin UISkin UISkin Pointer
    // 030 DraggedReferenceCanvas                   ModelClassType Canvas Canvas Canvas Pointer
    // 038 HoldTime                                 ModelPrimitiveType float float float Single
    // 03C InteractableObjectsMask                  ModelEnumType LayerMask LayerMask LayerMask Int32
    // 040 RaycastRange                             ModelPrimitiveType float float float Single
    // 044 PointerDown                              ModelPrimitiveType bool bool bool Bool
    // 048 PointerDownTime                          ModelPrimitiveType float float float Single
    // 04C PointerDownPos                           ModelEnumType Vector2 Vector2 Vector2 Int32
    // 058 HitObject                                ModelClassType Object Object Object Pointer
    // 060 DraggedReference                         ModelClassType DraggedReferenceItem DraggedReferenceItem DraggedReferenceItem Pointer
    // 068 DraggingPointer                          ModelClassType PointerEventData PointerEventData PointerEventData Pointer
    // 070 HoveredUIElements                        ModelEnumListType List`1<RaycastResult> List`1<RaycastResult> List<RaycastResult> Pointer
    // 078 ProcessRaycastHit                        ModelClassType RaycastHitProcesserDelegate RaycastHitProcesserDelegate RaycastHitProcesserDelegate Pointer
    public partial class DraggedReferenceSourceCamera : DataModel
    {
        public Camera?                                  Camera                                  { get; set; }
        public UISkin?                                  DraggedReferenceSkin                    { get; set; }
        public Canvas?                                  DraggedReferenceCanvas                  { get; set; }
        public float                                    HoldTime                                { get; set; }
        public LayerMask                                InteractableObjectsMask                 { get; set; }
        public float                                    RaycastRange                            { get; set; }
        public bool                                     PointerDown                             { get; set; }
        public float                                    PointerDownTime                         { get; set; }
        public Vector2                                  PointerDownPos                          { get; set; }
        public Object?                                  HitObject                               { get; set; }
        public DraggedReferenceItem?                    DraggedReference                        { get; set; }
        public PointerEventData?                        DraggingPointer                         { get; set; }
        public List<RaycastResult>?                     HoveredUIElements                       { get; set; }
        public RaycastHitProcesserDelegate?             ProcessRaycastHit                       { get; set; }

        public static DraggedReferenceSourceCamera? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DraggedReferenceSourceCamera() { Pointer= p0 };

            value.Camera                                    = GetObject<Camera>(new IntPtr(p + 0x020), ReversePrism.DataModels.Camera.FromPointer); // 0x20 Camera                      ( ModelClassType Camera Camera Camera Pointer )
            value.DraggedReferenceSkin                      = GetObject<UISkin>(new IntPtr(p + 0x028), ReversePrism.DataModels.UISkin.FromPointer); // 0x28 DraggedReferenceSkin        ( ModelClassType UISkin UISkin UISkin Pointer )
            value.DraggedReferenceCanvas                    = GetObject<Canvas>(new IntPtr(p + 0x030), ReversePrism.DataModels.Canvas.FromPointer); // 0x30 DraggedReferenceCanvas      ( ModelClassType Canvas Canvas Canvas Pointer )
            value.HoldTime                                  = GetSingle(new IntPtr(p + 0x038)); // 0x38 HoldTime                    ( ModelPrimitiveType float float float Single )
            value.InteractableObjectsMask                   = (LayerMask)GetInt32(new IntPtr(p + 0x03C)); // 0x3C InteractableObjectsMask     ( ModelEnumType LayerMask LayerMask LayerMask Int32 )
            value.RaycastRange                              = GetSingle(new IntPtr(p + 0x040)); // 0x40 RaycastRange                ( ModelPrimitiveType float float float Single )
            value.PointerDown                               = GetBool(new IntPtr(p + 0x044)); // 0x44 PointerDown                 ( ModelPrimitiveType bool bool bool Bool )
            value.PointerDownTime                           = GetSingle(new IntPtr(p + 0x048)); // 0x48 PointerDownTime             ( ModelPrimitiveType float float float Single )
            value.PointerDownPos                            = (Vector2)GetInt32(new IntPtr(p + 0x04C)); // 0x4C PointerDownPos              ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.HitObject                                 = GetObject<Object>(new IntPtr(p + 0x058), ReversePrism.DataModels.Object.FromPointer); // 0x58 HitObject                   ( ModelClassType Object Object Object Pointer )
            value.DraggedReference                          = GetObject<DraggedReferenceItem>(new IntPtr(p + 0x060), ReversePrism.DataModels.DraggedReferenceItem.FromPointer); // 0x60 DraggedReference            ( ModelClassType DraggedReferenceItem DraggedReferenceItem DraggedReferenceItem Pointer )
            value.DraggingPointer                           = GetObject<PointerEventData>(new IntPtr(p + 0x068), ReversePrism.DataModels.PointerEventData.FromPointer); // 0x68 DraggingPointer             ( ModelClassType PointerEventData PointerEventData PointerEventData Pointer )
            value.HoveredUIElements                         = GetEnumList<RaycastResult>(new IntPtr(p + 0x070)); // 0x70 HoveredUIElements           ( ModelEnumListType List`1<RaycastResult> List`1<RaycastResult> List<RaycastResult> Pointer )
            value.ProcessRaycastHit                         = GetObject<RaycastHitProcesserDelegate>(new IntPtr(p + 0x078), ReversePrism.DataModels.RaycastHitProcesserDelegate.FromPointer); // 0x78 ProcessRaycastHit           ( ModelClassType RaycastHitProcesserDelegate RaycastHitProcesserDelegate RaycastHitProcesserDelegate Pointer )

            return value;
        }
    }
}
