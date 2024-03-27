using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DefaultAmbientColor                      Color IL2CPP_TYPE_VALUETYPE
    // 020 MainCamera                               000186536460 ModelClassType CameraController CameraController CameraController Pointer
    // 028 DropShadow                               000186706850 ModelClassType DropShadow DropShadow DropShadow Pointer
    // 030 FrameDebug                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 CurrentDrawCamera                        0001865A1C90 ModelClassType Camera Camera Camera Pointer
    // 010 UpdateAnimation                          000186595C30 ModelPrimitiveType bool bool bool Bool
    // 011 ForcedDraw                               000186596380 ModelPrimitiveType bool bool bool Bool
    // 012 BlockUpdate                              000186596380 ModelPrimitiveType bool bool bool Bool
    // 040 Sway                                     0001865FA8D0 ModelClassType SwayBoneManager SwayBoneManager SwayBoneManager Pointer
    // 048 LastProcTime                             0001866656B0 ModelPrimitiveType float float float Single
    // 050 DeltaTimes                               000185B80D30 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 058 Index                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 060 MainContext                              000186601DB0 ModelClassType SynchronizationContext SynchronizationContext SynchronizationContext Pointer
    // 068 IsRender                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 06C Frame                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class Render3DManager
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
        public List<float>?                             DeltaTimes                              { get; set; }
        public int                                      Index                                   { get; set; }
        public SynchronizationContext?                  MainContext                             { get; set; }
        public bool                                     IsRender                                { get; set; }
        public int                                      Frame                                   { get; set; }

        public static Render3DManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Render3DManager();

            value.MainCamera                                = GetObject<CameraController>(new IntPtr(p + 0x020), ReversePrism.DataModels.CameraController.FromPointer); // 0270D3307C00 0x20 MainCamera                  ( 000186536460 ModelClassType CameraController CameraController CameraController Pointer )
            value.DropShadow                                = GetObject<DropShadow>(new IntPtr(p + 0x028), ReversePrism.DataModels.DropShadow.FromPointer); // 0270D3307C20 0x28 DropShadow                  ( 000186706850 ModelClassType DropShadow DropShadow DropShadow Pointer )
            value.FrameDebug                                = GetBool(new IntPtr(p + 0x030)); // 0270D3307C40 0x30 FrameDebug                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CurrentDrawCamera                         = GetObject<Camera>(new IntPtr(p + 0x038), ReversePrism.DataModels.Camera.FromPointer); // 0270D3307C60 0x38 CurrentDrawCamera           ( 0001865A1C90 ModelClassType Camera Camera Camera Pointer )
            value.UpdateAnimation                           = GetBool(new IntPtr(p + 0x010)); // 0270D3307C80 0x10 UpdateAnimation             ( 000186595C30 ModelPrimitiveType bool bool bool Bool )
            value.ForcedDraw                                = GetBool(new IntPtr(p + 0x011)); // 0270D3307CA0 0x11 ForcedDraw                  ( 000186596380 ModelPrimitiveType bool bool bool Bool )
            value.BlockUpdate                               = GetBool(new IntPtr(p + 0x012)); // 0270D3307CC0 0x12 BlockUpdate                 ( 000186596380 ModelPrimitiveType bool bool bool Bool )
            value.Sway                                      = GetObject<SwayBoneManager>(new IntPtr(p + 0x040), ReversePrism.DataModels.SwayBoneManager.FromPointer); // 0270D3307CE0 0x40 Sway                        ( 0001865FA8D0 ModelClassType SwayBoneManager SwayBoneManager SwayBoneManager Pointer )
            value.LastProcTime                              = GetSingle(new IntPtr(p + 0x048)); // 0270D3307D00 0x48 LastProcTime                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.DeltaTimes                                = GetSingleList(new IntPtr(p + 0x050)); // 0270D3307D20 0x50 DeltaTimes                  ( 000185B80D30 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x058)); // 0270D3307D40 0x58 Index                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MainContext                               = GetObject<SynchronizationContext>(new IntPtr(p + 0x060), ReversePrism.DataModels.SynchronizationContext.FromPointer); // 0270D3307D60 0x60 MainContext                 ( 000186601DB0 ModelClassType SynchronizationContext SynchronizationContext SynchronizationContext Pointer )
            value.IsRender                                  = GetBool(new IntPtr(p + 0x068)); // 0270D3307D80 0x68 IsRender                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Frame                                     = GetInt32(new IntPtr(p + 0x06C)); // 0270D3307DA0 0x6C Frame                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
