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
    // 010 ResourceLoader                           00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 018 DebugLogViewer                           00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 020 SceneLoader                              00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 028 Asset                                    00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 030 Time                                     00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 038 AppTrackingTransparency                  00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 040 InputBlock                               00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 048 Gleipnir                                 00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 050 Limelight                                00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 058 Boot                                     00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 060 NetworkError                             00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 068 Title                                    00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 070 Tutorial                                 00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 078 Home                                     00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 080 Render3D                                 00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 088 Live                                     00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 090 Character                                00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 098 Gasha                                    00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 0A0 Shop                                     00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 0A8 Story                                    00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 0B0 Mobile                                   00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 0B8 Streaming                                00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 0C0 Mission                                  00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 0C8 Adjust                                   00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 0D0 Produce                                  00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 0D8 SoundManager                             00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 0E0 Networking                               00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 0E8 ADV                                      00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 0F0 Notification                             00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 0F8 Profile                                  00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 100 Loading                                  00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 108 PrivacyOption                            00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 110 AdaptivePerformance                      00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 118 Announce                                 00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 120 Analytics                                00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    // 128 Crachlytics                              00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
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

            value.ResourceLoader                            = GetObject<CategorizedLogger>(new IntPtr(p + 0x010), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0245A3CBAAA0 0x10 ResourceLoader              ( 00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.DebugLogViewer                            = GetObject<CategorizedLogger>(new IntPtr(p + 0x018), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0245A3CBAAC0 0x18 DebugLogViewer              ( 00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.SceneLoader                               = GetObject<CategorizedLogger>(new IntPtr(p + 0x020), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0245A3CBAAE0 0x20 SceneLoader                 ( 00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Asset                                     = GetObject<CategorizedLogger>(new IntPtr(p + 0x028), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0245A3CBAB00 0x28 Asset                       ( 00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Time                                      = GetObject<CategorizedLogger>(new IntPtr(p + 0x030), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0245A3CBAB20 0x30 Time                        ( 00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.AppTrackingTransparency                   = GetObject<CategorizedLogger>(new IntPtr(p + 0x038), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0245A3CBAB40 0x38 AppTrackingTransparency     ( 00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.InputBlock                                = GetObject<CategorizedLogger>(new IntPtr(p + 0x040), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0245A3CBAB60 0x40 InputBlock                  ( 00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Gleipnir                                  = GetObject<CategorizedLogger>(new IntPtr(p + 0x048), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0245A3CBAB80 0x48 Gleipnir                    ( 00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Limelight                                 = GetObject<CategorizedLogger>(new IntPtr(p + 0x050), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0245A3CBABA0 0x50 Limelight                   ( 00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Boot                                      = GetObject<CategorizedLogger>(new IntPtr(p + 0x058), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0245A3CBABC0 0x58 Boot                        ( 00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.NetworkError                              = GetObject<CategorizedLogger>(new IntPtr(p + 0x060), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0245A3CBABE0 0x60 NetworkError                ( 00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Title                                     = GetObject<CategorizedLogger>(new IntPtr(p + 0x068), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0245A3CBAC00 0x68 Title                       ( 00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Tutorial                                  = GetObject<CategorizedLogger>(new IntPtr(p + 0x070), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0245A3CBAC20 0x70 Tutorial                    ( 00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Home                                      = GetObject<CategorizedLogger>(new IntPtr(p + 0x078), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0245A3CBAC40 0x78 Home                        ( 00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Render3D                                  = GetObject<CategorizedLogger>(new IntPtr(p + 0x080), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0245A3CBAC60 0x80 Render3D                    ( 00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Live                                      = GetObject<CategorizedLogger>(new IntPtr(p + 0x088), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0245A3CBAC80 0x88 Live                        ( 00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Character                                 = GetObject<CategorizedLogger>(new IntPtr(p + 0x090), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0245A3CBACA0 0x90 Character                   ( 00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Gasha                                     = GetObject<CategorizedLogger>(new IntPtr(p + 0x098), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0245A3CBACC0 0x98 Gasha                       ( 00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Shop                                      = GetObject<CategorizedLogger>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0245A3CBACE0 0xA0 Shop                        ( 00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Story                                     = GetObject<CategorizedLogger>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0245A3CBAD00 0xA8 Story                       ( 00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Mobile                                    = GetObject<CategorizedLogger>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0245A3CBAD20 0xB0 Mobile                      ( 00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Streaming                                 = GetObject<CategorizedLogger>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0245A3CBAD40 0xB8 Streaming                   ( 00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Mission                                   = GetObject<CategorizedLogger>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0245A3CBAD60 0xC0 Mission                     ( 00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Adjust                                    = GetObject<CategorizedLogger>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0245A3CBAD80 0xC8 Adjust                      ( 00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Produce                                   = GetObject<CategorizedLogger>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0245A3CBADA0 0xD0 Produce                     ( 00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.SoundManager                              = GetObject<CategorizedLogger>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0245A3CBADC0 0xD8 SoundManager                ( 00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Networking                                = GetObject<CategorizedLogger>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0245A3CBADE0 0xE0 Networking                  ( 00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.ADV                                       = GetObject<CategorizedLogger>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0245A3CBAE00 0xE8 ADV                         ( 00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Notification                              = GetObject<CategorizedLogger>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0245A3CBAE20 0xF0 Notification                ( 00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Profile                                   = GetObject<CategorizedLogger>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0245A3CBAE40 0xF8 Profile                     ( 00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Loading                                   = GetObject<CategorizedLogger>(new IntPtr(p + 0x100), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0245A3CBAE60 0x100 Loading                     ( 00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.PrivacyOption                             = GetObject<CategorizedLogger>(new IntPtr(p + 0x108), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0245A3CBAE80 0x108 PrivacyOption               ( 00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.AdaptivePerformance                       = GetObject<CategorizedLogger>(new IntPtr(p + 0x110), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0245A3CBAEA0 0x110 AdaptivePerformance         ( 00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Announce                                  = GetObject<CategorizedLogger>(new IntPtr(p + 0x118), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0245A3CBAEC0 0x118 Announce                    ( 00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Analytics                                 = GetObject<CategorizedLogger>(new IntPtr(p + 0x120), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0245A3CBAEE0 0x120 Analytics                   ( 00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )
            value.Crachlytics                               = GetObject<CategorizedLogger>(new IntPtr(p + 0x128), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0245A3CBAF00 0x128 Crachlytics                 ( 00018654E8D0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )

            return value;
        }
    }
}
