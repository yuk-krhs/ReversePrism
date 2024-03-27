using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Character                                000186596FD0 ModelClassType Character Character Character Pointer
    // 028 Atama                                    0001865D8420 ModelClassType GameObject GameObject GameObject Pointer
    // 030 KataL                                    0001865D8420 ModelClassType GameObject GameObject GameObject Pointer
    // 038 KataR                                    0001865D8420 ModelClassType GameObject GameObject GameObject Pointer
    // 040 Spine                                    0001865D8420 ModelClassType GameObject GameObject GameObject Pointer
    // 048 ReferencePosition                        0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 054 PlanePosition                            0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 060 PlaneNormal                              0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 070 RootBone                                 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer
    // 078 CameraDir                                0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 088 CachedRendererListExecutor               000186522B30 ModelClassType CachedRendererListExecutor CachedRendererListExecutor CachedRendererListExecutor Pointer
    // 090 RenderCameraSettingId                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class HairZBiasController
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
        public int                                      RenderCameraSettingId                   { get; set; }

        public static HairZBiasController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HairZBiasController();

            value.Character                                 = GetObject<Character>(new IntPtr(p + 0x020), ReversePrism.DataModels.Character.FromPointer); // 027006A184F8 0x20 Character                   ( 000186596FD0 ModelClassType Character Character Character Pointer )
            value.Atama                                     = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 027006A18518 0x28 Atama                       ( 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer )
            value.KataL                                     = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 027006A18538 0x30 KataL                       ( 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer )
            value.KataR                                     = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 027006A18558 0x38 KataR                       ( 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer )
            value.Spine                                     = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 027006A18578 0x40 Spine                       ( 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer )
            value.ReferencePosition                         = (Vector3)GetInt32(new IntPtr(p + 0x048)); // 027006A18598 0x48 ReferencePosition           ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.PlanePosition                             = (Vector3)GetInt32(new IntPtr(p + 0x054)); // 027006A185B8 0x54 PlanePosition               ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.PlaneNormal                               = (Vector3)GetInt32(new IntPtr(p + 0x060)); // 027006A185D8 0x60 PlaneNormal                 ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.RootBone                                  = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 027006A185F8 0x70 RootBone                    ( 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer )
            value.CameraDir                                 = (Vector3)GetInt32(new IntPtr(p + 0x078)); // 027006A18618 0x78 CameraDir                   ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.CachedRendererListExecutor                = GetObject<CachedRendererListExecutor>(new IntPtr(p + 0x088), ReversePrism.DataModels.CachedRendererListExecutor.FromPointer); // 027006A18638 0x88 CachedRendererListExecutor  ( 000186522B30 ModelClassType CachedRendererListExecutor CachedRendererListExecutor CachedRendererListExecutor Pointer )
            value.RenderCameraSettingId                     = GetInt32(new IntPtr(p + 0x090)); // 027006A18658 0x90 RenderCameraSettingId       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
