using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 bgmCriAtomExPlayback                     Nullable`1<CriAtomExPlayback> IL2CPP_TYPE_GENERICINST
    // 018 BgmCueSheet                              000186671910 ModelPrimitiveType string string string String
    // 020 BgmCueName                               000186671910 ModelPrimitiveType string string string String
    // 028 BgmStartTime                             0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class IngameBgmModel : DataModel
    {
        public string                                   BgmCueSheet                             { get; set; }
        public string                                   BgmCueName                              { get; set; }
        public int                                      BgmStartTime                            { get; set; }

        public static IngameBgmModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IngameBgmModel() { Pointer= p0 };

            value.BgmCueSheet                               = GetString(new IntPtr(p + 0x018)); // 024665BAD1E8 0x18 BgmCueSheet                 ( 000186671910 ModelPrimitiveType string string string String )
            value.BgmCueName                                = GetString(new IntPtr(p + 0x020)); // 024665BAD208 0x20 BgmCueName                  ( 000186671910 ModelPrimitiveType string string string String )
            value.BgmStartTime                              = GetInt32(new IntPtr(p + 0x028)); // 024665BAD228 0x28 BgmStartTime                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
