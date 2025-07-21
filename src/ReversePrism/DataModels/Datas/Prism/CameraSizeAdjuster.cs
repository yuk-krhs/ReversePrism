using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BaseAspectRatio                          ModelEnumType Vector2Int Vector2Int Vector2Int Int32
    // 028 BaseCameraSize                           ModelPrimitiveType float float float Single
    // 02C BaseCameraFOV                            ModelPrimitiveType float float float Single
    // 030 ShowBaseAspectArea                       ModelPrimitiveType bool bool bool Bool
    // 034 BaseAspectAreaColor                      ModelEnumType Color Color Color Int32
    // 048 Camera                                   ModelClassType Camera Camera Camera Pointer
    // 050 BaseAspectAreaMat                        ModelClassType Material Material Material Pointer
    public partial class CameraSizeAdjuster : DataModel
    {
        public Vector2Int                               BaseAspectRatio                         { get; set; }
        public float                                    BaseCameraSize                          { get; set; }
        public float                                    BaseCameraFOV                           { get; set; }
        public bool                                     ShowBaseAspectArea                      { get; set; }
        public Color                                    BaseAspectAreaColor                     { get; set; }
        public Camera?                                  Camera                                  { get; set; }
        public Material?                                BaseAspectAreaMat                       { get; set; }

        public static CameraSizeAdjuster? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CameraSizeAdjuster() { Pointer= p0 };

            value.BaseAspectRatio                           = (Vector2Int)GetInt32(new IntPtr(p + 0x020)); // 0x20 BaseAspectRatio             ( ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.BaseCameraSize                            = GetSingle(new IntPtr(p + 0x028)); // 0x28 BaseCameraSize              ( ModelPrimitiveType float float float Single )
            value.BaseCameraFOV                             = GetSingle(new IntPtr(p + 0x02C)); // 0x2C BaseCameraFOV               ( ModelPrimitiveType float float float Single )
            value.ShowBaseAspectArea                        = GetBool(new IntPtr(p + 0x030)); // 0x30 ShowBaseAspectArea          ( ModelPrimitiveType bool bool bool Bool )
            value.BaseAspectAreaColor                       = (Color)GetInt32(new IntPtr(p + 0x034)); // 0x34 BaseAspectAreaColor         ( ModelEnumType Color Color Color Int32 )
            value.Camera                                    = GetObject<Camera>(new IntPtr(p + 0x048), ReversePrism.DataModels.Camera.FromPointer); // 0x48 Camera                      ( ModelClassType Camera Camera Camera Pointer )
            value.BaseAspectAreaMat                         = GetObject<Material>(new IntPtr(p + 0x050), ReversePrism.DataModels.Material.FromPointer); // 0x50 BaseAspectAreaMat           ( ModelClassType Material Material Material Pointer )

            return value;
        }
    }
}
