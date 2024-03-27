using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BaseAspectRatio                          0001866AA380 ModelEnumType Vector2Int Vector2Int Vector2Int Int32
    // 028 BaseCameraSize                           0001866656B0 ModelPrimitiveType float float float Single
    // 02C BaseCameraFOV                            0001866656B0 ModelPrimitiveType float float float Single
    // 030 ShowBaseAspectArea                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 034 BaseAspectAreaColor                      0001865AA8E0 ModelEnumType Color Color Color Int32
    // 048 Camera                                   0001865A1C90 ModelClassType Camera Camera Camera Pointer
    // 050 BaseAspectAreaMat                        00018660BDD0 ModelClassType Material Material Material Pointer
    public partial class CameraSizeAdjuster
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
            var value   = new CameraSizeAdjuster();

            value.BaseAspectRatio                           = (Vector2Int)GetInt32(new IntPtr(p + 0x020)); // 0270D4C4B990 0x20 BaseAspectRatio             ( 0001866AA380 ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.BaseCameraSize                            = GetSingle(new IntPtr(p + 0x028)); // 0270D4C4B9B0 0x28 BaseCameraSize              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.BaseCameraFOV                             = GetSingle(new IntPtr(p + 0x02C)); // 0270D4C4B9D0 0x2C BaseCameraFOV               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ShowBaseAspectArea                        = GetBool(new IntPtr(p + 0x030)); // 0270D4C4B9F0 0x30 ShowBaseAspectArea          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.BaseAspectAreaColor                       = (Color)GetInt32(new IntPtr(p + 0x034)); // 0270D4C4BA10 0x34 BaseAspectAreaColor         ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.Camera                                    = GetObject<Camera>(new IntPtr(p + 0x048), ReversePrism.DataModels.Camera.FromPointer); // 0270D4C4BA30 0x48 Camera                      ( 0001865A1C90 ModelClassType Camera Camera Camera Pointer )
            value.BaseAspectAreaMat                         = GetObject<Material>(new IntPtr(p + 0x050), ReversePrism.DataModels.Material.FromPointer); // 0270D4C4BA50 0x50 BaseAspectAreaMat           ( 00018660BDD0 ModelClassType Material Material Material Pointer )

            return value;
        }
    }
}
