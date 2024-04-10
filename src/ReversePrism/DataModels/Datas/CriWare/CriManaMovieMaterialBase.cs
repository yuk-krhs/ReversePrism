using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 PlayOnStart                              000186595960 ModelPrimitiveType bool bool bool Bool
    // 031 RestartOnEnable                          000186595960 ModelPrimitiveType bool bool bool Bool
    // 032 IsMaterialAvailable                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 Player                                   00018674F770 ModelClassType Player Player Player Pointer
    // 040 RenderMode                               000186565060 ModelEnumType RenderMode RenderMode RenderMode Int32
    // 048 OnApplicationPauseCallback               000186564B20 ModelClassType OnApplicationPauseCallback OnApplicationPauseCallback OnApplicationPauseCallback Pointer
    // 050 TimerType                                00018657AF80 ModelEnumType TimerType TimerType TimerType Int32
    // 058 Material                                 00018660BDD0 ModelClassType Material Material Material Pointer
    // 060 MaxFrameDrop                             0001865643E0 ModelEnumType MaxFrameDrop MaxFrameDrop MaxFrameDrop Int32
    // 064 MaterialOwn                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 065 IsMonoBehaviourStartCalled               000186595480 ModelPrimitiveType bool bool bool Bool
    // 066 WasDisabled                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 067 WasPausedOnDisable                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 068 PreviousOnApplicationPauseStatus         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 070 FrameEnd                                 000186541180 ModelClassType WaitForEndOfFrame WaitForEndOfFrame WaitForEndOfFrame Pointer
    // 078 UnpauseOnApplicationUnpause              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 079 HaveRendererOwner                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 080 PlayerHolder                             00018665B620 ModelClassType CriManaMoviePlayerHolder CriManaMoviePlayerHolder CriManaMoviePlayerHolder Pointer
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

            value.PlayOnStart                               = GetBool(new IntPtr(p + 0x030)); // 0245A43FBEF8 0x30 PlayOnStart                 ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.RestartOnEnable                           = GetBool(new IntPtr(p + 0x031)); // 0245A43FBF18 0x31 RestartOnEnable             ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IsMaterialAvailable                       = GetBool(new IntPtr(p + 0x032)); // 0245A43FBF38 0x32 IsMaterialAvailable         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Player                                    = GetObject<Player>(new IntPtr(p + 0x038), ReversePrism.DataModels.Player.FromPointer); // 0245A43FBF58 0x38 Player                      ( 00018674F770 ModelClassType Player Player Player Pointer )
            value.RenderMode                                = (RenderMode)GetInt32(new IntPtr(p + 0x040)); // 0245A43FBF78 0x40 RenderMode                  ( 000186565060 ModelEnumType RenderMode RenderMode RenderMode Int32 )
            value.OnApplicationPauseCallback                = GetObject<OnApplicationPauseCallback>(new IntPtr(p + 0x048), ReversePrism.DataModels.OnApplicationPauseCallback.FromPointer); // 0245A43FBF98 0x48 OnApplicationPauseCallback  ( 000186564B20 ModelClassType OnApplicationPauseCallback OnApplicationPauseCallback OnApplicationPauseCallback Pointer )
            value.TimerType                                 = (TimerType)GetInt32(new IntPtr(p + 0x050)); // 0245A43FBFB8 0x50 TimerType                   ( 00018657AF80 ModelEnumType TimerType TimerType TimerType Int32 )
            value.Material                                  = GetObject<Material>(new IntPtr(p + 0x058), ReversePrism.DataModels.Material.FromPointer); // 0245A43FBFD8 0x58 Material                    ( 00018660BDD0 ModelClassType Material Material Material Pointer )
            value.MaxFrameDrop                              = (MaxFrameDrop)GetInt32(new IntPtr(p + 0x060)); // 0245A43FBFF8 0x60 MaxFrameDrop                ( 0001865643E0 ModelEnumType MaxFrameDrop MaxFrameDrop MaxFrameDrop Int32 )
            value.MaterialOwn                               = GetBool(new IntPtr(p + 0x064)); // 0245A43FC018 0x64 MaterialOwn                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsMonoBehaviourStartCalled                = GetBool(new IntPtr(p + 0x065)); // 0245A43FC038 0x65 IsMonoBehaviourStartCalled  ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.WasDisabled                               = GetBool(new IntPtr(p + 0x066)); // 0245A43FC058 0x66 WasDisabled                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.WasPausedOnDisable                        = GetBool(new IntPtr(p + 0x067)); // 0245A43FC078 0x67 WasPausedOnDisable          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PreviousOnApplicationPauseStatus          = GetBool(new IntPtr(p + 0x068)); // 0245A43FC098 0x68 PreviousOnApplicationPauseStatus ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.FrameEnd                                  = GetObject<WaitForEndOfFrame>(new IntPtr(p + 0x070), ReversePrism.DataModels.WaitForEndOfFrame.FromPointer); // 0245A43FC0B8 0x70 FrameEnd                    ( 000186541180 ModelClassType WaitForEndOfFrame WaitForEndOfFrame WaitForEndOfFrame Pointer )
            value.UnpauseOnApplicationUnpause               = GetBool(new IntPtr(p + 0x078)); // 0245A43FC0D8 0x78 UnpauseOnApplicationUnpause ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.HaveRendererOwner                         = GetBool(new IntPtr(p + 0x079)); // 0245A43FC0F8 0x79 HaveRendererOwner           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PlayerHolder                              = GetObject<CriManaMoviePlayerHolder>(new IntPtr(p + 0x080), ReversePrism.DataModels.CriManaMoviePlayerHolder.FromPointer); // 0245A43FC118 0x80 PlayerHolder                ( 00018665B620 ModelClassType CriManaMoviePlayerHolder CriManaMoviePlayerHolder CriManaMoviePlayerHolder Pointer )

            return value;
        }
    }
}
