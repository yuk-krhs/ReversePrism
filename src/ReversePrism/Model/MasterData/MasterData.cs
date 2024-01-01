using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Cache;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ReversePrism
{
    // masterdata.bytes
    public partial class MasterData
    {
        public string?                  FileName                { get; set; }
        public byte                     EntryCount              { get; private set; }

        /*
        public List<MasterDataBase[]>   DataEntries             { get; private set; } = new List<MasterDataBase[]>();
        public IEnumerable<_00_MstCharacterInfo> Idol                   => DataEntries[ 0].Cast<_00_MstCharacterInfo>();
        public IEnumerable<_01_MstIdol> Data02                 => DataEntries[ 1].Cast<_01_MstIdol>();    // Initial Dress?
        public IEnumerable<_02_MstIdolStandingPosition> Unit                   => DataEntries[ 2].Cast<_02_MstIdolStandingPosition>();
        public IEnumerable<_03_MstCostumeSet> CostumeSet             => DataEntries[ 3].Cast<_03_MstCostumeSet>();
        public IEnumerable<_04_MstCostume> Costume                => DataEntries[ 4].Cast<_04_MstCostume>();
        public IEnumerable<_05_MstCostumeResource> ClothModel             => DataEntries[ 5].Cast<_05_MstCostumeResource>();
        public IEnumerable<_06_MstHairstyle> CosutumePresets        => DataEntries[ 6].Cast<_06_MstHairstyle>();
        public IEnumerable<_07_MstHairstyleResource> Data08                 => DataEntries[ 7].Cast<_07_MstHairstyleResource>();
        public IEnumerable<_08_MstAccessorie> Data09                 => DataEntries[ 8].Cast<_08_MstAccessorie>();
        public IEnumerable<_09_MstAccessoryResource> AccessoryModel         => DataEntries[ 9].Cast<_09_MstAccessoryResource>();
        public IEnumerable<_39_MstSong> Song                   => DataEntries[39].Cast<_39_MstSong>();
        */

        public static string GetRealName(CatalogASet catalog)
        {
            var label   = CatalogDB.CalcResourceLabel("masterdata.bytes");

            if(!catalog.TryGetValue(label, out var rec))
                throw new InvalidDataException();

            var real    = CatalogDB.GetResourceName(rec);

            return real;
        }

        private void Load<T>(BinaryReader r, ref T[] values) where T : new()
        {
            values  = MasterDataDeserializer.Deserialize<T>(r);
        }

        private void Load(BinaryReader r)
        {
            EntryCount  = r.ReadByte();

            #if true
            Load(r, ref CharacterInfos);
            Load(r, ref Idols);
            Load(r, ref IdolStandingPositions);
            Load(r, ref CostumeSets);
            Load(r, ref Costumes);
            Load(r, ref CostumeResources);
            Load(r, ref Hairstyles);
            Load(r, ref HairstyleResources);
            Load(r, ref Accessories);
            Load(r, ref AccessoryResources);
            Load(r, ref FavoriteMarks);
            Load(r, ref ProductTypes);
            Load(r, ref ProduceIdolLimitBreakRecipes);
            Load(r, ref ProduceIdolEvolutionRecipes);
            Load(r, ref SupportCharacterLevelExps);
            Load(r, ref SupportCharacterLimitBreakRecipes);
            Load(r, ref OutgameVoiceMotions);
            Load(r, ref Units);
            Load(r, ref ItemProviders);
            Load(r, ref TrainingTickets);
            Load(r, ref ProduceActionEffectDisplays);
            Load(r, ref VoiceResources);
            Load(r, ref SupportEffects);
            Load(r, ref ProducePassiveEffects);
            Load(r, ref SupportCharacterLimitBreakBonuses);
            Load(r, ref Tips);
            Load(r, ref TipsCategory);
            Load(r, ref ExchangeProductFilters);
            Load(r, ref PotentialLiveSkills);
            Load(r, ref PotentialLiveSkillLevels);
            Load(r, ref LiveSkillEffects);
            Load(r, ref ChainGroups);
            Load(r, ref PhoneUsers);
            Load(r, ref PotentialSupportSkills);
            Load(r, ref Helps);
            Load(r, ref BirthdayVoice);
            Load(r, ref HelpGroups);
            Load(r, ref IdolStories);
            Load(r, ref TitleImages);
            Load(r, ref Songs);
            Load(r, ref AdvInfos);
            Load(r, ref TwestaUsers);
            Load(r, ref ChainUsers);
            Load(r, ref BannerGenre);
            Load(r, ref Achievement);
            Load(r, ref EventIcon);
            Load(r, ref LoginBonus);
            Load(r, ref LoginBonusGraffiti);
            Load(r, ref Episodes);
            Load(r, ref ProduceCardContentGroups);
            Load(r, ref ProduceActionEffects);
            Load(r, ref Events);
            Load(r, ref ProduceIdols);
            Load(r, ref TwestaArticles);
            Load(r, ref SupportCharacters);
            Load(r, ref GeneralItems);
            Load(r, ref RecoveryDrinks);
            Load(r, ref EpisodeEventMissionBanners);
            Load(r, ref MainStoryChapters);
            Load(r, ref MainStories);
            Load(r, ref ExtraStoryCategories);
            Load(r, ref ExtraStorySubCategories);
            Load(r, ref ExtraStories);
            Load(r, ref EventStories);
            Load(r, ref ChallengeTourStages);
            Load(r, ref ChallengeTourMissions);
            Load(r, ref ChallengeTours);
            Load(r, ref ChallengeTourRivals);
            Load(r, ref SeasonMissions);
            Load(r, ref GashaResources);
            Load(r, ref PhoneCalls);
            Load(r, ref GashaTickets);
            Load(r, ref GashaCompensationTickets);
            Load(r, ref GashaTokens);
            Load(r, ref SelectionTickets);
            Load(r, ref CostumeTickets);
            Load(r, ref ProduceStrategyTypes);
            Load(r, ref ChainTalkTexts);
            Load(r, ref ProduceAuditionSettings);
          //Load(r, ref FavoriteMarkIds);
            #else
            Load<_00_MstCharacterInfo>(r);
            Load<_01_MstIdol>(r);
            Load<_02_MstIdolStandingPosition>(r);
            Load<_03_MstCostumeSet>(r);
            Load<_04_MstCostume>(r);
            Load<_05_MstCostumeResource>(r);
            Load<_06_MstHairstyle>(r);
            Load<_07_MstHairstyleResource>(r);
            Load<_08_MstAccessorie>(r);
            Load<_09_MstAccessoryResource>(r);
            Load<_10_MstFavoriteMark>(r);
            Load<_11_MstProductType>(r);
            Load<_12_MstProduceIdolLimitBreakRecipe>(r);
            Load<_13_MstProduceIdolEvolutionRecipe>(r);
            Load<_14_MstSupportCharacterLevelExp>(r);
            Load<_15_MstSupportCharacterLimitBreakRecipe>(r);
            Load<_16_MstOutgameVoiceMotion>(r);
            Load<_17_MstUnit>(r);
            Load<_18_MstItemProvider>(r);
            Load<_19_MstTrainingTicket>(r);
            Load<_20_MstProduceActionEffectDisplay>(r);
            Load<_21_MstVoiceResource>(r);
            Load<_22_MstSupportEffect>(r);
            Load<_23_MstProducePassiveEffect>(r);
            Load<_24_MstSupportCharacterLimitBreakBonuse>(r);
            Load<MasterData26>(r);
            Load<_26_MstTipsCategor>(r);
            Load<_27_MstExchangeProductFilter>(r);
            Load<_28_MstPotentialLiveSkill>(r);
            Load<_29_MstPotentialLiveSkillLevel>(r);
            Load<_30_MstLiveSkillEffect>(r);
            Load<_31_MstChainGroup>(r);
            Load<_32_MstPhoneUser>(r);
            Load<_32_MstPhoneUser>(r);
            Load<_33_MstPotentialSupportSkill>(r);
            Load<MasterData35>(r);
            Load<MasterData36>(r);
            Load<_36_MstHelpGroup>(r);
            Load<MasterData38>(r);
            Load<_38_MstTitleImage>(r);
            Load<_39_MstSong>(r);
            Load<MasterData41>(r);
            Load<_41_MstTwestaUser>(r);
            Load<_42_MstChainUser>(r);
            Load<_43_MstBannerGenr>(r);
            Load<_44_MstAchievemen>(r);
            Load<_45_MstEventIco>(r);
            Load<_46_MstLoginBonu>(r);
            Load<_47_MstLoginBonusGraffit>(r);
            Load<_48_MstEpisode>(r);
            Load<_49_MstProduceCardContentGroup>(r);
            Load<_50_MstProduceActionEffect>(r);
            Load<MasterData52>(r);
            Load<_52_MstProduceIdol>(r);
            Load<_53_MstTwestaArticle>(r);
            Load<_54_MstSupportCharacter>(r);
            Load<_55_MstGeneralItem>(r);
            Load<_56_MstRecoveryDrink>(r);
            Load<MasterData58>(r);
            Load<_58_MstMainStoryChapter>(r);
            Load<_59_MstMainStorie>(r);
            Load<_60_MstExtraStoryCategorie>(r);
            Load<MasterData62>(r);
            Load<_62_MstExtraStorie>(r);
            Load<_63_MstEventStorie>(r);
            Load<_64_MstChallengeTourStage>(r);
            Load<_65_MstChallengeTourMission>(r);
            Load<MasterData67>(r);
            Load<MasterData68>(r);
            Load<MasterData69>(r);
            Load<_69_MstGashaResource>(r);
            Load<MasterData71>(r);
            Load<MasterData72>(r);
            Load<_72_MstGashaCompensationTicket>(r);
            Load<MasterData74>(r);
            Load<MasterData75>(r);
            Load<_75_MstCostumeTicket>(r);
            Load<MasterData77>(r);
            Load<MasterData78>(r);
            Load<MasterData79>(r);
            #endif

            //System.Diagnostics.Debug.Print($"{r.BaseStream.Position:X6}");
            //System.Diagnostics.Debug.Assert(r.BaseStream.Position == r.BaseStream.Length);
        }

        /*
        private void Load<T>(BinaryReader r) where T : MasterDataBase, new()
            => DataEntries.Add(MasterDataBase.ReadData<T>(r));
        */

        public static MasterData FromFile(string file)
        {
            using(var s= File.OpenRead(file))
                return FromStream(s);
        }

        public static MasterData FromStream(Stream s, bool leaveOpen = true)
        {
            var value   = new MasterData() { FileName= (s as FileStream)?.Name };

            using(var r= new BinaryReader(s))
                value.Load(r);

            return value;
        }
    }

    public static class MasterDataDeserializer
    {
        public delegate void FieldReader(BinaryReader r, object target);

        public static T[] Deserialize<T>(BinaryReader r) where T : new()
        {
            var fields  = new List<FieldReader>();
            var type    = typeof(T);
            var baseType= type.BaseType;
            var idField = type.GetFields().Where(i => i.GetCustomAttribute<IDAttribute>() != null).FirstOrDefault();

            if(null == idField)
                fields.Add(GetFieldReader(idField));

            foreach(var i in baseType.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance))
                fields.Add(GetFieldReader(i));

            foreach(var i in type.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance))
                fields.Add(GetFieldReader(i));

            var count       = r.ReadInt32();
            var values      = new T[count];

            for(int i= 0; i < count; ++i)
            {
                var value   = values[i]= new T();

                foreach(var j in fields)
                    j(r, value);
            }

            return values;
        }

        public static FieldReader GetFieldReader(FieldInfo fi)
        {
            if(fi.FieldType.IsArray)
            {
                if(fi.FieldType == typeof(byte))    return (r, target) => fi.SetValue(target, Enumerable.Range(0, r.ReadInt32()).Select(i => r.ReadByte  ()).ToArray());
                if(fi.FieldType == typeof(short))   return (r, target) => fi.SetValue(target, Enumerable.Range(0, r.ReadInt32()).Select(i => r.ReadInt16 ()).ToArray());
                if(fi.FieldType == typeof(ushort))  return (r, target) => fi.SetValue(target, Enumerable.Range(0, r.ReadInt32()).Select(i => r.ReadUInt16()).ToArray());
                if(fi.FieldType == typeof(int))     return (r, target) => fi.SetValue(target, Enumerable.Range(0, r.ReadInt32()).Select(i => r.ReadInt32 ()).ToArray());
                if(fi.FieldType == typeof(uint))    return (r, target) => fi.SetValue(target, Enumerable.Range(0, r.ReadInt32()).Select(i => r.ReadUInt32()).ToArray());
                if(fi.FieldType == typeof(long))    return (r, target) => fi.SetValue(target, Enumerable.Range(0, r.ReadInt32()).Select(i => r.ReadInt64 ()).ToArray());
                if(fi.FieldType == typeof(ulong))   return (r, target) => fi.SetValue(target, Enumerable.Range(0, r.ReadInt32()).Select(i => r.ReadUInt64()).ToArray());
                if(fi.FieldType == typeof(float))   return (r, target) => fi.SetValue(target, Enumerable.Range(0, r.ReadInt32()).Select(i => r.ReadSingle()).ToArray());
                if(fi.FieldType == typeof(double))  return (r, target) => fi.SetValue(target, Enumerable.Range(0, r.ReadInt32()).Select(i => r.ReadDouble()).ToArray());
                if(fi.FieldType == typeof(string))  return (r, target) => fi.SetValue(target, Enumerable.Range(0, r.ReadInt32()).Select(i => ReadString(r)) .ToArray());
            } else
            {
                if(fi.FieldType == typeof(byte))    return (r, target) => fi.SetValue(target, r.ReadByte  ());
                if(fi.FieldType == typeof(short))   return (r, target) => fi.SetValue(target, r.ReadInt16 ());
                if(fi.FieldType == typeof(ushort))  return (r, target) => fi.SetValue(target, r.ReadUInt16());
                if(fi.FieldType == typeof(int))     return (r, target) => fi.SetValue(target, r.ReadInt32 ());
                if(fi.FieldType == typeof(uint))    return (r, target) => fi.SetValue(target, r.ReadUInt32());
                if(fi.FieldType == typeof(long))    return (r, target) => fi.SetValue(target, r.ReadInt64 ());
                if(fi.FieldType == typeof(ulong))   return (r, target) => fi.SetValue(target, r.ReadUInt64());
                if(fi.FieldType == typeof(float))   return (r, target) => fi.SetValue(target, r.ReadSingle());
                if(fi.FieldType == typeof(double))  return (r, target) => fi.SetValue(target, r.ReadDouble());
                if(fi.FieldType == typeof(string))  return (r, target) => fi.SetValue(target, ReadString(r));
            }

            throw new NotSupportedException();
        }

        public static string? ReadString(BinaryReader r)
        {
            var size    = r.ReadInt32();

            if(size == 0)
                return null;

            var chars   = r.ReadInt32();
            var value   = Encoding.UTF8.GetString(r.ReadBytes(~size));

            System.Diagnostics.Debug.Assert(value.Length == chars);

            return value;
        }
    }

    public abstract partial class MasterDataBase
    {
        public byte                     Fields;

        public void ReadFieldCount(BinaryReader r, int verify)
        {
            Fields  = r.ReadByte();

            System.Diagnostics.Debug.Assert(Fields == verify);
        }

        public static T[] ReadData<T>(BinaryReader r) where T : MasterDataBase, new()
        {
            var pos = r.BaseStream.Position;

            try
            {
                var count   = r.ReadInt32();
                var values  = new T[count];

                for(int i= 0; i < count; ++i)
                {
                    values[i] = new T();
                    values[i].Deserialize(r);
                }

                System.Diagnostics.Debug.Print($"{r.BaseStream.Position:X6}: {typeof(T).Name} Count:{count}");

                return values;
            } catch
            {
                System.Diagnostics.Debug.Print($"{r.BaseStream.Position:X6}: {typeof(T).Name}");

                throw;
            }
        }

        protected abstract void Deserialize(BinaryReader r);

        protected void Read(BinaryReader r, ref byte       value)   => value= r.ReadByte();
        protected void Read(BinaryReader r, ref ushort     value)   => value= r.ReadUInt16();
        protected void Read(BinaryReader r, ref int        value)   => value= r.ReadInt32();
        protected void Read(BinaryReader r, ref long       value)   => value= r.ReadInt64();
        protected void Read(BinaryReader r, ref float      value)   => value= r.ReadSingle();
        protected void Read(BinaryReader r, ref double     value)   => value= r.ReadDouble();
        protected void Read(BinaryReader r, ref int[]?     value)   => value= Enumerable.Range(0, r.ReadInt32()).Select(i => r.ReadInt32()).ToArray();
        protected void Read(BinaryReader r, ref byte[]?    value)   => value= r.ReadBytes(r.ReadInt32());
        protected void Read(BinaryReader r, ref string?    value)   => value= ReadString(r);
        protected void Read(BinaryReader r, ref string?[]? value)   => value= Enumerable.Range(0, r.ReadInt32()).Select(i => ReadString(r)).ToArray();

        protected string? ReadString(BinaryReader r)
        {
            var size    = r.ReadInt32();

            if(size == 0)
                return null;

            var chars   = r.ReadInt32();
            var value   = Encoding.UTF8.GetString(r.ReadBytes(~size));

            System.Diagnostics.Debug.Assert(value.Length == chars);

            return value;
        }
    }

    public partial class _00_MstCharacterInfo : MasterDataBase    { }
    public partial class _01_MstIdol : MasterDataBase    { }
    public partial class _02_MstIdolStandingPosition : MasterDataBase    { }
    public partial class _03_MstCostumeSet : MasterDataBase    { }
    public partial class _04_MstCostume : MasterDataBase    { }
    public partial class _05_MstCostumeResource : MasterDataBase    { }
    public partial class _06_MstHairstyle : MasterDataBase    { }
    public partial class _07_MstHairstyleResource : MasterDataBase    { }
    public partial class _08_MstAccessorie : MasterDataBase    { }

    public partial class _09_MstAccessoryResource : MasterDataBase    { }
    public partial class _10_MstFavoriteMark : MasterDataBase    { }
    public partial class _11_MstProductType : MasterDataBase    { }
    public partial class _12_MstProduceIdolLimitBreakRecipe : MasterDataBase    { }
    public partial class _13_MstProduceIdolEvolutionRecipe : MasterDataBase    { }
    public partial class _14_MstSupportCharacterLevelExp : MasterDataBase    { }
    public partial class _15_MstSupportCharacterLimitBreakRecipe : MasterDataBase    { }
    public partial class _16_MstOutgameVoiceMotion : MasterDataBase    { }
    public partial class _17_MstUnit : MasterDataBase    { }
    public partial class _18_MstItemProvider : MasterDataBase    { }

    public partial class _19_MstTrainingTicket : MasterDataBase    { }
    public partial class _20_MstProduceActionEffectDisplay : MasterDataBase    { }
    public partial class _21_MstVoiceResource : MasterDataBase    { }
    public partial class _22_MstSupportEffect : MasterDataBase    { }
    public partial class _23_MstProducePassiveEffect : MasterDataBase    { }
    public partial class _24_MstSupportCharacterLimitBreakBonuse : MasterDataBase    { }
    public partial class _25_MstTip : MasterDataBase    { }
    public partial class _26_MstTipsCategor : MasterDataBase    { }
    public partial class _27_MstExchangeProductFilter : MasterDataBase    { }
    public partial class _28_MstPotentialLiveSkill : MasterDataBase    { }

    public partial class _29_MstPotentialLiveSkillLevel : MasterDataBase    { }
    public partial class _30_MstLiveSkillEffect : MasterDataBase    { }
    public partial class _31_MstChainGroup : MasterDataBase    { }
    public partial class _32_MstPhoneUser : MasterDataBase    { }
    public partial class _33_MstPotentialSupportSkill : MasterDataBase    { }
    public partial class _34_MstHelp : MasterDataBase    { }
    public partial class _35_MstBirthdayVoic : MasterDataBase    { }
    public partial class _36_MstHelpGroup : MasterDataBase    { }
    public partial class _37_MstIdolStorie : MasterDataBase    { }
    public partial class _38_MstTitleImage : MasterDataBase    { }

    public partial class _39_MstSong : MasterDataBase    { }
    public partial class _40_MstAdvInfo : MasterDataBase    { }
    public partial class _41_MstTwestaUser : MasterDataBase    { }
    public partial class _42_MstChainUser : MasterDataBase    { }
    public partial class _43_MstBannerGenr : MasterDataBase    { }
    public partial class _44_MstAchievemen : MasterDataBase    { }
    public partial class _45_MstEventIco : MasterDataBase    { }
    public partial class _46_MstLoginBonu : MasterDataBase    { }
    public partial class _47_MstLoginBonusGraffit : MasterDataBase    { }
    public partial class _48_MstEpisode : MasterDataBase    { }

    public partial class _49_MstProduceCardContentGroup : MasterDataBase    { }
    public partial class _50_MstProduceActionEffect : MasterDataBase    { }
    public partial class _51_MstEvent : MasterDataBase    { }
    public partial class _52_MstProduceIdol : MasterDataBase    { }
    public partial class _53_MstTwestaArticle : MasterDataBase    { }
    public partial class _54_MstSupportCharacter : MasterDataBase    { }
    public partial class _55_MstGeneralItem : MasterDataBase    { }
    public partial class _56_MstRecoveryDrink : MasterDataBase    { }
    public partial class _57_MstEpisodeEventMissionBanner : MasterDataBase    { }
    public partial class _58_MstMainStoryChapter : MasterDataBase    { }

    public partial class _59_MstMainStorie : MasterDataBase    { }
    public partial class _60_MstExtraStoryCategorie : MasterDataBase    { }
    public partial class _61_MstExtraStorySubCategorie : MasterDataBase    { }
    public partial class _62_MstExtraStorie : MasterDataBase    { }
    public partial class _63_MstEventStorie : MasterDataBase    { }
    public partial class _64_MstChallengeTourStage : MasterDataBase    { }
    public partial class _65_MstChallengeTourMission : MasterDataBase    { }
    public partial class _66_MstChallengeTour : MasterDataBase    { }
    public partial class _67_MstChallengeTourRival : MasterDataBase    { }
    public partial class _68_MstSeasonMission : MasterDataBase    { }

    public partial class _69_MstGashaResource : MasterDataBase    { }
    public partial class _70_MstPhoneCall : MasterDataBase    { }
    public partial class _71_MstGashaTicket : MasterDataBase    { }
    public partial class _72_MstGashaCompensationTicket : MasterDataBase    { }
    public partial class _73_MstGashaToken : MasterDataBase    { }
    public partial class _74_MstSelectionTicket : MasterDataBase    { }
    public partial class _75_MstCostumeTicket : MasterDataBase    { }
    public partial class _76_MstProduceStrategyType : MasterDataBase    { }
    public partial class _77_MstChainTalkText : MasterDataBase    { }
    public partial class _78_MstProduceAuditionSetting : MasterDataBase    { }
}
