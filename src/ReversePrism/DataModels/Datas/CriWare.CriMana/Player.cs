using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 InvalidPlayerId                          int IL2CPP_TYPE_I4
    // 000 updatingPlayer                           Player IL2CPP_TYPE_CLASS
    // 020 PlayerId                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 IsDisposed                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 InternalrequiredStatus                   000186579E10 ModelEnumType Status Status Status Int32
    // 02C NativeStatus                             000186579E10 ModelEnumType Status Status Status Int32
    // 030 lastNativeStatus                         Nullable`1<Status> IL2CPP_TYPE_GENERICINST
    // 038 lastPlayerStatus                         Nullable`1<Status> IL2CPP_TYPE_GENERICINST
    // 040 WasStopping                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 041 IsPreparingForRendering                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 042 IsNativeStartInvoked                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 043 IsNativeInitialized                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 048 RendererResource                         00018665FFB0 ModelClassType RendererResource RendererResource RendererResource Pointer
    // 050 MovieInfo                                000186657CE0 ModelClassType MovieInfo MovieInfo MovieInfo Pointer
    // 058 FrameInfo                                0001865BE380 ModelClassType FrameInfo FrameInfo FrameInfo Pointer
    // 060 IsMovieInfoAvailable                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 061 IsFrameInfoAvailable                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 068 ShaderDispatchCallback                   0001865798D0 ModelClassType ShaderDispatchCallback ShaderDispatchCallback ShaderDispatchCallback Pointer
    // 070 EnableSubtitle                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 074 SubtitleBufferSize                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 078 DroppedFrameCount                        000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 080 AtomExPlayer                             000186648E20 ModelClassType CriAtomExPlayer CriAtomExPlayer CriAtomExPlayer Pointer
    // 088 AtomEx3Dsource                           0001866445E0 ModelClassType CriAtomEx3dSource CriAtomEx3dSource CriAtomEx3dSource Pointer
    // 090 TimerType                                00018657AF80 ModelEnumType TimerType TimerType TimerType Int32
    // 094 IsStoppingForSeek                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 098 CuePointCallback                         0001865784F0 ModelClassType CuePointCallback CuePointCallback CuePointCallback Pointer
    // 0A0 StatusChangeCallback                     00018657A590 ModelClassType StatusChangeCallback StatusChangeCallback StatusChangeCallback Pointer
    // 0A8 OnSubtitleChanged                        00018657AAB0 ModelClassType SubtitleChangeCallback SubtitleChangeCallback SubtitleChangeCallback Pointer
    // 0B0 AdditiveMode                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0B4 MaxFrameDrop                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0B8 ApplyTargetAlpha                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0B9 UiRenderMode                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0C0 <subtitleBuffer>k__BackingField          <int> IL2CPP_TYPE_I
    // 0C8 SubtitleSize                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0D0 PlayerHolder                             00018665B620 ModelClassType CriManaMoviePlayerHolder CriManaMoviePlayerHolder CriManaMoviePlayerHolder Pointer
    public partial class Player
    {
        public int                                      PlayerId                                { get; set; }
        public bool                                     IsDisposed                              { get; set; }
        public Status                                   InternalrequiredStatus                  { get; set; }
        public Status                                   NativeStatus                            { get; set; }
        public bool                                     WasStopping                             { get; set; }
        public bool                                     IsPreparingForRendering                 { get; set; }
        public bool                                     IsNativeStartInvoked                    { get; set; }
        public bool                                     IsNativeInitialized                     { get; set; }
        public RendererResource?                        RendererResource                        { get; set; }
        public MovieInfo?                               MovieInfo                               { get; set; }
        public FrameInfo?                               FrameInfo                               { get; set; }
        public bool                                     IsMovieInfoAvailable                    { get; set; }
        public bool                                     IsFrameInfoAvailable                    { get; set; }
        public ShaderDispatchCallback?                  ShaderDispatchCallback                  { get; set; }
        public bool                                     EnableSubtitle                          { get; set; }
        public int                                      SubtitleBufferSize                      { get; set; }
        public uint                                     DroppedFrameCount                       { get; set; }
        public CriAtomExPlayer?                         AtomExPlayer                            { get; set; }
        public CriAtomEx3dSource?                       AtomEx3Dsource                          { get; set; }
        public TimerType                                TimerType                               { get; set; }
        public bool                                     IsStoppingForSeek                       { get; set; }
        public CuePointCallback?                        CuePointCallback                        { get; set; }
        public StatusChangeCallback?                    StatusChangeCallback                    { get; set; }
        public SubtitleChangeCallback?                  OnSubtitleChanged                       { get; set; }
        public bool                                     AdditiveMode                            { get; set; }
        public int                                      MaxFrameDrop                            { get; set; }
        public bool                                     ApplyTargetAlpha                        { get; set; }
        public bool                                     UiRenderMode                            { get; set; }
        public int                                      SubtitleSize                            { get; set; }
        public CriManaMoviePlayerHolder?                PlayerHolder                            { get; set; }

        public static Player? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Player();

            value.PlayerId                                  = GetInt32(new IntPtr(p + 0x020)); // 0270043EABA8 0x20 PlayerId                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsDisposed                                = GetBool(new IntPtr(p + 0x024)); // 0270043EABC8 0x24 IsDisposed                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.InternalrequiredStatus                    = (Status)GetInt32(new IntPtr(p + 0x028)); // 0270043EABE8 0x28 InternalrequiredStatus      ( 000186579E10 ModelEnumType Status Status Status Int32 )
            value.NativeStatus                              = (Status)GetInt32(new IntPtr(p + 0x02C)); // 0270043EAC08 0x2C NativeStatus                ( 000186579E10 ModelEnumType Status Status Status Int32 )
            value.WasStopping                               = GetBool(new IntPtr(p + 0x040)); // 0270043EAC68 0x40 WasStopping                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsPreparingForRendering                   = GetBool(new IntPtr(p + 0x041)); // 0270043EAC88 0x41 IsPreparingForRendering     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsNativeStartInvoked                      = GetBool(new IntPtr(p + 0x042)); // 0270043EACA8 0x42 IsNativeStartInvoked        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsNativeInitialized                       = GetBool(new IntPtr(p + 0x043)); // 0270043EACC8 0x43 IsNativeInitialized         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.RendererResource                          = GetObject<RendererResource>(new IntPtr(p + 0x048), ReversePrism.DataModels.RendererResource.FromPointer); // 0270043EACE8 0x48 RendererResource            ( 00018665FFB0 ModelClassType RendererResource RendererResource RendererResource Pointer )
            value.MovieInfo                                 = GetObject<MovieInfo>(new IntPtr(p + 0x050), ReversePrism.DataModels.MovieInfo.FromPointer); // 0270043EAD08 0x50 MovieInfo                   ( 000186657CE0 ModelClassType MovieInfo MovieInfo MovieInfo Pointer )
            value.FrameInfo                                 = GetObject<FrameInfo>(new IntPtr(p + 0x058), ReversePrism.DataModels.FrameInfo.FromPointer); // 0270043EAD28 0x58 FrameInfo                   ( 0001865BE380 ModelClassType FrameInfo FrameInfo FrameInfo Pointer )
            value.IsMovieInfoAvailable                      = GetBool(new IntPtr(p + 0x060)); // 0270043EAD48 0x60 IsMovieInfoAvailable        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsFrameInfoAvailable                      = GetBool(new IntPtr(p + 0x061)); // 0270043EAD68 0x61 IsFrameInfoAvailable        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ShaderDispatchCallback                    = GetObject<ShaderDispatchCallback>(new IntPtr(p + 0x068), ReversePrism.DataModels.ShaderDispatchCallback.FromPointer); // 0270043EAD88 0x68 ShaderDispatchCallback      ( 0001865798D0 ModelClassType ShaderDispatchCallback ShaderDispatchCallback ShaderDispatchCallback Pointer )
            value.EnableSubtitle                            = GetBool(new IntPtr(p + 0x070)); // 0270043EADA8 0x70 EnableSubtitle              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SubtitleBufferSize                        = GetInt32(new IntPtr(p + 0x074)); // 0270043EADC8 0x74 SubtitleBufferSize          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DroppedFrameCount                         = GetUInt32(new IntPtr(p + 0x078)); // 0270043EADE8 0x78 DroppedFrameCount           ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.AtomExPlayer                              = GetObject<CriAtomExPlayer>(new IntPtr(p + 0x080), ReversePrism.DataModels.CriAtomExPlayer.FromPointer); // 0270043EAE08 0x80 AtomExPlayer                ( 000186648E20 ModelClassType CriAtomExPlayer CriAtomExPlayer CriAtomExPlayer Pointer )
            value.AtomEx3Dsource                            = GetObject<CriAtomEx3dSource>(new IntPtr(p + 0x088), ReversePrism.DataModels.CriAtomEx3dSource.FromPointer); // 0270043EAE28 0x88 AtomEx3Dsource              ( 0001866445E0 ModelClassType CriAtomEx3dSource CriAtomEx3dSource CriAtomEx3dSource Pointer )
            value.TimerType                                 = (TimerType)GetInt32(new IntPtr(p + 0x090)); // 0270043EAE48 0x90 TimerType                   ( 00018657AF80 ModelEnumType TimerType TimerType TimerType Int32 )
            value.IsStoppingForSeek                         = GetBool(new IntPtr(p + 0x094)); // 0270043EAE68 0x94 IsStoppingForSeek           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CuePointCallback                          = GetObject<CuePointCallback>(new IntPtr(p + 0x098), ReversePrism.DataModels.CuePointCallback.FromPointer); // 0270043EAE88 0x98 CuePointCallback            ( 0001865784F0 ModelClassType CuePointCallback CuePointCallback CuePointCallback Pointer )
            value.StatusChangeCallback                      = GetObject<StatusChangeCallback>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.StatusChangeCallback.FromPointer); // 0270043EAEA8 0xA0 StatusChangeCallback        ( 00018657A590 ModelClassType StatusChangeCallback StatusChangeCallback StatusChangeCallback Pointer )
            value.OnSubtitleChanged                         = GetObject<SubtitleChangeCallback>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.SubtitleChangeCallback.FromPointer); // 0270043EAEC8 0xA8 OnSubtitleChanged           ( 00018657AAB0 ModelClassType SubtitleChangeCallback SubtitleChangeCallback SubtitleChangeCallback Pointer )
            value.AdditiveMode                              = GetBool(new IntPtr(p + 0x0B0)); // 0270043EAEE8 0xB0 AdditiveMode                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MaxFrameDrop                              = GetInt32(new IntPtr(p + 0x0B4)); // 0270043EAF08 0xB4 MaxFrameDrop                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ApplyTargetAlpha                          = GetBool(new IntPtr(p + 0x0B8)); // 0270043EAF28 0xB8 ApplyTargetAlpha            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UiRenderMode                              = GetBool(new IntPtr(p + 0x0B9)); // 0270043EAF48 0xB9 UiRenderMode                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SubtitleSize                              = GetInt32(new IntPtr(p + 0x0C8)); // 0270043EAF88 0xC8 SubtitleSize                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PlayerHolder                              = GetObject<CriManaMoviePlayerHolder>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.CriManaMoviePlayerHolder.FromPointer); // 0270043EAFA8 0xD0 PlayerHolder                ( 00018665B620 ModelClassType CriManaMoviePlayerHolder CriManaMoviePlayerHolder CriManaMoviePlayerHolder Pointer )

            return value;
        }
    }
}
