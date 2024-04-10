using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SoundManager                             000186537E00 ModelClassType SoundManager SoundManager SoundManager Pointer
    // 018 SheetNames                               000185D0D798 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 020 Player                                   000186649570 ModelClassType CriAtomExPlayer CriAtomExPlayer CriAtomExPlayer Pointer
    // 028 SeAcb                                    000186645230 ModelClassType CriAtomExAcb CriAtomExAcb CriAtomExAcb Pointer
    // 030 noteLinePlayback                         Nullable`1<CriAtomExPlayback> IL2CPP_TYPE_GENERICINST
    // 038 IsDisposed                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 040 playVoiceActions                         Dictionary`2<LiveIdol, ValueTuple`2<Func`1<CriAtomExPlayback>, Func`1<CriAtomExPlayback>>> IL2CPP_TYPE_GENERICINST
    // 048 cueNameCache                             Dictionary`2<ValueTuple`2<string, int>, string> IL2CPP_TYPE_GENERICINST
    // 050 lastPlayTimes                            Dictionary`2<string, float> IL2CPP_TYPE_GENERICINST
    public partial class RhythmGameSoundService : DataModel
    {
        public SoundManager?                            SoundManager                            { get; set; }
        public List<string>?                            SheetNames                              { get; set; }
        public CriAtomExPlayer?                         Player                                  { get; set; }
        public CriAtomExAcb?                            SeAcb                                   { get; set; }
        public bool                                     IsDisposed                              { get; set; }

        public static RhythmGameSoundService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RhythmGameSoundService() { Pointer= p0 };

            value.SoundManager                              = GetObject<SoundManager>(new IntPtr(p + 0x010), ReversePrism.DataModels.SoundManager.FromPointer); // 024665089730 0x10 SoundManager                ( 000186537E00 ModelClassType SoundManager SoundManager SoundManager Pointer )
            value.SheetNames                                = GetStringList(new IntPtr(p + 0x018)); // 024665089750 0x18 SheetNames                  ( 000185D0D798 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.Player                                    = GetObject<CriAtomExPlayer>(new IntPtr(p + 0x020), ReversePrism.DataModels.CriAtomExPlayer.FromPointer); // 024665089770 0x20 Player                      ( 000186649570 ModelClassType CriAtomExPlayer CriAtomExPlayer CriAtomExPlayer Pointer )
            value.SeAcb                                     = GetObject<CriAtomExAcb>(new IntPtr(p + 0x028), ReversePrism.DataModels.CriAtomExAcb.FromPointer); // 024665089790 0x28 SeAcb                       ( 000186645230 ModelClassType CriAtomExAcb CriAtomExAcb CriAtomExAcb Pointer )
            value.IsDisposed                                = GetBool(new IntPtr(p + 0x038)); // 0246650897D0 0x38 IsDisposed                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
