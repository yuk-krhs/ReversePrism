using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 POINTER_VALIDATE_INTERVAL                float IL2CPP_TYPE_R4
    // 020 SiblingIndexModificationArea             ModelPrimitiveType float float float Single
    // 024 ScrollableArea                           ModelPrimitiveType float float float Single
    // 028 1OverScrollableArea                      ModelPrimitiveType float float float Single
    // 02C ScrollSpeed                              ModelPrimitiveType float float float Single
    // 030 Hierarchy                                ModelClassType RuntimeHierarchy RuntimeHierarchy RuntimeHierarchy Pointer
    // 038 Content                                  ModelClassType RectTransform RectTransform RectTransform Pointer
    // 040 DragDropTargetVisualization              ModelClassType Image Image Image Pointer
    // 048 Canvas                                   ModelClassType Canvas Canvas Canvas Pointer
    // 050 RectTransform                            ModelClassType RectTransform RectTransform RectTransform Pointer
    // 058 Height                                   ModelPrimitiveType float float float Single
    // 060 Pointer                                  ModelClassType PointerEventData PointerEventData PointerEventData Pointer
    // 068 WorldCamera                              ModelClassType Camera Camera Camera Pointer
    // 070 PointerLastYPos                          ModelPrimitiveType float float float Single
    // 074 NextPointerValidation                    ModelPrimitiveType float float float Single
    public partial class HierarchyDragDropListener : DataModel
    {
        public float                                    SiblingIndexModificationArea            { get; set; }
        public float                                    ScrollableArea                          { get; set; }
        public float                                    1OverScrollableArea                     { get; set; }
        public float                                    ScrollSpeed                             { get; set; }
        public RuntimeHierarchy?                        Hierarchy                               { get; set; }
        public RectTransform?                           Content                                 { get; set; }
        public Image?                                   DragDropTargetVisualization             { get; set; }
        public Canvas?                                  Canvas                                  { get; set; }
        public RectTransform?                           RectTransform                           { get; set; }
        public float                                    Height                                  { get; set; }
        public PointerEventData?                        Pointer                                 { get; set; }
        public Camera?                                  WorldCamera                             { get; set; }
        public float                                    PointerLastYPos                         { get; set; }
        public float                                    NextPointerValidation                   { get; set; }

        public static HierarchyDragDropListener? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HierarchyDragDropListener() { Pointer= p0 };

            value.SiblingIndexModificationArea              = GetSingle(new IntPtr(p + 0x020)); // 0x20 SiblingIndexModificationArea ( ModelPrimitiveType float float float Single )
            value.ScrollableArea                            = GetSingle(new IntPtr(p + 0x024)); // 0x24 ScrollableArea              ( ModelPrimitiveType float float float Single )
            value.1OverScrollableArea                       = GetSingle(new IntPtr(p + 0x028)); // 0x28 1OverScrollableArea         ( ModelPrimitiveType float float float Single )
            value.ScrollSpeed                               = GetSingle(new IntPtr(p + 0x02C)); // 0x2C ScrollSpeed                 ( ModelPrimitiveType float float float Single )
            value.Hierarchy                                 = GetObject<RuntimeHierarchy>(new IntPtr(p + 0x030), ReversePrism.DataModels.RuntimeHierarchy.FromPointer); // 0x30 Hierarchy                   ( ModelClassType RuntimeHierarchy RuntimeHierarchy RuntimeHierarchy Pointer )
            value.Content                                   = GetObject<RectTransform>(new IntPtr(p + 0x038), ReversePrism.DataModels.RectTransform.FromPointer); // 0x38 Content                     ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.DragDropTargetVisualization               = GetObject<Image>(new IntPtr(p + 0x040), ReversePrism.DataModels.Image.FromPointer); // 0x40 DragDropTargetVisualization ( ModelClassType Image Image Image Pointer )
            value.Canvas                                    = GetObject<Canvas>(new IntPtr(p + 0x048), ReversePrism.DataModels.Canvas.FromPointer); // 0x48 Canvas                      ( ModelClassType Canvas Canvas Canvas Pointer )
            value.RectTransform                             = GetObject<RectTransform>(new IntPtr(p + 0x050), ReversePrism.DataModels.RectTransform.FromPointer); // 0x50 RectTransform               ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.Height                                    = GetSingle(new IntPtr(p + 0x058)); // 0x58 Height                      ( ModelPrimitiveType float float float Single )
            value.Pointer                                   = GetObject<PointerEventData>(new IntPtr(p + 0x060), ReversePrism.DataModels.PointerEventData.FromPointer); // 0x60 Pointer                     ( ModelClassType PointerEventData PointerEventData PointerEventData Pointer )
            value.WorldCamera                               = GetObject<Camera>(new IntPtr(p + 0x068), ReversePrism.DataModels.Camera.FromPointer); // 0x68 WorldCamera                 ( ModelClassType Camera Camera Camera Pointer )
            value.PointerLastYPos                           = GetSingle(new IntPtr(p + 0x070)); // 0x70 PointerLastYPos             ( ModelPrimitiveType float float float Single )
            value.NextPointerValidation                     = GetSingle(new IntPtr(p + 0x074)); // 0x74 NextPointerValidation       ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
