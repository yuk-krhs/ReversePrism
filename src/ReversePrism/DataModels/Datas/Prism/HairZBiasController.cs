using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Character                                ModelClassType Character Character Character Pointer
    // 028 Atama                                    ModelClassType GameObject GameObject GameObject Pointer
    // 030 KataL                                    ModelClassType GameObject GameObject GameObject Pointer
    // 038 KataR                                    ModelClassType GameObject GameObject GameObject Pointer
    // 040 Spine                                    ModelClassType GameObject GameObject GameObject Pointer
    // 048 ReferencePosition                        ModelEnumType Vector3 Vector3 Vector3 Int32
    // 054 PlanePosition                            ModelEnumType Vector3 Vector3 Vector3 Int32
    // 060 PlaneNormal                              ModelEnumType Vector3 Vector3 Vector3 Int32
    // 070 RootBone                                 ModelClassType GameObject GameObject GameObject Pointer
    // 078 CameraDir                                ModelEnumType Vector3 Vector3 Vector3 Int32
    // 088 CachedRendererListExecutor               ModelClassType CachedRendererListExecutor CachedRendererListExecutor CachedRendererListExecutor Pointer
    public partial class HairZBiasController : DataModel
    {
        public Character?                               Character                               { get; set; }
        public GameObject?                              Atama                                   { get; set; }
        public GameObject?                              KataL                                   { get; set; }
        public GameObject?                              KataR                                   { get; set; }
        public GameObject?                              Spine                                   { get; set; }
        public Vector3                                  ReferencePosition                       { get; set; }
        public Vector3                                  PlanePosition                           { get; set; }
        public Vector3                                  PlaneNormal                             { get; set; }
        public GameObject?                              RootBone                                { get; set; }
        public Vector3                                  CameraDir                               { get; set; }
        public CachedRendererListExecutor?              CachedRendererListExecutor              { get; set; }

        public static HairZBiasController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HairZBiasController() { Pointer= p0 };

            value.Character                                 = GetObject<Character>(new IntPtr(p + 0x020), ReversePrism.DataModels.Character.FromPointer); // 0x20 Character                   ( ModelClassType Character Character Character Pointer )
            value.Atama                                     = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 Atama                       ( ModelClassType GameObject GameObject GameObject Pointer )
            value.KataL                                     = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 KataL                       ( ModelClassType GameObject GameObject GameObject Pointer )
            value.KataR                                     = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 KataR                       ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Spine                                     = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 Spine                       ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ReferencePosition                         = (Vector3)GetInt32(new IntPtr(p + 0x048)); // 0x48 ReferencePosition           ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.PlanePosition                             = (Vector3)GetInt32(new IntPtr(p + 0x054)); // 0x54 PlanePosition               ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.PlaneNormal                               = (Vector3)GetInt32(new IntPtr(p + 0x060)); // 0x60 PlaneNormal                 ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.RootBone                                  = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 RootBone                    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CameraDir                                 = (Vector3)GetInt32(new IntPtr(p + 0x078)); // 0x78 CameraDir                   ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.CachedRendererListExecutor                = GetObject<CachedRendererListExecutor>(new IntPtr(p + 0x088), ReversePrism.DataModels.CachedRendererListExecutor.FromPointer); // 0x88 CachedRendererListExecutor  ( ModelClassType CachedRendererListExecutor CachedRendererListExecutor CachedRendererListExecutor Pointer )

            return value;
        }
    }
}
