using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_AssetsPPU                              ModelPrimitiveType int int int Int32
    // 024 M_RefResolutionX                         ModelPrimitiveType int int int Int32
    // 028 M_RefResolutionY                         ModelPrimitiveType int int int Int32
    // 02C M_CropFrame                              ModelEnumType CropFrame CropFrame CropFrame Int32
    // 030 M_GridSnapping                           ModelEnumType GridSnapping GridSnapping GridSnapping Int32
    // 034 M_FilterMode                             ModelEnumType PixelPerfectFilterMode PixelPerfectFilterMode PixelPerfectFilterMode Int32
    // 038 M_Camera                                 ModelClassType Camera Camera Camera Pointer
    // 040 M_Internal                               ModelClassType PixelPerfectCameraInternal PixelPerfectCameraInternal PixelPerfectCameraInternal Pointer
    // 048 M_CinemachineCompatibilityMode           ModelPrimitiveType bool bool bool Bool
    public partial class PixelPerfectCamera : DataModel
    {
        public int                                      M_AssetsPPU                             { get; set; }
        public int                                      M_RefResolutionX                        { get; set; }
        public int                                      M_RefResolutionY                        { get; set; }
        public CropFrame                                M_CropFrame                             { get; set; }
        public GridSnapping                             M_GridSnapping                          { get; set; }
        public PixelPerfectFilterMode                   M_FilterMode                            { get; set; }
        public Camera?                                  M_Camera                                { get; set; }
        public PixelPerfectCameraInternal?              M_Internal                              { get; set; }
        public bool                                     M_CinemachineCompatibilityMode          { get; set; }

        public static PixelPerfectCamera? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PixelPerfectCamera() { Pointer= p0 };

            value.M_AssetsPPU                               = GetInt32(new IntPtr(p + 0x020)); // 0x20 M_AssetsPPU                 ( ModelPrimitiveType int int int Int32 )
            value.M_RefResolutionX                          = GetInt32(new IntPtr(p + 0x024)); // 0x24 M_RefResolutionX            ( ModelPrimitiveType int int int Int32 )
            value.M_RefResolutionY                          = GetInt32(new IntPtr(p + 0x028)); // 0x28 M_RefResolutionY            ( ModelPrimitiveType int int int Int32 )
            value.M_CropFrame                               = (CropFrame)GetInt32(new IntPtr(p + 0x02C)); // 0x2C M_CropFrame                 ( ModelEnumType CropFrame CropFrame CropFrame Int32 )
            value.M_GridSnapping                            = (GridSnapping)GetInt32(new IntPtr(p + 0x030)); // 0x30 M_GridSnapping              ( ModelEnumType GridSnapping GridSnapping GridSnapping Int32 )
            value.M_FilterMode                              = (PixelPerfectFilterMode)GetInt32(new IntPtr(p + 0x034)); // 0x34 M_FilterMode                ( ModelEnumType PixelPerfectFilterMode PixelPerfectFilterMode PixelPerfectFilterMode Int32 )
            value.M_Camera                                  = GetObject<Camera>(new IntPtr(p + 0x038), ReversePrism.DataModels.Camera.FromPointer); // 0x38 M_Camera                    ( ModelClassType Camera Camera Camera Pointer )
            value.M_Internal                                = GetObject<PixelPerfectCameraInternal>(new IntPtr(p + 0x040), ReversePrism.DataModels.PixelPerfectCameraInternal.FromPointer); // 0x40 M_Internal                  ( ModelClassType PixelPerfectCameraInternal PixelPerfectCameraInternal PixelPerfectCameraInternal Pointer )
            value.M_CinemachineCompatibilityMode            = GetBool(new IntPtr(p + 0x048)); // 0x48 M_CinemachineCompatibilityMode ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
