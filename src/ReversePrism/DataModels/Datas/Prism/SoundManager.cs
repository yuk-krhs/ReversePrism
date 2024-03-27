using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 AssetsDir                                string IL2CPP_TYPE_STRING
    // 000 SelfPath                                 string IL2CPP_TYPE_STRING
    // 000 AcfPath                                  string IL2CPP_TYPE_STRING
    // 000 ResourceTag                              string IL2CPP_TYPE_STRING
    // 000 DefaultRmsLevel                          float IL2CPP_TYPE_R4
    // 000 _Instance                                SoundManager IL2CPP_TYPE_CLASS
    // 020 CriAtom                                  0001866409E0 ModelClassType CriAtom CriAtom CriAtom Pointer
    // 028 AtomSources                              000185B78050 ModelClassListType CriAtomSource[] CriAtomSource[] List<CriAtomSource> Pointer
    // 030 CurrentBgm                               0001866481C0 ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32
    // 038 CriAtomExOutPut                          000186647BE0 ModelClassType CriAtomExOutputAnalyzer CriAtomExOutputAnalyzer CriAtomExOutputAnalyzer Pointer
    // 040 selectorsDic                             Dictionary`2<AudioType, Selector> IL2CPP_TYPE_GENERICINST
    // 048 SeDisposable                             0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 050 categoryVolumes                          Dictionary`2<SoundCategory, float> IL2CPP_TYPE_GENERICINST
    // 058 CriAtomExPlayer                          000186648E20 ModelClassType CriAtomExPlayer CriAtomExPlayer CriAtomExPlayer Pointer
    // 060 CriAtomExPlayerFader                     000186648E20 ModelClassType CriAtomExPlayer CriAtomExPlayer CriAtomExPlayer Pointer
    // 068 playbackMaps                             Dictionary`2<CriAtomExPlayback, CriAtomExPlayer> IL2CPP_TYPE_GENERICINST
    // 070 onceSeDic                                Dictionary`2<ValueTuple`2<string, string>, StackableDisposable> IL2CPP_TYPE_GENERICINST
    // 078 BgmPlayer                                00018674F3C0 ModelClassType BgmPlayer BgmPlayer BgmPlayer Pointer
    // 008 initializeState                          InitializeState IL2CPP_TYPE_VALUETYPE
    // 080 SelectorsInfos                           000185D07948 ModelClassListType List`1<SelectorsInfo> List`1<SelectorsInfo> List<SelectorsInfo> Pointer
    // 088 atomCache                                Dictionary`2<string, CriAtomCache> IL2CPP_TYPE_GENERICINST
    public partial class SoundManager
    {
        public CriAtom?                                 CriAtom                                 { get; set; }
        public List<CriAtomSource>?                     AtomSources                             { get; set; }
        public CriAtomExPlayback                        CurrentBgm                              { get; set; }
        public CriAtomExOutputAnalyzer?                 CriAtomExOutPut                         { get; set; }
        public IDisposable?                             SeDisposable                            { get; set; }
        public CriAtomExPlayer?                         CriAtomExPlayer                         { get; set; }
        public CriAtomExPlayer?                         CriAtomExPlayerFader                    { get; set; }
        public BgmPlayer?                               BgmPlayer                               { get; set; }
        public List<SelectorsInfo>?                     SelectorsInfos                          { get; set; }

        public static SoundManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SoundManager();

            value.CriAtom                                   = GetObject<CriAtom>(new IntPtr(p + 0x020), ReversePrism.DataModels.CriAtom.FromPointer); // 02700414F318 0x20 CriAtom                     ( 0001866409E0 ModelClassType CriAtom CriAtom CriAtom Pointer )
            value.AtomSources                               = GetObjectList<CriAtomSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CriAtomSource.FromPointer); // 02700414F338 0x28 AtomSources                 ( 000185B78050 ModelClassListType CriAtomSource[] CriAtomSource[] List<CriAtomSource> Pointer )
            value.CurrentBgm                                = (CriAtomExPlayback)GetInt32(new IntPtr(p + 0x030)); // 02700414F358 0x30 CurrentBgm                  ( 0001866481C0 ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32 )
            value.CriAtomExOutPut                           = GetObject<CriAtomExOutputAnalyzer>(new IntPtr(p + 0x038), ReversePrism.DataModels.CriAtomExOutputAnalyzer.FromPointer); // 02700414F378 0x38 CriAtomExOutPut             ( 000186647BE0 ModelClassType CriAtomExOutputAnalyzer CriAtomExOutputAnalyzer CriAtomExOutputAnalyzer Pointer )
            value.SeDisposable                              = GetObject<IDisposable>(new IntPtr(p + 0x048), ReversePrism.DataModels.IDisposable.FromPointer); // 02700414F3B8 0x48 SeDisposable                ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.CriAtomExPlayer                           = GetObject<CriAtomExPlayer>(new IntPtr(p + 0x058), ReversePrism.DataModels.CriAtomExPlayer.FromPointer); // 02700414F3F8 0x58 CriAtomExPlayer             ( 000186648E20 ModelClassType CriAtomExPlayer CriAtomExPlayer CriAtomExPlayer Pointer )
            value.CriAtomExPlayerFader                      = GetObject<CriAtomExPlayer>(new IntPtr(p + 0x060), ReversePrism.DataModels.CriAtomExPlayer.FromPointer); // 02700414F418 0x60 CriAtomExPlayerFader        ( 000186648E20 ModelClassType CriAtomExPlayer CriAtomExPlayer CriAtomExPlayer Pointer )
            value.BgmPlayer                                 = GetObject<BgmPlayer>(new IntPtr(p + 0x078), ReversePrism.DataModels.BgmPlayer.FromPointer); // 02700414F478 0x78 BgmPlayer                   ( 00018674F3C0 ModelClassType BgmPlayer BgmPlayer BgmPlayer Pointer )
            value.SelectorsInfos                            = GetObjectList<SelectorsInfo>(new IntPtr(p + 0x080), ReversePrism.DataModels.SelectorsInfo.FromPointer); // 02700414F4B8 0x80 SelectorsInfos              ( 000185D07948 ModelClassListType List`1<SelectorsInfo> List`1<SelectorsInfo> List<SelectorsInfo> Pointer )

            return value;
        }
    }
}
