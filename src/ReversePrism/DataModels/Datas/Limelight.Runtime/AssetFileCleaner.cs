using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DownloadDataRoot                         000186672F10 ModelPrimitiveType string string string String
    // 018 DeleteRecordPath                         000186672F10 ModelPrimitiveType string string string String
    // 020 deleteRealNames                          HashSet`1<string> IL2CPP_TYPE_GENERICINST
    public partial class AssetFileCleaner : DataModel
    {
        public string                                   DownloadDataRoot                        { get; set; }
        public string                                   DeleteRecordPath                        { get; set; }

        public static AssetFileCleaner? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AssetFileCleaner() { Pointer= p0 };

            value.DownloadDataRoot                          = GetString(new IntPtr(p + 0x010)); // 02466305B438 0x10 DownloadDataRoot            ( 000186672F10 ModelPrimitiveType string string string String )
            value.DeleteRecordPath                          = GetString(new IntPtr(p + 0x018)); // 02466305B458 0x18 DeleteRecordPath            ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
