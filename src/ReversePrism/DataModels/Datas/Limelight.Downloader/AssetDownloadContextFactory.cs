using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Db                                       ModelClassType CatalogDB CatalogDB CatalogDB Pointer
    // 018 temporaryHashPool                        ObjectPool`1<HashSet`1<ulong>> IL2CPP_TYPE_GENERICINST
    // 020 DownloadDataRoot                         ModelPrimitiveType string string string String
    public partial class AssetDownloadContextFactory : DataModel
    {
        public CatalogDB?                               Db                                      { get; set; }
        public string                                   DownloadDataRoot                        { get; set; }

        public static AssetDownloadContextFactory? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AssetDownloadContextFactory() { Pointer= p0 };

            value.Db                                        = GetObject<CatalogDB>(new IntPtr(p + 0x010), ReversePrism.DataModels.CatalogDB.FromPointer); // 0x10 Db                          ( ModelClassType CatalogDB CatalogDB CatalogDB Pointer )
            value.DownloadDataRoot                          = GetString(new IntPtr(p + 0x020)); // 0x20 DownloadDataRoot            ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
