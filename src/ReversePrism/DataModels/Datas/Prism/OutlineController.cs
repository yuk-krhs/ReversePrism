using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Camera                                   000186536460 ModelClassType CameraController CameraController CameraController Pointer
    // 028 BaseObject                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 OutlineAdjust                            0001866656B0 ModelPrimitiveType float float float Single
    // 034 ColorAdd                                 0001865AA8E0 ModelEnumType Color Color Color Int32
    // 044 OutlineInclusive                         0001866656B0 ModelPrimitiveType float float float Single
    // 048 OutlineResizeRate                        0001866656B0 ModelPrimitiveType float float float Single
    // 04C AdjustValue                              0001866656B0 ModelPrimitiveType float float float Single
    // 050 OutlineObject                            0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 058 Character                                000186596FD0 ModelClassType Character Character Character Pointer
    // 060 ShadeDir                                 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 070 CachedRendererListExecutor               000186522B30 ModelClassType CachedRendererListExecutor CachedRendererListExecutor CachedRendererListExecutor Pointer
    // 000 AttenuationRange                         float IL2CPP_TYPE_R4
    // 078 FovDistance                              0001866656B0 ModelPrimitiveType float float float Single
    public partial class OutlineController : DataModel
    {
        public CameraController?                        Camera                                  { get; set; }
        public GameObject?                              BaseObject                              { get; set; }
        public float                                    OutlineAdjust                           { get; set; }
        public Color                                    ColorAdd                                { get; set; }
        public float                                    OutlineInclusive                        { get; set; }
        public float                                    OutlineResizeRate                       { get; set; }
        public float                                    AdjustValue                             { get; set; }
        public GameObject?                              OutlineObject                           { get; set; }
        public Character?                               Character                               { get; set; }
        public Vector3                                  ShadeDir                                { get; set; }
        public CachedRendererListExecutor?              CachedRendererListExecutor              { get; set; }
        public float                                    FovDistance                             { get; set; }

        public static OutlineController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OutlineController() { Pointer= p0 };

            value.Camera                                    = GetObject<CameraController>(new IntPtr(p + 0x020), ReversePrism.DataModels.CameraController.FromPointer); // 0245A69CE498 0x20 Camera                      ( 000186536460 ModelClassType CameraController CameraController CameraController Pointer )
            value.BaseObject                                = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0245A69CE4B8 0x28 BaseObject                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.OutlineAdjust                             = GetSingle(new IntPtr(p + 0x030)); // 0245A69CE4D8 0x30 OutlineAdjust               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ColorAdd                                  = (Color)GetInt32(new IntPtr(p + 0x034)); // 0245A69CE4F8 0x34 ColorAdd                    ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.OutlineInclusive                          = GetSingle(new IntPtr(p + 0x044)); // 0245A69CE518 0x44 OutlineInclusive            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.OutlineResizeRate                         = GetSingle(new IntPtr(p + 0x048)); // 0245A69CE538 0x48 OutlineResizeRate           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.AdjustValue                               = GetSingle(new IntPtr(p + 0x04C)); // 0245A69CE558 0x4C AdjustValue                 ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.OutlineObject                             = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0245A69CE578 0x50 OutlineObject               ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Character                                 = GetObject<Character>(new IntPtr(p + 0x058), ReversePrism.DataModels.Character.FromPointer); // 0245A69CE598 0x58 Character                   ( 000186596FD0 ModelClassType Character Character Character Pointer )
            value.ShadeDir                                  = (Vector3)GetInt32(new IntPtr(p + 0x060)); // 0245A69CE5B8 0x60 ShadeDir                    ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.CachedRendererListExecutor                = GetObject<CachedRendererListExecutor>(new IntPtr(p + 0x070), ReversePrism.DataModels.CachedRendererListExecutor.FromPointer); // 0245A69CE5D8 0x70 CachedRendererListExecutor  ( 000186522B30 ModelClassType CachedRendererListExecutor CachedRendererListExecutor CachedRendererListExecutor Pointer )
            value.FovDistance                               = GetSingle(new IntPtr(p + 0x078)); // 0245A69CE618 0x78 FovDistance                 ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
