using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Playbacks                                000185CD4CA8 ModelEnumListType List`1<CriAtomExPlayback> List`1<CriAtomExPlayback> List<CriAtomExPlayback> Pointer
    public partial class ADVLogTalkNodeVoicePlaybackContainer
    {
        public List<CriAtomExPlayback>?                 Playbacks                               { get; set; }

        public static ADVLogTalkNodeVoicePlaybackContainer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ADVLogTalkNodeVoicePlaybackContainer();

            value.Playbacks                                 = GetEnumList<CriAtomExPlayback>(new IntPtr(p + 0x010)); // 0270DA1F7298 0x10 Playbacks                   ( 000185CD4CA8 ModelEnumListType List`1<CriAtomExPlayback> List`1<CriAtomExPlayback> List<CriAtomExPlayback> Pointer )

            return value;
        }
    }
}
