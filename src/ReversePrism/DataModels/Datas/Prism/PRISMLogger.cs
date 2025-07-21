using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 UnityLog                                 CategorizedLogger IL2CPP_TYPE_CLASS
    // 008 SaveData                                 CategorizedLogger IL2CPP_TYPE_CLASS
    // 010 ResourceLoader                           ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 018 DebugLogViewer                           ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 020 SceneLoader                              ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 028 Asset                                    ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 030 Time                                     ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 038 AppTrackingTransparency                  ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 040 InputBlock                               ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 048 Gleipnir                                 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 050 Limelight                                ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 058 Boot                                     ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 060 NetworkError                             ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 068 Title                                    ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 070 Tutorial                                 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 078 Home                                     ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 080 Render3D                                 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 088 Live                                     ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 090 Character                                ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 098 Gasha                                    ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 0A0 Shop                                     ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 0A8 Story                                    ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 0B0 Mobile                                   ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 0B8 Streaming                                ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 0C0 Mission                                  ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 0C8 Adjust                                   ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 0D0 Produce                                  ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 0D8 SoundManager                             ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 0E0 Networking                               ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 0E8 ADV                                      ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 0F0 Notification                             ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 0F8 Profile                                  ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 100 Loading                                  ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 108 PrivacyOption                            ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 110 AdaptivePerformance                      ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 118 Announce                                 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 120 Analytics                                ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 128 Crachlytics                              ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    public partial class PRISMLogger : DataModel
    {
        public CategorizedLogger?                       ResourceLoader                          { get; set; }
        public CategorizedLogger?                       DebugLogViewer                          { get; set; }
        public CategorizedLogger?                       SceneLoader                             { get; set; }
        public CategorizedLogger?                       Asset                                   { get; set; }
        public CategorizedLogger?                       Time                                    { get; set; }
        public CategorizedLogger?                       AppTrackingTransparency                 { get; set; }
        public CategorizedLogger?                       InputBlock                              { get; set; }
        public CategorizedLogger?                       Gleipnir                                { get; set; }
        public CategorizedLogger?                       Limelight                               { get; set; }
        public CategorizedLogger?                       Boot                                    { get; set; }
        public CategorizedLogger?                       NetworkError                            { get; set; }
        public CategorizedLogger?                       Title                                   { get; set; }
        public CategorizedLogger?                       Tutorial                                { get; set; }
        public CategorizedLogger?                       Home                                    { get; set; }
        public CategorizedLogger?                       Render3D                                { get; set; }
        public CategorizedLogger?                       Live                                    { get; set; }
        public CategorizedLogger?                       Character                               { get; set; }
        public CategorizedLogger?                       Gasha                                   { get; set; }
        public CategorizedLogger?                       Shop                                    { get; set; }
        public CategorizedLogger?                       Story                                   { get; set; }
        public CategorizedLogger?                       Mobile                                  { get; set; }
        public CategorizedLogger?                       Streaming                               { get; set; }
        public CategorizedLogger?                       Mission                                 { get; set; }
        public CategorizedLogger?                       Adjust                                  { get; set; }
        public CategorizedLogger?                       Produce                                 { get; set; }
        public CategorizedLogger?                       SoundManager                            { get; set; }
        public CategorizedLogger?                       Networking                              { get; set; }
        public CategorizedLogger?                       ADV                                     { get; set; }
        public CategorizedLogger?                       Notification                            { get; set; }
        public CategorizedLogger?                       Profile                                 { get; set; }
        public CategorizedLogger?                       Loading                                 { get; set; }
        public CategorizedLogger?                       PrivacyOption                           { get; set; }
        public CategorizedLogger?                       AdaptivePerformance                     { get; set; }
        public CategorizedLogger?                       Announce                                { get; set; }
        public CategorizedLogger?                       Analytics                               { get; set; }
        public CategorizedLogger?                       Crachlytics                             { get; set; }

        public static PRISMLogger? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PRISMLogger() { Pointer= p0 };

            value.ResourceLoader                            = GetObject<CategorizedLogger>(new IntPtr(p + 0x010), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0x10 ResourceLoader              ( ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.DebugLogViewer                            = GetObject<CategorizedLogger>(new IntPtr(p + 0x018), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0x18 DebugLogViewer              ( ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.SceneLoader                               = GetObject<CategorizedLogger>(new IntPtr(p + 0x020), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0x20 SceneLoader                 ( ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Asset                                     = GetObject<CategorizedLogger>(new IntPtr(p + 0x028), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0x28 Asset                       ( ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Time                                      = GetObject<CategorizedLogger>(new IntPtr(p + 0x030), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0x30 Time                        ( ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.AppTrackingTransparency                   = GetObject<CategorizedLogger>(new IntPtr(p + 0x038), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0x38 AppTrackingTransparency     ( ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.InputBlock                                = GetObject<CategorizedLogger>(new IntPtr(p + 0x040), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0x40 InputBlock                  ( ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Gleipnir                                  = GetObject<CategorizedLogger>(new IntPtr(p + 0x048), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0x48 Gleipnir                    ( ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Limelight                                 = GetObject<CategorizedLogger>(new IntPtr(p + 0x050), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0x50 Limelight                   ( ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Boot                                      = GetObject<CategorizedLogger>(new IntPtr(p + 0x058), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0x58 Boot                        ( ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.NetworkError                              = GetObject<CategorizedLogger>(new IntPtr(p + 0x060), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0x60 NetworkError                ( ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Title                                     = GetObject<CategorizedLogger>(new IntPtr(p + 0x068), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0x68 Title                       ( ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Tutorial                                  = GetObject<CategorizedLogger>(new IntPtr(p + 0x070), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0x70 Tutorial                    ( ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Home                                      = GetObject<CategorizedLogger>(new IntPtr(p + 0x078), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0x78 Home                        ( ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Render3D                                  = GetObject<CategorizedLogger>(new IntPtr(p + 0x080), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0x80 Render3D                    ( ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Live                                      = GetObject<CategorizedLogger>(new IntPtr(p + 0x088), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0x88 Live                        ( ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Character                                 = GetObject<CategorizedLogger>(new IntPtr(p + 0x090), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0x90 Character                   ( ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Gasha                                     = GetObject<CategorizedLogger>(new IntPtr(p + 0x098), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0x98 Gasha                       ( ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Shop                                      = GetObject<CategorizedLogger>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0xA0 Shop                        ( ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Story                                     = GetObject<CategorizedLogger>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0xA8 Story                       ( ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Mobile                                    = GetObject<CategorizedLogger>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0xB0 Mobile                      ( ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Streaming                                 = GetObject<CategorizedLogger>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0xB8 Streaming                   ( ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Mission                                   = GetObject<CategorizedLogger>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0xC0 Mission                     ( ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Adjust                                    = GetObject<CategorizedLogger>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0xC8 Adjust                      ( ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Produce                                   = GetObject<CategorizedLogger>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0xD0 Produce                     ( ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.SoundManager                              = GetObject<CategorizedLogger>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0xD8 SoundManager                ( ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Networking                                = GetObject<CategorizedLogger>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0xE0 Networking                  ( ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.ADV                                       = GetObject<CategorizedLogger>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0xE8 ADV                         ( ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Notification                              = GetObject<CategorizedLogger>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0xF0 Notification                ( ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Profile                                   = GetObject<CategorizedLogger>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0xF8 Profile                     ( ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Loading                                   = GetObject<CategorizedLogger>(new IntPtr(p + 0x100), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0x100 Loading                     ( ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.PrivacyOption                             = GetObject<CategorizedLogger>(new IntPtr(p + 0x108), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0x108 PrivacyOption               ( ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.AdaptivePerformance                       = GetObject<CategorizedLogger>(new IntPtr(p + 0x110), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0x110 AdaptivePerformance         ( ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Announce                                  = GetObject<CategorizedLogger>(new IntPtr(p + 0x118), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0x118 Announce                    ( ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Analytics                                 = GetObject<CategorizedLogger>(new IntPtr(p + 0x120), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0x120 Analytics                   ( ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Crachlytics                               = GetObject<CategorizedLogger>(new IntPtr(p + 0x128), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0x128 Crachlytics                 ( ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )

            return value;
        }
    }
}
