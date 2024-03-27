using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 POINTER_VALIDATE_INTERVAL                float IL2CPP_TYPE_R4
    // 020 SiblingIndexModificationArea             0001866656B0 ModelPrimitiveType float float float Single
    // 024 ScrollableArea                           0001866656B0 ModelPrimitiveType float float float Single
    // 028 1OverScrollableArea                      0001866656B0 ModelPrimitiveType float float float Single
    // 02C ScrollSpeed                              0001866656B0 ModelPrimitiveType float float float Single
    // 030 Hierarchy                                000186699A60 ModelClassType RuntimeHierarchy RuntimeHierarchy RuntimeHierarchy Pointer
    // 038 Content                                  000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 040 DragDropTargetVisualization              0001866CCDB0 ModelClassType Image Image Image Pointer
    // 048 Canvas                                   00018653FDA0 ModelClassType Canvas Canvas Canvas Pointer
    // 050 RectTransform                            000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 058 Height                                   0001866656B0 ModelPrimitiveType float float float Single
    // 060 Pointer                                  000186642240 ModelClassType PointerEventData PointerEventData PointerEventData Pointer
    // 068 WorldCamera                              0001865A1C90 ModelClassType Camera Camera Camera Pointer
    // 070 PointerLastYPos                          0001866656B0 ModelPrimitiveType float float float Single
    // 074 NextPointerValidation                    0001866656B0 ModelPrimitiveType float float float Single
    public partial class HierarchyDragDropListener
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
            var value   = new HierarchyDragDropListener();

            value.SiblingIndexModificationArea              = GetSingle(new IntPtr(p + 0x020)); // 0270DB194220 0x20 SiblingIndexModificationArea ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ScrollableArea                            = GetSingle(new IntPtr(p + 0x024)); // 0270DB194240 0x24 ScrollableArea              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.1OverScrollableArea                       = GetSingle(new IntPtr(p + 0x028)); // 0270DB194260 0x28 1OverScrollableArea         ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ScrollSpeed                               = GetSingle(new IntPtr(p + 0x02C)); // 0270DB194280 0x2C ScrollSpeed                 ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Hierarchy                                 = GetObject<RuntimeHierarchy>(new IntPtr(p + 0x030), ReversePrism.DataModels.RuntimeHierarchy.FromPointer); // 0270DB1942A0 0x30 Hierarchy                   ( 000186699A60 ModelClassType RuntimeHierarchy RuntimeHierarchy RuntimeHierarchy Pointer )
            value.Content                                   = GetObject<RectTransform>(new IntPtr(p + 0x038), ReversePrism.DataModels.RectTransform.FromPointer); // 0270DB1942C0 0x38 Content                     ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.DragDropTargetVisualization               = GetObject<Image>(new IntPtr(p + 0x040), ReversePrism.DataModels.Image.FromPointer); // 0270DB1942E0 0x40 DragDropTargetVisualization ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.Canvas                                    = GetObject<Canvas>(new IntPtr(p + 0x048), ReversePrism.DataModels.Canvas.FromPointer); // 0270DB194300 0x48 Canvas                      ( 00018653FDA0 ModelClassType Canvas Canvas Canvas Pointer )
            value.RectTransform                             = GetObject<RectTransform>(new IntPtr(p + 0x050), ReversePrism.DataModels.RectTransform.FromPointer); // 0270DB194320 0x50 RectTransform               ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.Height                                    = GetSingle(new IntPtr(p + 0x058)); // 0270DB194340 0x58 Height                      ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Pointer                                   = GetObject<PointerEventData>(new IntPtr(p + 0x060), ReversePrism.DataModels.PointerEventData.FromPointer); // 0270DB194360 0x60 Pointer                     ( 000186642240 ModelClassType PointerEventData PointerEventData PointerEventData Pointer )
            value.WorldCamera                               = GetObject<Camera>(new IntPtr(p + 0x068), ReversePrism.DataModels.Camera.FromPointer); // 0270DB194380 0x68 WorldCamera                 ( 0001865A1C90 ModelClassType Camera Camera Camera Pointer )
            value.PointerLastYPos                           = GetSingle(new IntPtr(p + 0x070)); // 0270DB1943A0 0x70 PointerLastYPos             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.NextPointerValidation                     = GetSingle(new IntPtr(p + 0x074)); // 0270DB1943C0 0x74 NextPointerValidation       ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
