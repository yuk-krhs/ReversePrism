using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 atomSources                              IReadOnlyDictionary`2<int, CriAtomSource> IL2CPP_TYPE_GENERICINST
    // 018 playSound                                Func`3<CriAtomSource, PlayParameters, CriAtomExPlayback> IL2CPP_TYPE_GENERICINST
    // 020 loadCueSheetAsync                        Func`3<string, CancellationToken, UniTask> IL2CPP_TYPE_GENERICINST
    // 028 unloadCueSheet                           Action`1<string> IL2CPP_TYPE_GENERICINST
    // 030 PrevCueSheet                             ModelPrimitiveType string string string String
    // 038 CurrentCueSheet                          ModelPrimitiveType string string string String
    // 040 CurrentPlayInfo                          ModelClassType BgmPlayInfo BgmPlayInfo BgmPlayInfo Pointer
    // 048 BgmLoadCts                               ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 050 ignoreCueSheetList                       HashSet`1<string> IL2CPP_TYPE_GENERICINST
    // 058 releaseCueSheetListOnNextPlay            HashSet`1<string> IL2CPP_TYPE_GENERICINST
    public partial class BgmPlayer : DataModel
    {
        public string                                   PrevCueSheet                            { get; set; }
        public string                                   CurrentCueSheet                         { get; set; }
        public BgmPlayInfo?                             CurrentPlayInfo                         { get; set; }
        public CancellationTokenSource?                 BgmLoadCts                              { get; set; }

        public static BgmPlayer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BgmPlayer() { Pointer= p0 };

            value.PrevCueSheet                              = GetString(new IntPtr(p + 0x030)); // 0x30 PrevCueSheet                ( ModelPrimitiveType string string string String )
            value.CurrentCueSheet                           = GetString(new IntPtr(p + 0x038)); // 0x38 CurrentCueSheet             ( ModelPrimitiveType string string string String )
            value.CurrentPlayInfo                           = GetObject<BgmPlayInfo>(new IntPtr(p + 0x040), ReversePrism.DataModels.BgmPlayInfo.FromPointer); // 0x40 CurrentPlayInfo             ( ModelClassType BgmPlayInfo BgmPlayInfo BgmPlayInfo Pointer )
            value.BgmLoadCts                                = GetObject<CancellationTokenSource>(new IntPtr(p + 0x048), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x48 BgmLoadCts                  ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
