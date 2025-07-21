using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 User                                     ModelClassType UserCache UserCache UserCache Pointer
    // 018 Stamina                                  ModelClassType StaminaCache StaminaCache StaminaCache Pointer
    // 020 Product                                  ModelClassType ProductCache ProductCache ProductCache Pointer
    // 028 Badge                                    ModelClassType BadgeCache BadgeCache BadgeCache Pointer
    // 030 GameVersion                              ModelClassType GameVersionCache GameVersionCache GameVersionCache Pointer
    // 038 GameSetting                              ModelClassType GameSettingCache GameSettingCache GameSettingCache Pointer
    // 040 ProduceIdol                              ModelClassType ProduceIdolCache ProduceIdolCache ProduceIdolCache Pointer
    // 048 SupportCharacter                         ModelClassType SupportCharacterCache SupportCharacterCache SupportCharacterCache Pointer
    // 050 FesIdol                                  ModelClassType FesIdolCache FesIdolCache FesIdolCache Pointer
    // 058 LiveUnit                                 ModelClassType LiveUnitCache LiveUnitCache LiveUnitCache Pointer
    // 060 Mv                                       ModelClassType MVCache MVCache MVCache Pointer
    // 068 FesUnit                                  ModelClassType FesUnitCache FesUnitCache FesUnitCache Pointer
    // 070 IdolBase                                 ModelClassType IdolBaseCache IdolBaseCache IdolBaseCache Pointer
    // 078 CostumeSet                               ModelClassType CostumeSetCache CostumeSetCache CostumeSetCache Pointer
    // 080 Costume                                  ModelClassType CostumeCache CostumeCache CostumeCache Pointer
    // 088 Hairstyle                                ModelClassType HairstyleCache HairstyleCache HairstyleCache Pointer
    // 090 Accessory                                ModelClassType AccessoryCache AccessoryCache AccessoryCache Pointer
    // 098 Song                                     ModelClassType SongCache SongCache SongCache Pointer
    // 0A0 Chain                                    ModelClassType ChainCache ChainCache ChainCache Pointer
    // 0A8 Phone                                    ModelClassType PhoneCache PhoneCache PhoneCache Pointer
    // 0B0 OurStream                                ModelClassType OurStreamCache OurStreamCache OurStreamCache Pointer
    // 0B8 Home                                     ModelClassType HomeCashe HomeCashe HomeCashe Pointer
    // 0C0 ProduceLog                               ModelClassType ProduceLogCache ProduceLogCache ProduceLogCache Pointer
    // 0C8 Story                                    ModelClassType StoryCache StoryCache StoryCache Pointer
    // 0D0 Introduction                             ModelClassType IntroductionCache IntroductionCache IntroductionCache Pointer
    // 0D8 Gasha                                    ModelClassType GashaCashe GashaCashe GashaCashe Pointer
    public partial class RuntimeCache : DataModel
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
            var value   = new RuntimeCache() { Pointer= p0 };

            value.User                                      = GetObject<UserCache>(new IntPtr(p + 0x010), ReversePrism.DataModels.UserCache.FromPointer); // 0x10 User                        ( ModelClassType UserCache UserCache UserCache Pointer )
            value.Stamina                                   = GetObject<StaminaCache>(new IntPtr(p + 0x018), ReversePrism.DataModels.StaminaCache.FromPointer); // 0x18 Stamina                     ( ModelClassType StaminaCache StaminaCache StaminaCache Pointer )
            value.Product                                   = GetObject<ProductCache>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProductCache.FromPointer); // 0x20 Product                     ( ModelClassType ProductCache ProductCache ProductCache Pointer )
            value.Badge                                     = GetObject<BadgeCache>(new IntPtr(p + 0x028), ReversePrism.DataModels.BadgeCache.FromPointer); // 0x28 Badge                       ( ModelClassType BadgeCache BadgeCache BadgeCache Pointer )
            value.GameVersion                               = GetObject<GameVersionCache>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameVersionCache.FromPointer); // 0x30 GameVersion                 ( ModelClassType GameVersionCache GameVersionCache GameVersionCache Pointer )
            value.GameSetting                               = GetObject<GameSettingCache>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameSettingCache.FromPointer); // 0x38 GameSetting                 ( ModelClassType GameSettingCache GameSettingCache GameSettingCache Pointer )
            value.ProduceIdol                               = GetObject<ProduceIdolCache>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProduceIdolCache.FromPointer); // 0x40 ProduceIdol                 ( ModelClassType ProduceIdolCache ProduceIdolCache ProduceIdolCache Pointer )
            value.SupportCharacter                          = GetObject<SupportCharacterCache>(new IntPtr(p + 0x048), ReversePrism.DataModels.SupportCharacterCache.FromPointer); // 0x48 SupportCharacter            ( ModelClassType SupportCharacterCache SupportCharacterCache SupportCharacterCache Pointer )
            value.FesIdol                                   = GetObject<FesIdolCache>(new IntPtr(p + 0x050), ReversePrism.DataModels.FesIdolCache.FromPointer); // 0x50 FesIdol                     ( ModelClassType FesIdolCache FesIdolCache FesIdolCache Pointer )
            value.LiveUnit                                  = GetObject<LiveUnitCache>(new IntPtr(p + 0x058), ReversePrism.DataModels.LiveUnitCache.FromPointer); // 0x58 LiveUnit                    ( ModelClassType LiveUnitCache LiveUnitCache LiveUnitCache Pointer )
            value.Mv                                        = GetObject<MVCache>(new IntPtr(p + 0x060), ReversePrism.DataModels.MVCache.FromPointer); // 0x60 Mv                          ( ModelClassType MVCache MVCache MVCache Pointer )
            value.FesUnit                                   = GetObject<FesUnitCache>(new IntPtr(p + 0x068), ReversePrism.DataModels.FesUnitCache.FromPointer); // 0x68 FesUnit                     ( ModelClassType FesUnitCache FesUnitCache FesUnitCache Pointer )
            value.IdolBase                                  = GetObject<IdolBaseCache>(new IntPtr(p + 0x070), ReversePrism.DataModels.IdolBaseCache.FromPointer); // 0x70 IdolBase                    ( ModelClassType IdolBaseCache IdolBaseCache IdolBaseCache Pointer )
            value.CostumeSet                                = GetObject<CostumeSetCache>(new IntPtr(p + 0x078), ReversePrism.DataModels.CostumeSetCache.FromPointer); // 0x78 CostumeSet                  ( ModelClassType CostumeSetCache CostumeSetCache CostumeSetCache Pointer )
            value.Costume                                   = GetObject<CostumeCache>(new IntPtr(p + 0x080), ReversePrism.DataModels.CostumeCache.FromPointer); // 0x80 Costume                     ( ModelClassType CostumeCache CostumeCache CostumeCache Pointer )
            value.Hairstyle                                 = GetObject<HairstyleCache>(new IntPtr(p + 0x088), ReversePrism.DataModels.HairstyleCache.FromPointer); // 0x88 Hairstyle                   ( ModelClassType HairstyleCache HairstyleCache HairstyleCache Pointer )
            value.Accessory                                 = GetObject<AccessoryCache>(new IntPtr(p + 0x090), ReversePrism.DataModels.AccessoryCache.FromPointer); // 0x90 Accessory                   ( ModelClassType AccessoryCache AccessoryCache AccessoryCache Pointer )
            value.Song                                      = GetObject<SongCache>(new IntPtr(p + 0x098), ReversePrism.DataModels.SongCache.FromPointer); // 0x98 Song                        ( ModelClassType SongCache SongCache SongCache Pointer )
            value.Chain                                     = GetObject<ChainCache>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ChainCache.FromPointer); // 0xA0 Chain                       ( ModelClassType ChainCache ChainCache ChainCache Pointer )
            value.Phone                                     = GetObject<PhoneCache>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.PhoneCache.FromPointer); // 0xA8 Phone                       ( ModelClassType PhoneCache PhoneCache PhoneCache Pointer )
            value.OurStream                                 = GetObject<OurStreamCache>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.OurStreamCache.FromPointer); // 0xB0 OurStream                   ( ModelClassType OurStreamCache OurStreamCache OurStreamCache Pointer )
            value.Home                                      = GetObject<HomeCashe>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.HomeCashe.FromPointer); // 0xB8 Home                        ( ModelClassType HomeCashe HomeCashe HomeCashe Pointer )
            value.ProduceLog                                = GetObject<ProduceLogCache>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.ProduceLogCache.FromPointer); // 0xC0 ProduceLog                  ( ModelClassType ProduceLogCache ProduceLogCache ProduceLogCache Pointer )
            value.Story                                     = GetObject<StoryCache>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.StoryCache.FromPointer); // 0xC8 Story                       ( ModelClassType StoryCache StoryCache StoryCache Pointer )
            value.Introduction                              = GetObject<IntroductionCache>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.IntroductionCache.FromPointer); // 0xD0 Introduction                ( ModelClassType IntroductionCache IntroductionCache IntroductionCache Pointer )
            value.Gasha                                     = GetObject<GashaCashe>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.GashaCashe.FromPointer); // 0xD8 Gasha                       ( ModelClassType GashaCashe GashaCashe GashaCashe Pointer )

            return value;
        }
    }
}
