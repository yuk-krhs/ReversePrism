using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 PlayOnStart                              ModelPrimitiveType bool bool bool Bool
    // 031 RestartOnEnable                          ModelPrimitiveType bool bool bool Bool
    // 032 IsMaterialAvailable                      ModelPrimitiveType bool bool bool Bool
    // 038 Player                                   ModelClassType Player Player Player Pointer
    // 040 RenderMode                               ModelEnumType RenderMode RenderMode RenderMode Int32
    // 048 OnApplicationPauseCallback               ModelClassType OnApplicationPauseCallback OnApplicationPauseCallback OnApplicationPauseCallback Pointer
    // 050 TimerType                                ModelEnumType TimerType TimerType TimerType Int32
    // 058 Material                                 ModelClassType Material Material Material Pointer
    // 060 MaxFrameDrop                             ModelEnumType MaxFrameDrop MaxFrameDrop MaxFrameDrop Int32
    // 064 MaterialOwn                              ModelPrimitiveType bool bool bool Bool
    // 065 IsMonoBehaviourStartCalled               ModelPrimitiveType bool bool bool Bool
    // 066 WasDisabled                              ModelPrimitiveType bool bool bool Bool
    // 067 WasPausedOnDisable                       ModelPrimitiveType bool bool bool Bool
    // 068 PreviousOnApplicationPauseStatus         ModelPrimitiveType bool bool bool Bool
    // 070 FrameEnd                                 ModelClassType WaitForEndOfFrame WaitForEndOfFrame WaitForEndOfFrame Pointer
    // 078 UnpauseOnApplicationUnpause              ModelPrimitiveType bool bool bool Bool
    // 079 HaveRendererOwner                        ModelPrimitiveType bool bool bool Bool
    // 080 PlayerHolder                             ModelClassType CriManaMoviePlayerHolder CriManaMoviePlayerHolder CriManaMoviePlayerHolder Pointer
    public partial class CriManaMovieMaterialBase : DataModel
    {
        public bool                                     PlayOnStart                             { get; set; }
        public bool                                     RestartOnEnable                         { get; set; }
        public bool                                     IsMaterialAvailable                     { get; set; }
        public Player?                                  Player                                  { get; set; }
        public RenderMode                               RenderMode                              { get; set; }
        public OnApplicationPauseCallback?              OnApplicationPauseCallback              { get; set; }
        public TimerType                                TimerType                               { get; set; }
        public Material?                                Material                                { get; set; }
        public MaxFrameDrop                             MaxFrameDrop                            { get; set; }
        public bool                                     MaterialOwn                             { get; set; }
        public bool                                     IsMonoBehaviourStartCalled              { get; set; }
        public bool                                     WasDisabled                             { get; set; }
        public bool                                     WasPausedOnDisable                      { get; set; }
        public bool                                     PreviousOnApplicationPauseStatus        { get; set; }
        public WaitForEndOfFrame?                       FrameEnd                                { get; set; }
        public bool                                     UnpauseOnApplicationUnpause             { get; set; }
        public bool                                     HaveRendererOwner                       { get; set; }
        public CriManaMoviePlayerHolder?                PlayerHolder                            { get; set; }

        public static CriManaMovieMaterialBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriManaMovieMaterialBase() { Pointer= p0 };

            value.PlayOnStart                               = GetBool(new IntPtr(p + 0x030)); // 0x30 PlayOnStart                 ( ModelPrimitiveType bool bool bool Bool )
            value.RestartOnEnable                           = GetBool(new IntPtr(p + 0x031)); // 0x31 RestartOnEnable             ( ModelPrimitiveType bool bool bool Bool )
            value.IsMaterialAvailable                       = GetBool(new IntPtr(p + 0x032)); // 0x32 IsMaterialAvailable         ( ModelPrimitiveType bool bool bool Bool )
            value.Player                                    = GetObject<Player>(new IntPtr(p + 0x038), ReversePrism.DataModels.Player.FromPointer); // 0x38 Player                      ( ModelClassType Player Player Player Pointer )
            value.RenderMode                                = (RenderMode)GetInt32(new IntPtr(p + 0x040)); // 0x40 RenderMode                  ( ModelEnumType RenderMode RenderMode RenderMode Int32 )
            value.OnApplicationPauseCallback                = GetObject<OnApplicationPauseCallback>(new IntPtr(p + 0x048), ReversePrism.DataModels.OnApplicationPauseCallback.FromPointer); // 0x48 OnApplicationPauseCallback  ( ModelClassType OnApplicationPauseCallback OnApplicationPauseCallback OnApplicationPauseCallback Pointer )
            value.TimerType                                 = (TimerType)GetInt32(new IntPtr(p + 0x050)); // 0x50 TimerType                   ( ModelEnumType TimerType TimerType TimerType Int32 )
            value.Material                                  = GetObject<Material>(new IntPtr(p + 0x058), ReversePrism.DataModels.Material.FromPointer); // 0x58 Material                    ( ModelClassType Material Material Material Pointer )
            value.MaxFrameDrop                              = (MaxFrameDrop)GetInt32(new IntPtr(p + 0x060)); // 0x60 MaxFrameDrop                ( ModelEnumType MaxFrameDrop MaxFrameDrop MaxFrameDrop Int32 )
            value.MaterialOwn                               = GetBool(new IntPtr(p + 0x064)); // 0x64 MaterialOwn                 ( ModelPrimitiveType bool bool bool Bool )
            value.IsMonoBehaviourStartCalled                = GetBool(new IntPtr(p + 0x065)); // 0x65 IsMonoBehaviourStartCalled  ( ModelPrimitiveType bool bool bool Bool )
            value.WasDisabled                               = GetBool(new IntPtr(p + 0x066)); // 0x66 WasDisabled                 ( ModelPrimitiveType bool bool bool Bool )
            value.WasPausedOnDisable                        = GetBool(new IntPtr(p + 0x067)); // 0x67 WasPausedOnDisable          ( ModelPrimitiveType bool bool bool Bool )
            value.PreviousOnApplicationPauseStatus          = GetBool(new IntPtr(p + 0x068)); // 0x68 PreviousOnApplicationPauseStatus ( ModelPrimitiveType bool bool bool Bool )
            value.FrameEnd                                  = GetObject<WaitForEndOfFrame>(new IntPtr(p + 0x070), ReversePrism.DataModels.WaitForEndOfFrame.FromPointer); // 0x70 FrameEnd                    ( ModelClassType WaitForEndOfFrame WaitForEndOfFrame WaitForEndOfFrame Pointer )
            value.UnpauseOnApplicationUnpause               = GetBool(new IntPtr(p + 0x078)); // 0x78 UnpauseOnApplicationUnpause ( ModelPrimitiveType bool bool bool Bool )
            value.HaveRendererOwner                         = GetBool(new IntPtr(p + 0x079)); // 0x79 HaveRendererOwner           ( ModelPrimitiveType bool bool bool Bool )
            value.PlayerHolder                              = GetObject<CriManaMoviePlayerHolder>(new IntPtr(p + 0x080), ReversePrism.DataModels.CriManaMoviePlayerHolder.FromPointer); // 0x80 PlayerHolder                ( ModelClassType CriManaMoviePlayerHolder CriManaMoviePlayerHolder CriManaMoviePlayerHolder Pointer )

            return value;
        }
    }
}
