using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PositionBone                             ModelClassType GameObject GameObject GameObject Pointer
    // 028 PositionOffset                           ModelEnumType Vector3 Vector3 Vector3 Int32
    // 038 DirectionBone                            ModelClassType GameObject GameObject GameObject Pointer
    // 040 DirectionFace                            ModelEnumType Vector3 Vector3 Vector3 Int32
    // 04C DrawColor                                ModelEnumType Color Color Color Int32
    // 060 Bones                                    ModelClassListType Transform[] Transform[] List<Transform> Pointer
    // 068 FaceRadius                               ModelPrimitiveType float float float Single
    // 06C PlanePosition                            ModelEnumType Vector3 Vector3 Vector3 Int32
    // 078 PlaneNormal                              ModelEnumType Vector3 Vector3 Vector3 Int32
    // 088 Renderers                                ModelClassListType Renderer[] Renderer[] List<Renderer> Pointer
    // 090 CurrentLight                             ModelClassType Light Light Light Pointer
    // 098 LightDir                                 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 0A8 _myMaterials                             Material[][] IL2CPP_TYPE_SZARRAY
    public partial class DropShadowParameter : DataModel
    {
        public GameObject?                              PositionBone                            { get; set; }
        public Vector3                                  PositionOffset                          { get; set; }
        public GameObject?                              DirectionBone                           { get; set; }
        public Vector3                                  DirectionFace                           { get; set; }
        public Color                                    DrawColor                               { get; set; }
        public List<Transform>?                         Bones                                   { get; set; }
        public float                                    FaceRadius                              { get; set; }
        public Vector3                                  PlanePosition                           { get; set; }
        public Vector3                                  PlaneNormal                             { get; set; }
        public List<Renderer>?                          Renderers                               { get; set; }
        public Light?                                   CurrentLight                            { get; set; }
        public Vector3                                  LightDir                                { get; set; }

        public static DropShadowParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DropShadowParameter() { Pointer= p0 };

            value.PositionBone                              = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 PositionBone                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.PositionOffset                            = (Vector3)GetInt32(new IntPtr(p + 0x028)); // 0x28 PositionOffset              ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.DirectionBone                             = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 DirectionBone               ( ModelClassType GameObject GameObject GameObject Pointer )
            value.DirectionFace                             = (Vector3)GetInt32(new IntPtr(p + 0x040)); // 0x40 DirectionFace               ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.DrawColor                                 = (Color)GetInt32(new IntPtr(p + 0x04C)); // 0x4C DrawColor                   ( ModelEnumType Color Color Color Int32 )
            value.Bones                                     = GetObjectList<Transform>(new IntPtr(p + 0x060), ReversePrism.DataModels.Transform.FromPointer); // 0x60 Bones                       ( ModelClassListType Transform[] Transform[] List<Transform> Pointer )
            value.FaceRadius                                = GetSingle(new IntPtr(p + 0x068)); // 0x68 FaceRadius                  ( ModelPrimitiveType float float float Single )
            value.PlanePosition                             = (Vector3)GetInt32(new IntPtr(p + 0x06C)); // 0x6C PlanePosition               ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.PlaneNormal                               = (Vector3)GetInt32(new IntPtr(p + 0x078)); // 0x78 PlaneNormal                 ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Renderers                                 = GetObjectList<Renderer>(new IntPtr(p + 0x088), ReversePrism.DataModels.Renderer.FromPointer); // 0x88 Renderers                   ( ModelClassListType Renderer[] Renderer[] List<Renderer> Pointer )
            value.CurrentLight                              = GetObject<Light>(new IntPtr(p + 0x090), ReversePrism.DataModels.Light.FromPointer); // 0x90 CurrentLight                ( ModelClassType Light Light Light Pointer )
            value.LightDir                                  = (Vector3)GetInt32(new IntPtr(p + 0x098)); // 0x98 LightDir                    ( ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
