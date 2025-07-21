using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Component                              ModelClassType IPixelPerfectCamera IPixelPerfectCamera IPixelPerfectCamera Pointer
    // 018 M_SerializableComponent                  ModelClassType PixelPerfectCamera PixelPerfectCamera PixelPerfectCamera Pointer
    // 020 OriginalOrthoSize                        ModelPrimitiveType float float float Single
    // 024 HasPostProcessLayer                      ModelPrimitiveType bool bool bool Bool
    // 025 CropFrameXAndY                           ModelPrimitiveType bool bool bool Bool
    // 026 CropFrameXOrY                            ModelPrimitiveType bool bool bool Bool
    // 027 UseStretchFill                           ModelPrimitiveType bool bool bool Bool
    // 028 Zoom                                     ModelPrimitiveType int int int Int32
    // 02C UseOffscreenRT                           ModelPrimitiveType bool bool bool Bool
    // 030 OffscreenRTWidth                         ModelPrimitiveType int int int Int32
    // 034 OffscreenRTHeight                        ModelPrimitiveType int int int Int32
    // 038 PixelRect                                ModelEnumType Rect Rect Rect Int32
    // 048 OrthoSize                                ModelPrimitiveType float float float Single
    // 04C UnitsPerPixel                            ModelPrimitiveType float float float Single
    // 050 CinemachineVCamZoom                      ModelPrimitiveType int int int Int32
    // 054 RequiresUpscaling                        ModelPrimitiveType bool bool bool Bool
    public partial class PixelPerfectCameraInternal : DataModel
    {
        public IPixelPerfectCamera?                     M_Component                             { get; set; }
        public PixelPerfectCamera?                      M_SerializableComponent                 { get; set; }
        public float                                    OriginalOrthoSize                       { get; set; }
        public bool                                     HasPostProcessLayer                     { get; set; }
        public bool                                     CropFrameXAndY                          { get; set; }
        public bool                                     CropFrameXOrY                           { get; set; }
        public bool                                     UseStretchFill                          { get; set; }
        public int                                      Zoom                                    { get; set; }
        public bool                                     UseOffscreenRT                          { get; set; }
        public int                                      OffscreenRTWidth                        { get; set; }
        public int                                      OffscreenRTHeight                       { get; set; }
        public Rect                                     PixelRect                               { get; set; }
        public float                                    OrthoSize                               { get; set; }
        public float                                    UnitsPerPixel                           { get; set; }
        public int                                      CinemachineVCamZoom                     { get; set; }
        public bool                                     RequiresUpscaling                       { get; set; }

        public static PixelPerfectCameraInternal? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PixelPerfectCameraInternal() { Pointer= p0 };

            value.M_Component                               = GetObject<IPixelPerfectCamera>(new IntPtr(p + 0x010), ReversePrism.DataModels.IPixelPerfectCamera.FromPointer); // 0x10 M_Component                 ( ModelClassType IPixelPerfectCamera IPixelPerfectCamera IPixelPerfectCamera Pointer )
            value.M_SerializableComponent                   = GetObject<PixelPerfectCamera>(new IntPtr(p + 0x018), ReversePrism.DataModels.PixelPerfectCamera.FromPointer); // 0x18 M_SerializableComponent     ( ModelClassType PixelPerfectCamera PixelPerfectCamera PixelPerfectCamera Pointer )
            value.OriginalOrthoSize                         = GetSingle(new IntPtr(p + 0x020)); // 0x20 OriginalOrthoSize           ( ModelPrimitiveType float float float Single )
            value.HasPostProcessLayer                       = GetBool(new IntPtr(p + 0x024)); // 0x24 HasPostProcessLayer         ( ModelPrimitiveType bool bool bool Bool )
            value.CropFrameXAndY                            = GetBool(new IntPtr(p + 0x025)); // 0x25 CropFrameXAndY              ( ModelPrimitiveType bool bool bool Bool )
            value.CropFrameXOrY                             = GetBool(new IntPtr(p + 0x026)); // 0x26 CropFrameXOrY               ( ModelPrimitiveType bool bool bool Bool )
            value.UseStretchFill                            = GetBool(new IntPtr(p + 0x027)); // 0x27 UseStretchFill              ( ModelPrimitiveType bool bool bool Bool )
            value.Zoom                                      = GetInt32(new IntPtr(p + 0x028)); // 0x28 Zoom                        ( ModelPrimitiveType int int int Int32 )
            value.UseOffscreenRT                            = GetBool(new IntPtr(p + 0x02C)); // 0x2C UseOffscreenRT              ( ModelPrimitiveType bool bool bool Bool )
            value.OffscreenRTWidth                          = GetInt32(new IntPtr(p + 0x030)); // 0x30 OffscreenRTWidth            ( ModelPrimitiveType int int int Int32 )
            value.OffscreenRTHeight                         = GetInt32(new IntPtr(p + 0x034)); // 0x34 OffscreenRTHeight           ( ModelPrimitiveType int int int Int32 )
            value.PixelRect                                 = (Rect)GetInt32(new IntPtr(p + 0x038)); // 0x38 PixelRect                   ( ModelEnumType Rect Rect Rect Int32 )
            value.OrthoSize                                 = GetSingle(new IntPtr(p + 0x048)); // 0x48 OrthoSize                   ( ModelPrimitiveType float float float Single )
            value.UnitsPerPixel                             = GetSingle(new IntPtr(p + 0x04C)); // 0x4C UnitsPerPixel               ( ModelPrimitiveType float float float Single )
            value.CinemachineVCamZoom                       = GetInt32(new IntPtr(p + 0x050)); // 0x50 CinemachineVCamZoom         ( ModelPrimitiveType int int int Int32 )
            value.RequiresUpscaling                         = GetBool(new IntPtr(p + 0x054)); // 0x54 RequiresUpscaling           ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
