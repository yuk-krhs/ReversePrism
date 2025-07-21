using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 bgmCriAtomExPlayback                     Nullable`1<CriAtomExPlayback> IL2CPP_TYPE_GENERICINST
    // 018 BgmCueSheet                              ModelPrimitiveType string string string String
    // 020 BgmCueName                               ModelPrimitiveType string string string String
    // 028 BgmStartTime                             ModelPrimitiveType int int int Int32
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

            value.BgmCueSheet                               = GetString(new IntPtr(p + 0x018)); // 0x18 BgmCueSheet                 ( ModelPrimitiveType string string string String )
            value.BgmCueName                                = GetString(new IntPtr(p + 0x020)); // 0x20 BgmCueName                  ( ModelPrimitiveType string string string String )
            value.BgmStartTime                              = GetInt32(new IntPtr(p + 0x028)); // 0x28 BgmStartTime                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
