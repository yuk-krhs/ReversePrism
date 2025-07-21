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
    // 020 PlayerId                                 ModelPrimitiveType int int int Int32
    // 024 IsDisposed                               ModelPrimitiveType bool bool bool Bool
    // 028 InternalrequiredStatus                   ModelEnumType Status Status Status Int32
    // 02C NativeStatus                             ModelEnumType Status Status Status Int32
    // 030 lastNativeStatus                         Nullable`1<Status> IL2CPP_TYPE_GENERICINST
    // 038 lastPlayerStatus                         Nullable`1<Status> IL2CPP_TYPE_GENERICINST
    // 040 WasStopping                              ModelPrimitiveType bool bool bool Bool
    // 041 IsPreparingForRendering                  ModelPrimitiveType bool bool bool Bool
    // 042 IsNativeStartInvoked                     ModelPrimitiveType bool bool bool Bool
    // 043 IsNativeInitialized                      ModelPrimitiveType bool bool bool Bool
    // 048 RendererResource                         ModelClassType RendererResource RendererResource RendererResource Pointer
    // 050 MovieInfo                                ModelClassType MovieInfo MovieInfo MovieInfo Pointer
    // 058 FrameInfo                                ModelClassType FrameInfo FrameInfo FrameInfo Pointer
    // 060 IsMovieInfoAvailable                     ModelPrimitiveType bool bool bool Bool
    // 061 IsFrameInfoAvailable                     ModelPrimitiveType bool bool bool Bool
    // 068 ShaderDispatchCallback                   ModelClassType ShaderDispatchCallback ShaderDispatchCallback ShaderDispatchCallback Pointer
    // 070 EnableSubtitle                           ModelPrimitiveType bool bool bool Bool
    // 074 SubtitleBufferSize                       ModelPrimitiveType int int int Int32
    // 078 DroppedFrameCount                        ModelPrimitiveType uint uint uint UInt32
    // 080 AtomExPlayer                             ModelClassType CriAtomExPlayer CriAtomExPlayer CriAtomExPlayer Pointer
    // 088 AtomEx3Dsource                           ModelClassType CriAtomEx3dSource CriAtomEx3dSource CriAtomEx3dSource Pointer
    // 090 TimerType                                ModelEnumType TimerType TimerType TimerType Int32
    // 094 IsStoppingForSeek                        ModelPrimitiveType bool bool bool Bool
    // 098 CuePointCallback                         ModelClassType CuePointCallback CuePointCallback CuePointCallback Pointer
    // 0A0 StatusChangeCallback                     ModelClassType StatusChangeCallback StatusChangeCallback StatusChangeCallback Pointer
    // 0A8 OnSubtitleChanged                        ModelClassType SubtitleChangeCallback SubtitleChangeCallback SubtitleChangeCallback Pointer
    // 0B0 AdditiveMode                             ModelPrimitiveType bool bool bool Bool
    // 0B4 MaxFrameDrop                             ModelPrimitiveType int int int Int32
    // 0B8 ApplyTargetAlpha                         ModelPrimitiveType bool bool bool Bool
    // 0B9 UiRenderMode                             ModelPrimitiveType bool bool bool Bool
    // 0C0 <subtitleBuffer>k__BackingField          <int> IL2CPP_TYPE_I
    // 0C8 SubtitleSize                             ModelPrimitiveType int int int Int32
    // 0D0 PlayerHolder                             ModelClassType CriManaMoviePlayerHolder CriManaMoviePlayerHolder CriManaMoviePlayerHolder Pointer
    public partial class Player : DataModel
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
            var value   = new Player() { Pointer= p0 };

            value.PlayerId                                  = GetInt32(new IntPtr(p + 0x020)); // 0x20 PlayerId                    ( ModelPrimitiveType int int int Int32 )
            value.IsDisposed                                = GetBool(new IntPtr(p + 0x024)); // 0x24 IsDisposed                  ( ModelPrimitiveType bool bool bool Bool )
            value.InternalrequiredStatus                    = (Status)GetInt32(new IntPtr(p + 0x028)); // 0x28 InternalrequiredStatus      ( ModelEnumType Status Status Status Int32 )
            value.NativeStatus                              = (Status)GetInt32(new IntPtr(p + 0x02C)); // 0x2C NativeStatus                ( ModelEnumType Status Status Status Int32 )
            value.WasStopping                               = GetBool(new IntPtr(p + 0x040)); // 0x40 WasStopping                 ( ModelPrimitiveType bool bool bool Bool )
            value.IsPreparingForRendering                   = GetBool(new IntPtr(p + 0x041)); // 0x41 IsPreparingForRendering     ( ModelPrimitiveType bool bool bool Bool )
            value.IsNativeStartInvoked                      = GetBool(new IntPtr(p + 0x042)); // 0x42 IsNativeStartInvoked        ( ModelPrimitiveType bool bool bool Bool )
            value.IsNativeInitialized                       = GetBool(new IntPtr(p + 0x043)); // 0x43 IsNativeInitialized         ( ModelPrimitiveType bool bool bool Bool )
            value.RendererResource                          = GetObject<RendererResource>(new IntPtr(p + 0x048), ReversePrism.DataModels.RendererResource.FromPointer); // 0x48 RendererResource            ( ModelClassType RendererResource RendererResource RendererResource Pointer )
            value.MovieInfo                                 = GetObject<MovieInfo>(new IntPtr(p + 0x050), ReversePrism.DataModels.MovieInfo.FromPointer); // 0x50 MovieInfo                   ( ModelClassType MovieInfo MovieInfo MovieInfo Pointer )
            value.FrameInfo                                 = GetObject<FrameInfo>(new IntPtr(p + 0x058), ReversePrism.DataModels.FrameInfo.FromPointer); // 0x58 FrameInfo                   ( ModelClassType FrameInfo FrameInfo FrameInfo Pointer )
            value.IsMovieInfoAvailable                      = GetBool(new IntPtr(p + 0x060)); // 0x60 IsMovieInfoAvailable        ( ModelPrimitiveType bool bool bool Bool )
            value.IsFrameInfoAvailable                      = GetBool(new IntPtr(p + 0x061)); // 0x61 IsFrameInfoAvailable        ( ModelPrimitiveType bool bool bool Bool )
            value.ShaderDispatchCallback                    = GetObject<ShaderDispatchCallback>(new IntPtr(p + 0x068), ReversePrism.DataModels.ShaderDispatchCallback.FromPointer); // 0x68 ShaderDispatchCallback      ( ModelClassType ShaderDispatchCallback ShaderDispatchCallback ShaderDispatchCallback Pointer )
            value.EnableSubtitle                            = GetBool(new IntPtr(p + 0x070)); // 0x70 EnableSubtitle              ( ModelPrimitiveType bool bool bool Bool )
            value.SubtitleBufferSize                        = GetInt32(new IntPtr(p + 0x074)); // 0x74 SubtitleBufferSize          ( ModelPrimitiveType int int int Int32 )
            value.DroppedFrameCount                         = GetUInt32(new IntPtr(p + 0x078)); // 0x78 DroppedFrameCount           ( ModelPrimitiveType uint uint uint UInt32 )
            value.AtomExPlayer                              = GetObject<CriAtomExPlayer>(new IntPtr(p + 0x080), ReversePrism.DataModels.CriAtomExPlayer.FromPointer); // 0x80 AtomExPlayer                ( ModelClassType CriAtomExPlayer CriAtomExPlayer CriAtomExPlayer Pointer )
            value.AtomEx3Dsource                            = GetObject<CriAtomEx3dSource>(new IntPtr(p + 0x088), ReversePrism.DataModels.CriAtomEx3dSource.FromPointer); // 0x88 AtomEx3Dsource              ( ModelClassType CriAtomEx3dSource CriAtomEx3dSource CriAtomEx3dSource Pointer )
            value.TimerType                                 = (TimerType)GetInt32(new IntPtr(p + 0x090)); // 0x90 TimerType                   ( ModelEnumType TimerType TimerType TimerType Int32 )
            value.IsStoppingForSeek                         = GetBool(new IntPtr(p + 0x094)); // 0x94 IsStoppingForSeek           ( ModelPrimitiveType bool bool bool Bool )
            value.CuePointCallback                          = GetObject<CuePointCallback>(new IntPtr(p + 0x098), ReversePrism.DataModels.CuePointCallback.FromPointer); // 0x98 CuePointCallback            ( ModelClassType CuePointCallback CuePointCallback CuePointCallback Pointer )
            value.StatusChangeCallback                      = GetObject<StatusChangeCallback>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.StatusChangeCallback.FromPointer); // 0xA0 StatusChangeCallback        ( ModelClassType StatusChangeCallback StatusChangeCallback StatusChangeCallback Pointer )
            value.OnSubtitleChanged                         = GetObject<SubtitleChangeCallback>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.SubtitleChangeCallback.FromPointer); // 0xA8 OnSubtitleChanged           ( ModelClassType SubtitleChangeCallback SubtitleChangeCallback SubtitleChangeCallback Pointer )
            value.AdditiveMode                              = GetBool(new IntPtr(p + 0x0B0)); // 0xB0 AdditiveMode                ( ModelPrimitiveType bool bool bool Bool )
            value.MaxFrameDrop                              = GetInt32(new IntPtr(p + 0x0B4)); // 0xB4 MaxFrameDrop                ( ModelPrimitiveType int int int Int32 )
            value.ApplyTargetAlpha                          = GetBool(new IntPtr(p + 0x0B8)); // 0xB8 ApplyTargetAlpha            ( ModelPrimitiveType bool bool bool Bool )
            value.UiRenderMode                              = GetBool(new IntPtr(p + 0x0B9)); // 0xB9 UiRenderMode                ( ModelPrimitiveType bool bool bool Bool )
            value.SubtitleSize                              = GetInt32(new IntPtr(p + 0x0C8)); // 0xC8 SubtitleSize                ( ModelPrimitiveType int int int Int32 )
            value.PlayerHolder                              = GetObject<CriManaMoviePlayerHolder>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.CriManaMoviePlayerHolder.FromPointer); // 0xD0 PlayerHolder                ( ModelClassType CriManaMoviePlayerHolder CriManaMoviePlayerHolder CriManaMoviePlayerHolder Pointer )

            return value;
        }
    }
}
