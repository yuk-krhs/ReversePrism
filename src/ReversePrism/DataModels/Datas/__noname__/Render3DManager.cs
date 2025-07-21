using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DefaultAmbientColor                      Color IL2CPP_TYPE_VALUETYPE
    // 020 MainCamera                               ModelClassType CameraController CameraController CameraController Pointer
    // 028 DropShadow                               ModelClassType DropShadow DropShadow DropShadow Pointer
    // 030 FrameDebug                               ModelPrimitiveType bool bool bool Bool
    // 038 CurrentDrawCamera                        ModelClassType Camera Camera Camera Pointer
    // 010 UpdateAnimation                          ModelPrimitiveType bool bool bool Bool
    // 011 ForcedDraw                               ModelPrimitiveType bool bool bool Bool
    // 012 BlockUpdate                              ModelPrimitiveType bool bool bool Bool
    // 040 Sway                                     ModelClassType SwayBoneManager SwayBoneManager SwayBoneManager Pointer
    // 048 LastProcTime                             ModelPrimitiveType float float float Single
    // 04C Index                                    ModelPrimitiveType int int int Int32
    // 050 MainContext                              ModelClassType SynchronizationContext SynchronizationContext SynchronizationContext Pointer
    // 058 Frame                                    ModelPrimitiveType int int int Int32
    public partial class Render3DManager : DataModel
    {
        public CameraController?                        MainCamera                              { get; set; }
        public DropShadow?                              DropShadow                              { get; set; }
        public bool                                     FrameDebug                              { get; set; }
        public Camera?                                  CurrentDrawCamera                       { get; set; }
        public bool                                     UpdateAnimation                         { get; set; }
        public bool                                     ForcedDraw                              { get; set; }
        public bool                                     BlockUpdate                             { get; set; }
        public SwayBoneManager?                         Sway                                    { get; set; }
        public float                                    LastProcTime                            { get; set; }
        public int                                      Index                                   { get; set; }
        public SynchronizationContext?                  MainContext                             { get; set; }
        public int                                      Frame                                   { get; set; }

        public static Render3DManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Render3DManager() { Pointer= p0 };

            value.MainCamera                                = GetObject<CameraController>(new IntPtr(p + 0x020), ReversePrism.DataModels.CameraController.FromPointer); // 0x20 MainCamera                  ( ModelClassType CameraController CameraController CameraController Pointer )
            value.DropShadow                                = GetObject<DropShadow>(new IntPtr(p + 0x028), ReversePrism.DataModels.DropShadow.FromPointer); // 0x28 DropShadow                  ( ModelClassType DropShadow DropShadow DropShadow Pointer )
            value.FrameDebug                                = GetBool(new IntPtr(p + 0x030)); // 0x30 FrameDebug                  ( ModelPrimitiveType bool bool bool Bool )
            value.CurrentDrawCamera                         = GetObject<Camera>(new IntPtr(p + 0x038), ReversePrism.DataModels.Camera.FromPointer); // 0x38 CurrentDrawCamera           ( ModelClassType Camera Camera Camera Pointer )
            value.UpdateAnimation                           = GetBool(new IntPtr(p + 0x010)); // 0x10 UpdateAnimation             ( ModelPrimitiveType bool bool bool Bool )
            value.ForcedDraw                                = GetBool(new IntPtr(p + 0x011)); // 0x11 ForcedDraw                  ( ModelPrimitiveType bool bool bool Bool )
            value.BlockUpdate                               = GetBool(new IntPtr(p + 0x012)); // 0x12 BlockUpdate                 ( ModelPrimitiveType bool bool bool Bool )
            value.Sway                                      = GetObject<SwayBoneManager>(new IntPtr(p + 0x040), ReversePrism.DataModels.SwayBoneManager.FromPointer); // 0x40 Sway                        ( ModelClassType SwayBoneManager SwayBoneManager SwayBoneManager Pointer )
            value.LastProcTime                              = GetSingle(new IntPtr(p + 0x048)); // 0x48 LastProcTime                ( ModelPrimitiveType float float float Single )
            value.Index                                     = GetInt32(new IntPtr(p + 0x04C)); // 0x4C Index                       ( ModelPrimitiveType int int int Int32 )
            value.MainContext                               = GetObject<SynchronizationContext>(new IntPtr(p + 0x050), ReversePrism.DataModels.SynchronizationContext.FromPointer); // 0x50 MainContext                 ( ModelClassType SynchronizationContext SynchronizationContext SynchronizationContext Pointer )
            value.Frame                                     = GetInt32(new IntPtr(p + 0x058)); // 0x58 Frame                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
