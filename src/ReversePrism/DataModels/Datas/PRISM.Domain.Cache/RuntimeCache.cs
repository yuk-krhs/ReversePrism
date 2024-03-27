using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 User                                     00018674BFF0 ModelClassType UserCache UserCache UserCache Pointer
    // 018 Stamina                                  0001865639B0 ModelClassType StaminaCache StaminaCache StaminaCache Pointer
    // 020 Product                                  00018659EDC0 ModelClassType ProductCache ProductCache ProductCache Pointer
    // 028 Badge                                    000186735A00 ModelClassType BadgeCache BadgeCache BadgeCache Pointer
    // 030 GameVersion                              0001865EEC50 ModelClassType GameVersionCache GameVersionCache GameVersionCache Pointer
    // 038 GameSetting                              0001865EC930 ModelClassType GameSettingCache GameSettingCache GameSettingCache Pointer
    // 040 ProduceIdol                              000186547C30 ModelClassType ProduceIdolCache ProduceIdolCache ProduceIdolCache Pointer
    // 048 SupportCharacter                         0001865E9110 ModelClassType SupportCharacterCache SupportCharacterCache SupportCharacterCache Pointer
    // 050 FesIdol                                  000186561B80 ModelClassType FesIdolCache FesIdolCache FesIdolCache Pointer
    // 058 LiveUnit                                 000186588AC0 ModelClassType LiveUnitCache LiveUnitCache LiveUnitCache Pointer
    // 060 Mv                                       0001865C6F70 ModelClassType MVCache MVCache MVCache Pointer
    // 068 FesUnit                                  000186568010 ModelClassType FesUnitCache FesUnitCache FesUnitCache Pointer
    // 070 IdolBase                                 0001866A49C0 ModelClassType IdolBaseCache IdolBaseCache IdolBaseCache Pointer
    // 078 CostumeSet                               000186633690 ModelClassType CostumeSetCache CostumeSetCache CostumeSetCache Pointer
    // 080 Costume                                  000186628F10 ModelClassType CostumeCache CostumeCache CostumeCache Pointer
    // 088 Hairstyle                                0001866A5C70 ModelClassType HairstyleCache HairstyleCache HairstyleCache Pointer
    // 090 Accessory                                000186671E10 ModelClassType AccessoryCache AccessoryCache AccessoryCache Pointer
    // 098 Song                                     000186528430 ModelClassType SongCache SongCache SongCache Pointer
    // 0A0 Chain                                    0001865559D0 ModelClassType ChainCache ChainCache ChainCache Pointer
    // 0A8 Phone                                    000186739210 ModelClassType PhoneCache PhoneCache PhoneCache Pointer
    // 0B0 OurStream                                0001866F1E70 ModelClassType OurStreamCache OurStreamCache OurStreamCache Pointer
    // 0B8 Home                                     0001866BCDA0 ModelClassType HomeCashe HomeCashe HomeCashe Pointer
    // 0C0 ProduceLog                               00018655C8A0 ModelClassType ProduceLogCache ProduceLogCache ProduceLogCache Pointer
    // 0C8 Story                                    000186594AA0 ModelClassType StoryCache StoryCache StoryCache Pointer
    // 0D0 Introduction                             000186723AC0 ModelClassType IntroductionCache IntroductionCache IntroductionCache Pointer
    // 0D8 Gasha                                    0001865F3DA0 ModelClassType GashaCashe GashaCashe GashaCashe Pointer
    public partial class RuntimeCache
    {
        public UserCache?                               User                                    { get; set; }
        public StaminaCache?                            Stamina                                 { get; set; }
        public ProductCache?                            Product                                 { get; set; }
        public BadgeCache?                              Badge                                   { get; set; }
        public GameVersionCache?                        GameVersion                             { get; set; }
        public GameSettingCache?                        GameSetting                             { get; set; }
        public ProduceIdolCache?                        ProduceIdol                             { get; set; }
        public SupportCharacterCache?                   SupportCharacter                        { get; set; }
        public FesIdolCache?                            FesIdol                                 { get; set; }
        public LiveUnitCache?                           LiveUnit                                { get; set; }
        public MVCache?                                 Mv                                      { get; set; }
        public FesUnitCache?                            FesUnit                                 { get; set; }
        public IdolBaseCache?                           IdolBase                                { get; set; }
        public CostumeSetCache?                         CostumeSet                              { get; set; }
        public CostumeCache?                            Costume                                 { get; set; }
        public HairstyleCache?                          Hairstyle                               { get; set; }
        public AccessoryCache?                          Accessory                               { get; set; }
        public SongCache?                               Song                                    { get; set; }
        public ChainCache?                              Chain                                   { get; set; }
        public PhoneCache?                              Phone                                   { get; set; }
        public OurStreamCache?                          OurStream                               { get; set; }
        public HomeCashe?                               Home                                    { get; set; }
        public ProduceLogCache?                         ProduceLog                              { get; set; }
        public StoryCache?                              Story                                   { get; set; }
        public IntroductionCache?                       Introduction                            { get; set; }
        public GashaCashe?                              Gasha                                   { get; set; }

        public static RuntimeCache? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RuntimeCache();

            value.User                                      = GetObject<UserCache>(new IntPtr(p + 0x010), ReversePrism.DataModels.UserCache.FromPointer); // 027004A84BF0 0x10 User                        ( 00018674BFF0 ModelClassType UserCache UserCache UserCache Pointer )
            value.Stamina                                   = GetObject<StaminaCache>(new IntPtr(p + 0x018), ReversePrism.DataModels.StaminaCache.FromPointer); // 027004A84C10 0x18 Stamina                     ( 0001865639B0 ModelClassType StaminaCache StaminaCache StaminaCache Pointer )
            value.Product                                   = GetObject<ProductCache>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProductCache.FromPointer); // 027004A84C30 0x20 Product                     ( 00018659EDC0 ModelClassType ProductCache ProductCache ProductCache Pointer )
            value.Badge                                     = GetObject<BadgeCache>(new IntPtr(p + 0x028), ReversePrism.DataModels.BadgeCache.FromPointer); // 027004A84C50 0x28 Badge                       ( 000186735A00 ModelClassType BadgeCache BadgeCache BadgeCache Pointer )
            value.GameVersion                               = GetObject<GameVersionCache>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameVersionCache.FromPointer); // 027004A84C70 0x30 GameVersion                 ( 0001865EEC50 ModelClassType GameVersionCache GameVersionCache GameVersionCache Pointer )
            value.GameSetting                               = GetObject<GameSettingCache>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameSettingCache.FromPointer); // 027004A84C90 0x38 GameSetting                 ( 0001865EC930 ModelClassType GameSettingCache GameSettingCache GameSettingCache Pointer )
            value.ProduceIdol                               = GetObject<ProduceIdolCache>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProduceIdolCache.FromPointer); // 027004A84CB0 0x40 ProduceIdol                 ( 000186547C30 ModelClassType ProduceIdolCache ProduceIdolCache ProduceIdolCache Pointer )
            value.SupportCharacter                          = GetObject<SupportCharacterCache>(new IntPtr(p + 0x048), ReversePrism.DataModels.SupportCharacterCache.FromPointer); // 027004A84CD0 0x48 SupportCharacter            ( 0001865E9110 ModelClassType SupportCharacterCache SupportCharacterCache SupportCharacterCache Pointer )
            value.FesIdol                                   = GetObject<FesIdolCache>(new IntPtr(p + 0x050), ReversePrism.DataModels.FesIdolCache.FromPointer); // 027004A84CF0 0x50 FesIdol                     ( 000186561B80 ModelClassType FesIdolCache FesIdolCache FesIdolCache Pointer )
            value.LiveUnit                                  = GetObject<LiveUnitCache>(new IntPtr(p + 0x058), ReversePrism.DataModels.LiveUnitCache.FromPointer); // 027004A84D10 0x58 LiveUnit                    ( 000186588AC0 ModelClassType LiveUnitCache LiveUnitCache LiveUnitCache Pointer )
            value.Mv                                        = GetObject<MVCache>(new IntPtr(p + 0x060), ReversePrism.DataModels.MVCache.FromPointer); // 027004A84D30 0x60 Mv                          ( 0001865C6F70 ModelClassType MVCache MVCache MVCache Pointer )
            value.FesUnit                                   = GetObject<FesUnitCache>(new IntPtr(p + 0x068), ReversePrism.DataModels.FesUnitCache.FromPointer); // 027004A84D50 0x68 FesUnit                     ( 000186568010 ModelClassType FesUnitCache FesUnitCache FesUnitCache Pointer )
            value.IdolBase                                  = GetObject<IdolBaseCache>(new IntPtr(p + 0x070), ReversePrism.DataModels.IdolBaseCache.FromPointer); // 027004A84D70 0x70 IdolBase                    ( 0001866A49C0 ModelClassType IdolBaseCache IdolBaseCache IdolBaseCache Pointer )
            value.CostumeSet                                = GetObject<CostumeSetCache>(new IntPtr(p + 0x078), ReversePrism.DataModels.CostumeSetCache.FromPointer); // 027004A84D90 0x78 CostumeSet                  ( 000186633690 ModelClassType CostumeSetCache CostumeSetCache CostumeSetCache Pointer )
            value.Costume                                   = GetObject<CostumeCache>(new IntPtr(p + 0x080), ReversePrism.DataModels.CostumeCache.FromPointer); // 027004A84DB0 0x80 Costume                     ( 000186628F10 ModelClassType CostumeCache CostumeCache CostumeCache Pointer )
            value.Hairstyle                                 = GetObject<HairstyleCache>(new IntPtr(p + 0x088), ReversePrism.DataModels.HairstyleCache.FromPointer); // 027004A84DD0 0x88 Hairstyle                   ( 0001866A5C70 ModelClassType HairstyleCache HairstyleCache HairstyleCache Pointer )
            value.Accessory                                 = GetObject<AccessoryCache>(new IntPtr(p + 0x090), ReversePrism.DataModels.AccessoryCache.FromPointer); // 027004A84DF0 0x90 Accessory                   ( 000186671E10 ModelClassType AccessoryCache AccessoryCache AccessoryCache Pointer )
            value.Song                                      = GetObject<SongCache>(new IntPtr(p + 0x098), ReversePrism.DataModels.SongCache.FromPointer); // 027004A84E10 0x98 Song                        ( 000186528430 ModelClassType SongCache SongCache SongCache Pointer )
            value.Chain                                     = GetObject<ChainCache>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ChainCache.FromPointer); // 027004A84E30 0xA0 Chain                       ( 0001865559D0 ModelClassType ChainCache ChainCache ChainCache Pointer )
            value.Phone                                     = GetObject<PhoneCache>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.PhoneCache.FromPointer); // 027004A84E50 0xA8 Phone                       ( 000186739210 ModelClassType PhoneCache PhoneCache PhoneCache Pointer )
            value.OurStream                                 = GetObject<OurStreamCache>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.OurStreamCache.FromPointer); // 027004A84E70 0xB0 OurStream                   ( 0001866F1E70 ModelClassType OurStreamCache OurStreamCache OurStreamCache Pointer )
            value.Home                                      = GetObject<HomeCashe>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.HomeCashe.FromPointer); // 027004A84E90 0xB8 Home                        ( 0001866BCDA0 ModelClassType HomeCashe HomeCashe HomeCashe Pointer )
            value.ProduceLog                                = GetObject<ProduceLogCache>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.ProduceLogCache.FromPointer); // 027004A84EB0 0xC0 ProduceLog                  ( 00018655C8A0 ModelClassType ProduceLogCache ProduceLogCache ProduceLogCache Pointer )
            value.Story                                     = GetObject<StoryCache>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.StoryCache.FromPointer); // 027004A84ED0 0xC8 Story                       ( 000186594AA0 ModelClassType StoryCache StoryCache StoryCache Pointer )
            value.Introduction                              = GetObject<IntroductionCache>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.IntroductionCache.FromPointer); // 027004A84EF0 0xD0 Introduction                ( 000186723AC0 ModelClassType IntroductionCache IntroductionCache IntroductionCache Pointer )
            value.Gasha                                     = GetObject<GashaCashe>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.GashaCashe.FromPointer); // 027004A84F10 0xD8 Gasha                       ( 0001865F3DA0 ModelClassType GashaCashe GashaCashe GashaCashe Pointer )

            return value;
        }
    }
}
