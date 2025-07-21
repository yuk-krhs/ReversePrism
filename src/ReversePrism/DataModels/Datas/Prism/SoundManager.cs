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
    // 020 CriAtom                                  ModelClassType CriAtom CriAtom CriAtom Pointer
    // 028 AtomSources                              ModelClassListType CriAtomSource[] CriAtomSource[] List<CriAtomSource> Pointer
    // 030 CurrentBgm                               ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32
    // 038 CriAtomExOutPut                          ModelClassType CriAtomExOutputAnalyzer CriAtomExOutputAnalyzer CriAtomExOutputAnalyzer Pointer
    // 040 selectorsDic                             Dictionary`2<AudioType, Selector> IL2CPP_TYPE_GENERICINST
    // 048 categoryVolumes                          Dictionary`2<SoundCategory, float> IL2CPP_TYPE_GENERICINST
    // 050 CriAtomExPlayer                          ModelClassType CriAtomExPlayer CriAtomExPlayer CriAtomExPlayer Pointer
    // 058 CriAtomExPlayerFader                     ModelClassType CriAtomExPlayer CriAtomExPlayer CriAtomExPlayer Pointer
    // 060 onceSeDic                                Dictionary`2<ValueTuple`2<string, string>, StackableDisposable> IL2CPP_TYPE_GENERICINST
    // 068 BgmPlayer                                ModelClassType BgmPlayer BgmPlayer BgmPlayer Pointer
    // 000 initializeState                          InitializeState IL2CPP_TYPE_VALUETYPE
    // 070 SelectorsInfos                           ModelClassListType List`1<SelectorsInfo> List`1<SelectorsInfo> List<SelectorsInfo> Pointer
    // 008 <Instance>k__BackingField                SoundManager IL2CPP_TYPE_CLASS
    // 078 atomCache                                Dictionary`2<string, CriAtomCache> IL2CPP_TYPE_GENERICINST
    public partial class SoundManager : DataModel
    {
        public CriAtom?                                 CriAtom                                 { get; set; }
        public List<CriAtomSource>?                     AtomSources                             { get; set; }
        public CriAtomExPlayback                        CurrentBgm                              { get; set; }
        public CriAtomExOutputAnalyzer?                 CriAtomExOutPut                         { get; set; }
        public CriAtomExPlayer?                         CriAtomExPlayer                         { get; set; }
        public CriAtomExPlayer?                         CriAtomExPlayerFader                    { get; set; }
        public BgmPlayer?                               BgmPlayer                               { get; set; }
        public List<SelectorsInfo>?                     SelectorsInfos                          { get; set; }

        public static SoundManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SoundManager() { Pointer= p0 };

            value.CriAtom                                   = GetObject<CriAtom>(new IntPtr(p + 0x020), ReversePrism.DataModels.CriAtom.FromPointer); // 0x20 CriAtom                     ( ModelClassType CriAtom CriAtom CriAtom Pointer )
            value.AtomSources                               = GetObjectList<CriAtomSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CriAtomSource.FromPointer); // 0x28 AtomSources                 ( ModelClassListType CriAtomSource[] CriAtomSource[] List<CriAtomSource> Pointer )
            value.CurrentBgm                                = (CriAtomExPlayback)GetInt32(new IntPtr(p + 0x030)); // 0x30 CurrentBgm                  ( ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32 )
            value.CriAtomExOutPut                           = GetObject<CriAtomExOutputAnalyzer>(new IntPtr(p + 0x038), ReversePrism.DataModels.CriAtomExOutputAnalyzer.FromPointer); // 0x38 CriAtomExOutPut             ( ModelClassType CriAtomExOutputAnalyzer CriAtomExOutputAnalyzer CriAtomExOutputAnalyzer Pointer )
            value.CriAtomExPlayer                           = GetObject<CriAtomExPlayer>(new IntPtr(p + 0x050), ReversePrism.DataModels.CriAtomExPlayer.FromPointer); // 0x50 CriAtomExPlayer             ( ModelClassType CriAtomExPlayer CriAtomExPlayer CriAtomExPlayer Pointer )
            value.CriAtomExPlayerFader                      = GetObject<CriAtomExPlayer>(new IntPtr(p + 0x058), ReversePrism.DataModels.CriAtomExPlayer.FromPointer); // 0x58 CriAtomExPlayerFader        ( ModelClassType CriAtomExPlayer CriAtomExPlayer CriAtomExPlayer Pointer )
            value.BgmPlayer                                 = GetObject<BgmPlayer>(new IntPtr(p + 0x068), ReversePrism.DataModels.BgmPlayer.FromPointer); // 0x68 BgmPlayer                   ( ModelClassType BgmPlayer BgmPlayer BgmPlayer Pointer )
            value.SelectorsInfos                            = GetObjectList<SelectorsInfo>(new IntPtr(p + 0x070), ReversePrism.DataModels.SelectorsInfo.FromPointer); // 0x70 SelectorsInfos              ( ModelClassListType List`1<SelectorsInfo> List`1<SelectorsInfo> List<SelectorsInfo> Pointer )

            return value;
        }
    }
}
