using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Camera                                   0001865A1C90 ModelClassType Camera Camera Camera Pointer
    // 028 DraggedReferenceSkin                     0001866F2E90 ModelClassType UISkin UISkin UISkin Pointer
    // 030 DraggedReferenceCanvas                   00018653FDA0 ModelClassType Canvas Canvas Canvas Pointer
    // 038 HoldTime                                 0001866656B0 ModelPrimitiveType float float float Single
    // 03C InteractableObjectsMask                  00018650B160 ModelEnumType LayerMask LayerMask LayerMask Int32
    // 040 RaycastRange                             0001866656B0 ModelPrimitiveType float float float Single
    // 044 PointerDown                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 048 PointerDownTime                          0001866656B0 ModelPrimitiveType float float float Single
    // 04C PointerDownPos                           0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 058 HitObject                                000186638250 ModelClassType Object Object Object Pointer
    // 060 DraggedReference                         0001866F61F0 ModelClassType DraggedReferenceItem DraggedReferenceItem DraggedReferenceItem Pointer
    // 068 DraggingPointer                          000186642240 ModelClassType PointerEventData PointerEventData PointerEventData Pointer
    // 070 HoveredUIElements                        000185D000E8 ModelEnumListType List`1<RaycastResult> List`1<RaycastResult> List<RaycastResult> Pointer
    // 078 ProcessRaycastHit                        0001865B6980 ModelClassType RaycastHitProcesserDelegate RaycastHitProcesserDelegate RaycastHitProcesserDelegate Pointer
    public partial class DraggedReferenceSourceCamera
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
            var value   = new DraggedReferenceSourceCamera();

            value.Camera                                    = GetObject<Camera>(new IntPtr(p + 0x020), ReversePrism.DataModels.Camera.FromPointer); // 0270DB1E9460 0x20 Camera                      ( 0001865A1C90 ModelClassType Camera Camera Camera Pointer )
            value.DraggedReferenceSkin                      = GetObject<UISkin>(new IntPtr(p + 0x028), ReversePrism.DataModels.UISkin.FromPointer); // 0270DB1E9480 0x28 DraggedReferenceSkin        ( 0001866F2E90 ModelClassType UISkin UISkin UISkin Pointer )
            value.DraggedReferenceCanvas                    = GetObject<Canvas>(new IntPtr(p + 0x030), ReversePrism.DataModels.Canvas.FromPointer); // 0270DB1E94A0 0x30 DraggedReferenceCanvas      ( 00018653FDA0 ModelClassType Canvas Canvas Canvas Pointer )
            value.HoldTime                                  = GetSingle(new IntPtr(p + 0x038)); // 0270DB1E94C0 0x38 HoldTime                    ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.InteractableObjectsMask                   = (LayerMask)GetInt32(new IntPtr(p + 0x03C)); // 0270DB1E94E0 0x3C InteractableObjectsMask     ( 00018650B160 ModelEnumType LayerMask LayerMask LayerMask Int32 )
            value.RaycastRange                              = GetSingle(new IntPtr(p + 0x040)); // 0270DB1E9500 0x40 RaycastRange                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.PointerDown                               = GetBool(new IntPtr(p + 0x044)); // 0270DB1E9520 0x44 PointerDown                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PointerDownTime                           = GetSingle(new IntPtr(p + 0x048)); // 0270DB1E9540 0x48 PointerDownTime             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.PointerDownPos                            = (Vector2)GetInt32(new IntPtr(p + 0x04C)); // 0270DB1E9560 0x4C PointerDownPos              ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.HitObject                                 = GetObject<Object>(new IntPtr(p + 0x058), ReversePrism.DataModels.Object.FromPointer); // 0270DB1E9580 0x58 HitObject                   ( 000186638250 ModelClassType Object Object Object Pointer )
            value.DraggedReference                          = GetObject<DraggedReferenceItem>(new IntPtr(p + 0x060), ReversePrism.DataModels.DraggedReferenceItem.FromPointer); // 0270DB1E95A0 0x60 DraggedReference            ( 0001866F61F0 ModelClassType DraggedReferenceItem DraggedReferenceItem DraggedReferenceItem Pointer )
            value.DraggingPointer                           = GetObject<PointerEventData>(new IntPtr(p + 0x068), ReversePrism.DataModels.PointerEventData.FromPointer); // 0270DB1E95C0 0x68 DraggingPointer             ( 000186642240 ModelClassType PointerEventData PointerEventData PointerEventData Pointer )
            value.HoveredUIElements                         = GetEnumList<RaycastResult>(new IntPtr(p + 0x070)); // 0270DB1E95E0 0x70 HoveredUIElements           ( 000185D000E8 ModelEnumListType List`1<RaycastResult> List`1<RaycastResult> List<RaycastResult> Pointer )
            value.ProcessRaycastHit                         = GetObject<RaycastHitProcesserDelegate>(new IntPtr(p + 0x078), ReversePrism.DataModels.RaycastHitProcesserDelegate.FromPointer); // 0270DB1E9600 0x78 ProcessRaycastHit           ( 0001865B6980 ModelClassType RaycastHitProcesserDelegate RaycastHitProcesserDelegate RaycastHitProcesserDelegate Pointer )

            return value;
        }
    }
}
