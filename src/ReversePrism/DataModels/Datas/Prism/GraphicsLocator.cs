using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 floorColliderController                  MagicaBodyParamPlaneColliderController IL2CPP_TYPE_CLASS
    // 008 GraphicsManager                          GraphicsManager IL2CPP_TYPE_CLASS
    // 010 EffectManager                            ModelClassType EffectManager EffectManager EffectManager Pointer
    // 018 CameraCaptureManager                     ModelClassType CameraCaptureManager CameraCaptureManager CameraCaptureManager Pointer
    public partial class GraphicsLocator : DataModel
    {
        public EffectManager?                           EffectManager                           { get; set; }
        public CameraCaptureManager?                    CameraCaptureManager                    { get; set; }

        public static GraphicsLocator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GraphicsLocator() { Pointer= p0 };

            value.EffectManager                             = GetObject<EffectManager>(new IntPtr(p + 0x010), ReversePrism.DataModels.EffectManager.FromPointer); // 0x10 EffectManager               ( ModelClassType EffectManager EffectManager EffectManager Pointer )
            value.CameraCaptureManager                      = GetObject<CameraCaptureManager>(new IntPtr(p + 0x018), ReversePrism.DataModels.CameraCaptureManager.FromPointer); // 0x18 CameraCaptureManager        ( ModelClassType CameraCaptureManager CameraCaptureManager CameraCaptureManager Pointer )

            return value;
        }
    }
}
