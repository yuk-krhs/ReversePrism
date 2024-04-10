using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 FarPlaneFitter                           0001865569B0 ModelClassType FarPlaneFitter FarPlaneFitter FarPlaneFitter Pointer
    // 028 UvRect                                   00018664F620 ModelEnumType Rect Rect Rect Int32
    // 038 ZRate                                    0001866656B0 ModelPrimitiveType float float float Single
    // 040 TargetCam                                0001865A1C90 ModelClassType Camera Camera Camera Pointer
    // 048 Initialized                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 04C Offset                                   0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 054 Scale                                    0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 060 InitialVertices                          000185CB0BC8 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
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

            value.FarPlaneFitter                            = GetObject<FarPlaneFitter>(new IntPtr(p + 0x020), ReversePrism.DataModels.FarPlaneFitter.FromPointer); // 024664DB7D90 0x20 FarPlaneFitter              ( 0001865569B0 ModelClassType FarPlaneFitter FarPlaneFitter FarPlaneFitter Pointer )
            value.UvRect                                    = (Rect)GetInt32(new IntPtr(p + 0x028)); // 024664DB7DB0 0x28 UvRect                      ( 00018664F620 ModelEnumType Rect Rect Rect Int32 )
            value.ZRate                                     = GetSingle(new IntPtr(p + 0x038)); // 024664DB7DD0 0x38 ZRate                       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.TargetCam                                 = GetObject<Camera>(new IntPtr(p + 0x040), ReversePrism.DataModels.Camera.FromPointer); // 024664DB7DF0 0x40 TargetCam                   ( 0001865A1C90 ModelClassType Camera Camera Camera Pointer )
            value.Initialized                               = GetBool(new IntPtr(p + 0x048)); // 024664DB7E10 0x48 Initialized                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Offset                                    = (Vector2)GetInt32(new IntPtr(p + 0x04C)); // 024664DB7E30 0x4C Offset                      ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Scale                                     = (Vector2)GetInt32(new IntPtr(p + 0x054)); // 024664DB7E50 0x54 Scale                       ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.InitialVertices                           = GetEnumList<Vector3>(new IntPtr(p + 0x060)); // 024664DB7E70 0x60 InitialVertices             ( 000185CB0BC8 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )

            return value;
        }
    }
}
