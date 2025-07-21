using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Camera                                   ModelClassType CameraController CameraController CameraController Pointer
    // 028 BaseObject                               ModelClassType GameObject GameObject GameObject Pointer
    // 030 OutlineAdjust                            ModelPrimitiveType float float float Single
    // 034 ColorAdd                                 ModelEnumType Color Color Color Int32
    // 044 OutlineInclusive                         ModelPrimitiveType float float float Single
    // 048 OutlineResizeRate                        ModelPrimitiveType float float float Single
    // 04C AdjustValue                              ModelPrimitiveType float float float Single
    // 050 Character                                ModelClassType Character Character Character Pointer
    // 058 ShadeDir                                 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 068 CachedRendererListExecutor               ModelClassType CachedRendererListExecutor CachedRendererListExecutor CachedRendererListExecutor Pointer
    // 000 AttenuationRange                         float IL2CPP_TYPE_R4
    // 070 FovDistance                              ModelPrimitiveType float float float Single
    public partial class OutlineController : DataModel
    {
        public CameraController?                        Camera                                  { get; set; }
        public GameObject?                              BaseObject                              { get; set; }
        public float                                    OutlineAdjust                           { get; set; }
        public Color                                    ColorAdd                                { get; set; }
        public float                                    OutlineInclusive                        { get; set; }
        public float                                    OutlineResizeRate                       { get; set; }
        public float                                    AdjustValue                             { get; set; }
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

            value.Camera                                    = GetObject<CameraController>(new IntPtr(p + 0x020), ReversePrism.DataModels.CameraController.FromPointer); // 0x20 Camera                      ( ModelClassType CameraController CameraController CameraController Pointer )
            value.BaseObject                                = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 BaseObject                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.OutlineAdjust                             = GetSingle(new IntPtr(p + 0x030)); // 0x30 OutlineAdjust               ( ModelPrimitiveType float float float Single )
            value.ColorAdd                                  = (Color)GetInt32(new IntPtr(p + 0x034)); // 0x34 ColorAdd                    ( ModelEnumType Color Color Color Int32 )
            value.OutlineInclusive                          = GetSingle(new IntPtr(p + 0x044)); // 0x44 OutlineInclusive            ( ModelPrimitiveType float float float Single )
            value.OutlineResizeRate                         = GetSingle(new IntPtr(p + 0x048)); // 0x48 OutlineResizeRate           ( ModelPrimitiveType float float float Single )
            value.AdjustValue                               = GetSingle(new IntPtr(p + 0x04C)); // 0x4C AdjustValue                 ( ModelPrimitiveType float float float Single )
            value.Character                                 = GetObject<Character>(new IntPtr(p + 0x050), ReversePrism.DataModels.Character.FromPointer); // 0x50 Character                   ( ModelClassType Character Character Character Pointer )
            value.ShadeDir                                  = (Vector3)GetInt32(new IntPtr(p + 0x058)); // 0x58 ShadeDir                    ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.CachedRendererListExecutor                = GetObject<CachedRendererListExecutor>(new IntPtr(p + 0x068), ReversePrism.DataModels.CachedRendererListExecutor.FromPointer); // 0x68 CachedRendererListExecutor  ( ModelClassType CachedRendererListExecutor CachedRendererListExecutor CachedRendererListExecutor Pointer )
            value.FovDistance                               = GetSingle(new IntPtr(p + 0x070)); // 0x70 FovDistance                 ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
