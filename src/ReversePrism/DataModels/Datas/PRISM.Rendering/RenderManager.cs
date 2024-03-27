using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 <FramePerSec>k__BackingField             int IL2CPP_TYPE_I4
    // 008 cameraRenderDataList                     List`1<CameraRenderData> IL2CPP_TYPE_GENERICINST
    // 010 DefaultScreenWidth                       0001865F4040 ModelPrimitiveType int int int Int32
    // 014 DefaultScreenHeight                      0001865F4040 ModelPrimitiveType int int int Int32
    // 018 OnBeforeCharacterRendering               0001866CEBB0 ModelClassType RenderCallback RenderCallback RenderCallback Pointer
    // 020 OnBeforeTransparentRendering             0001866CE910 ModelClassType RenderCallback RenderCallback RenderCallback Pointer
    // 028 OnBeforeRendering3D                      0001866CE910 ModelClassType RenderCallback RenderCallback RenderCallback Pointer
    // 030 OnUpdateCameraSetting                    000186740390 ModelClassType UpdateCameraSettingList UpdateCameraSettingList UpdateCameraSettingList Pointer
    public partial class RenderManager
    {
        public int                                      DefaultScreenWidth                      { get; set; }
        public int                                      DefaultScreenHeight                     { get; set; }
        public RenderCallback?                          OnBeforeCharacterRendering              { get; set; }
        public RenderCallback?                          OnBeforeTransparentRendering            { get; set; }
        public RenderCallback?                          OnBeforeRendering3D                     { get; set; }
        public UpdateCameraSettingList?                 OnUpdateCameraSetting                   { get; set; }

        public static RenderManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderManager();

            value.DefaultScreenWidth                        = GetInt32(new IntPtr(p + 0x010)); // 0270D0AC3740 0x10 DefaultScreenWidth          ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.DefaultScreenHeight                       = GetInt32(new IntPtr(p + 0x014)); // 0270D0AC3760 0x14 DefaultScreenHeight         ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.OnBeforeCharacterRendering                = GetObject<RenderCallback>(new IntPtr(p + 0x018), ReversePrism.DataModels.RenderCallback.FromPointer); // 0270D0AC3780 0x18 OnBeforeCharacterRendering  ( 0001866CEBB0 ModelClassType RenderCallback RenderCallback RenderCallback Pointer )
            value.OnBeforeTransparentRendering              = GetObject<RenderCallback>(new IntPtr(p + 0x020), ReversePrism.DataModels.RenderCallback.FromPointer); // 0270D0AC37A0 0x20 OnBeforeTransparentRendering ( 0001866CE910 ModelClassType RenderCallback RenderCallback RenderCallback Pointer )
            value.OnBeforeRendering3D                       = GetObject<RenderCallback>(new IntPtr(p + 0x028), ReversePrism.DataModels.RenderCallback.FromPointer); // 0270D0AC37C0 0x28 OnBeforeRendering3D         ( 0001866CE910 ModelClassType RenderCallback RenderCallback RenderCallback Pointer )
            value.OnUpdateCameraSetting                     = GetObject<UpdateCameraSettingList>(new IntPtr(p + 0x030), ReversePrism.DataModels.UpdateCameraSettingList.FromPointer); // 0270D0AC37E0 0x30 OnUpdateCameraSetting       ( 000186740390 ModelClassType UpdateCameraSettingList UpdateCameraSettingList UpdateCameraSettingList Pointer )

            return value;
        }
    }
}
