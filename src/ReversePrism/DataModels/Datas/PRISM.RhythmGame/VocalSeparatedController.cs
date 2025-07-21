using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 DataList                                 ModelClassListType VocalSeparatedData[] VocalSeparatedData[] List<VocalSeparatedData> Pointer
    // 020 Player                                   ModelClassType CriAtomExPlayer CriAtomExPlayer CriAtomExPlayer Pointer
    // 028 Playbacks                                ModelEnumListType CriAtomExPlayback[] CriAtomExPlayback[] List<CriAtomExPlayback> Pointer
    // 030 cueInfos                                 ValueTuple`2<CriAtomExAcb, string>[] IL2CPP_TYPE_SZARRAY
    // 038 loadedCueSheets                          Dictionary`2<int, CriAtomCache> IL2CPP_TYPE_GENERICINST
    // 040 LastToggleCountIndices                   ModelPrimitiveListType int[] int[] List<int> Pointer
    // 048 volumeOnPlaybackIndexDic                 AutoInitializeDictionary`2<string, List`1<int>> IL2CPP_TYPE_GENERICINST
    public partial class VocalSeparatedController : DataModel
    {
        public List<VocalSeparatedData>?                DataList                                { get; set; }
        public CriAtomExPlayer?                         Player                                  { get; set; }
        public List<CriAtomExPlayback>?                 Playbacks                               { get; set; }
        public List<int>?                               LastToggleCountIndices                  { get; set; }

        public static VocalSeparatedController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VocalSeparatedController() { Pointer= p0 };

            value.DataList                                  = GetObjectList<VocalSeparatedData>(new IntPtr(p + 0x018), ReversePrism.DataModels.VocalSeparatedData.FromPointer); // 0x18 DataList                    ( ModelClassListType VocalSeparatedData[] VocalSeparatedData[] List<VocalSeparatedData> Pointer )
            value.Player                                    = GetObject<CriAtomExPlayer>(new IntPtr(p + 0x020), ReversePrism.DataModels.CriAtomExPlayer.FromPointer); // 0x20 Player                      ( ModelClassType CriAtomExPlayer CriAtomExPlayer CriAtomExPlayer Pointer )
            value.Playbacks                                 = GetEnumList<CriAtomExPlayback>(new IntPtr(p + 0x028)); // 0x28 Playbacks                   ( ModelEnumListType CriAtomExPlayback[] CriAtomExPlayback[] List<CriAtomExPlayback> Pointer )
            value.LastToggleCountIndices                    = GetInt32List(new IntPtr(p + 0x040)); // 0x40 LastToggleCountIndices      ( ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
