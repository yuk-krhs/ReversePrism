using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 FarPlaneFitter                           ModelClassType FarPlaneFitter FarPlaneFitter FarPlaneFitter Pointer
    // 028 UvRect                                   ModelEnumType Rect Rect Rect Int32
    // 038 ZRate                                    ModelPrimitiveType float float float Single
    // 040 TargetCam                                ModelClassType Camera Camera Camera Pointer
    // 048 Initialized                              ModelPrimitiveType bool bool bool Bool
    // 04C Offset                                   ModelEnumType Vector2 Vector2 Vector2 Int32
    // 054 Scale                                    ModelEnumType Vector2 Vector2 Vector2 Int32
    // 060 InitialVertices                          ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    public partial class AddPlaneForFarFit : DataModel
    {
        public FarPlaneFitter?                          FarPlaneFitter                          { get; set; }
        public Rect                                     UvRect                                  { get; set; }
        public float                                    ZRate                                   { get; set; }
        public Camera?                                  TargetCam                               { get; set; }
        public bool                                     Initialized                             { get; set; }
        public Vector2                                  Offset                                  { get; set; }
        public Vector2                                  Scale                                   { get; set; }
        public List<Vector3>?                           InitialVertices                         { get; set; }

        public static AddPlaneForFarFit? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AddPlaneForFarFit() { Pointer= p0 };

            value.FarPlaneFitter                            = GetObject<FarPlaneFitter>(new IntPtr(p + 0x020), ReversePrism.DataModels.FarPlaneFitter.FromPointer); // 0x20 FarPlaneFitter              ( ModelClassType FarPlaneFitter FarPlaneFitter FarPlaneFitter Pointer )
            value.UvRect                                    = (Rect)GetInt32(new IntPtr(p + 0x028)); // 0x28 UvRect                      ( ModelEnumType Rect Rect Rect Int32 )
            value.ZRate                                     = GetSingle(new IntPtr(p + 0x038)); // 0x38 ZRate                       ( ModelPrimitiveType float float float Single )
            value.TargetCam                                 = GetObject<Camera>(new IntPtr(p + 0x040), ReversePrism.DataModels.Camera.FromPointer); // 0x40 TargetCam                   ( ModelClassType Camera Camera Camera Pointer )
            value.Initialized                               = GetBool(new IntPtr(p + 0x048)); // 0x48 Initialized                 ( ModelPrimitiveType bool bool bool Bool )
            value.Offset                                    = (Vector2)GetInt32(new IntPtr(p + 0x04C)); // 0x4C Offset                      ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Scale                                     = (Vector2)GetInt32(new IntPtr(p + 0x054)); // 0x54 Scale                       ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.InitialVertices                           = GetEnumList<Vector3>(new IntPtr(p + 0x060)); // 0x60 InitialVertices             ( ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )

            return value;
        }
    }
}
