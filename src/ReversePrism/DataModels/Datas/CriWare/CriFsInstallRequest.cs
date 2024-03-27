using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 SourcePath                               000186671910 ModelPrimitiveType string string string String
    // 048 DestinationPath                          000186671910 ModelPrimitiveType string string string String
    // 050 Progress                                 0001866656B0 ModelPrimitiveType float float float Single
    public partial class CriFsInstallRequest
    {
        public string                                   SourcePath                              { get; set; }
        public string                                   DestinationPath                         { get; set; }
        public float                                    Progress                                { get; set; }

        public static CriFsInstallRequest? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriFsInstallRequest();

            value.SourcePath                                = GetString(new IntPtr(p + 0x040)); // 0270DACB6228 0x40 SourcePath                  ( 000186671910 ModelPrimitiveType string string string String )
            value.DestinationPath                           = GetString(new IntPtr(p + 0x048)); // 0270DACB6248 0x48 DestinationPath             ( 000186671910 ModelPrimitiveType string string string String )
            value.Progress                                  = GetSingle(new IntPtr(p + 0x050)); // 0270DACB6268 0x50 Progress                    ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
