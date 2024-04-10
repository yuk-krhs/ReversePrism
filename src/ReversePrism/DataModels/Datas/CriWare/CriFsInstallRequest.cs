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
    public partial class CriFsInstallRequest : DataModel
    {
        public string                                   SourcePath                              { get; set; }
        public string                                   DestinationPath                         { get; set; }
        public float                                    Progress                                { get; set; }

        public static CriFsInstallRequest? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriFsInstallRequest() { Pointer= p0 };

            value.SourcePath                                = GetString(new IntPtr(p + 0x040)); // 02466AD1E228 0x40 SourcePath                  ( 000186671910 ModelPrimitiveType string string string String )
            value.DestinationPath                           = GetString(new IntPtr(p + 0x048)); // 02466AD1E248 0x48 DestinationPath             ( 000186671910 ModelPrimitiveType string string string String )
            value.Progress                                  = GetSingle(new IntPtr(p + 0x050)); // 02466AD1E268 0x50 Progress                    ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
