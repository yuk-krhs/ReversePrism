using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<TmpGetHomeReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 BackgroundFieldNumber                    int IL2CPP_TYPE_I4
    // 018 Background                               00018667EA00 ModelClassType TmpBackgroundStatus TmpBackgroundStatus TmpBackgroundStatus Pointer
    // 000 HomeUnitFieldNumber                      int IL2CPP_TYPE_I4
    // 020 HomeUnit                                 00018667FF90 ModelClassType TmpHomeUnitStatus TmpHomeUnitStatus TmpHomeUnitStatus Pointer
    // 000 WeatherFieldNumber                       int IL2CPP_TYPE_I4
    // 028 Weather                                  000186546CB0 ModelEnumType Weather Weather Weather Int32
    // 000 TimeOfDayFieldNumber                     int IL2CPP_TYPE_I4
    // 02C TimeOfDay                                000186667A00 ModelEnumType TimeOfDay TimeOfDay TimeOfDay Int32
    // 000 SeasonFieldNumber                        int IL2CPP_TYPE_I4
    // 030 Season                                   0001866FFA20 ModelEnumType Season Season Season Int32
    // 000 FavoriteIdolSettingFieldNumber           int IL2CPP_TYPE_I4
    // 038 FavoriteIdolSetting                      0001866CC290 ModelClassType HomeSettingFavoriteIdolStatus HomeSettingFavoriteIdolStatus HomeSettingFavoriteIdolStatus Pointer
    // 000 SeasonalEventFieldNumber                 int IL2CPP_TYPE_I4
    // 040 SeasonalEvent                            00018670F0D0 ModelEnumType SeasonalEvent SeasonalEvent SeasonalEvent Int32
    // 000 CutSceneFieldNumber                      int IL2CPP_TYPE_I4
    // 048 CutScene                                 0001866BEEF0 ModelClassType HomeCutSceneStatus HomeCutSceneStatus HomeCutSceneStatus Pointer
    public partial class TmpGetHomeReply
    {
        public TmpBackgroundStatus?                     Background                              { get; set; }
        public TmpHomeUnitStatus?                       HomeUnit                                { get; set; }
        public Weather                                  Weather                                 { get; set; }
        public TimeOfDay                                TimeOfDay                               { get; set; }
        public Season                                   Season                                  { get; set; }
        public HomeSettingFavoriteIdolStatus?           FavoriteIdolSetting                     { get; set; }
        public SeasonalEvent                            SeasonalEvent                           { get; set; }
        public HomeCutSceneStatus?                      CutScene                                { get; set; }

        public static TmpGetHomeReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TmpGetHomeReply();

            value.Background                                = GetObject<TmpBackgroundStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.TmpBackgroundStatus.FromPointer); // 0270D205C300 0x18 Background                  ( 00018667EA00 ModelClassType TmpBackgroundStatus TmpBackgroundStatus TmpBackgroundStatus Pointer )
            value.HomeUnit                                  = GetObject<TmpHomeUnitStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.TmpHomeUnitStatus.FromPointer); // 0270D205C340 0x20 HomeUnit                    ( 00018667FF90 ModelClassType TmpHomeUnitStatus TmpHomeUnitStatus TmpHomeUnitStatus Pointer )
            value.Weather                                   = (Weather)GetInt32(new IntPtr(p + 0x028)); // 0270D205C380 0x28 Weather                     ( 000186546CB0 ModelEnumType Weather Weather Weather Int32 )
            value.TimeOfDay                                 = (TimeOfDay)GetInt32(new IntPtr(p + 0x02C)); // 0270D205C3C0 0x2C TimeOfDay                   ( 000186667A00 ModelEnumType TimeOfDay TimeOfDay TimeOfDay Int32 )
            value.Season                                    = (Season)GetInt32(new IntPtr(p + 0x030)); // 0270D205C400 0x30 Season                      ( 0001866FFA20 ModelEnumType Season Season Season Int32 )
            value.FavoriteIdolSetting                       = GetObject<HomeSettingFavoriteIdolStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.HomeSettingFavoriteIdolStatus.FromPointer); // 0270D205C440 0x38 FavoriteIdolSetting         ( 0001866CC290 ModelClassType HomeSettingFavoriteIdolStatus HomeSettingFavoriteIdolStatus HomeSettingFavoriteIdolStatus Pointer )
            value.SeasonalEvent                             = (SeasonalEvent)GetInt32(new IntPtr(p + 0x040)); // 0270D205C480 0x40 SeasonalEvent               ( 00018670F0D0 ModelEnumType SeasonalEvent SeasonalEvent SeasonalEvent Int32 )
            value.CutScene                                  = GetObject<HomeCutSceneStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.HomeCutSceneStatus.FromPointer); // 0270D205C4C0 0x48 CutScene                    ( 0001866BEEF0 ModelClassType HomeCutSceneStatus HomeCutSceneStatus HomeCutSceneStatus Pointer )

            return value;
        }
    }
}
