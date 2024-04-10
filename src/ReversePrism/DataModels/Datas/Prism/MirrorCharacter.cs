using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AdjustOutline                            0001866656B0 ModelPrimitiveType float float float Single
    // 028 dicTrans                                 Dictionary`2<Transform, Transform> IL2CPP_TYPE_GENERICINST
    // 030 dicHipTransform                          Dictionary`2<Transform, bool> IL2CPP_TYPE_GENERICINST
    // 038 ListCharacterRoot                        000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    // 040 ListCharacterSrc                         000185CCC868 ModelClassListType List`1<AngelRingController> List`1<AngelRingController> List<AngelRingController> Pointer
    // 048 CachedRendererListExecutor               000186522B30 ModelClassType CachedRendererListExecutor CachedRendererListExecutor CachedRendererListExecutor Pointer
    // 050 RingRot                                  00018660D8C0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 090 Radius                                   0001866656B0 ModelPrimitiveType float float float Single
    // 094 CenterPos                                0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class MirrorCharacter : DataModel
    {
        public float                                    AdjustOutline                           { get; set; }
        public List<GameObject>?                        ListCharacterRoot                       { get; set; }
        public List<AngelRingController>?               ListCharacterSrc                        { get; set; }
        public CachedRendererListExecutor?              CachedRendererListExecutor              { get; set; }
        public Matrix4x4                                RingRot                                 { get; set; }
        public float                                    Radius                                  { get; set; }
        public Vector3                                  CenterPos                               { get; set; }

        public static MirrorCharacter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MirrorCharacter() { Pointer= p0 };

            value.AdjustOutline                             = GetSingle(new IntPtr(p + 0x020)); // 0245A6B03BE8 0x20 AdjustOutline               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ListCharacterRoot                         = GetObjectList<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0245A6B03C48 0x38 ListCharacterRoot           ( 000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )
            value.ListCharacterSrc                          = GetObjectList<AngelRingController>(new IntPtr(p + 0x040), ReversePrism.DataModels.AngelRingController.FromPointer); // 0245A6B03C68 0x40 ListCharacterSrc            ( 000185CCC868 ModelClassListType List`1<AngelRingController> List`1<AngelRingController> List<AngelRingController> Pointer )
            value.CachedRendererListExecutor                = GetObject<CachedRendererListExecutor>(new IntPtr(p + 0x048), ReversePrism.DataModels.CachedRendererListExecutor.FromPointer); // 0245A6B03C88 0x48 CachedRendererListExecutor  ( 000186522B30 ModelClassType CachedRendererListExecutor CachedRendererListExecutor CachedRendererListExecutor Pointer )
            value.RingRot                                   = (Matrix4x4)GetInt32(new IntPtr(p + 0x050)); // 0245A6B03CA8 0x50 RingRot                     ( 00018660D8C0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.Radius                                    = GetSingle(new IntPtr(p + 0x090)); // 0245A6B03CC8 0x90 Radius                      ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CenterPos                                 = (Vector3)GetInt32(new IntPtr(p + 0x094)); // 0245A6B03CE8 0x94 CenterPos                   ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
