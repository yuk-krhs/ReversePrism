using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Db                                       00018654BDF0 ModelClassType CatalogDB CatalogDB CatalogDB Pointer
    // 018 DownloadDataRoot                         000186672F10 ModelPrimitiveType string string string String
    // 020 TotalEntries                             0001865F4260 ModelPrimitiveType int int int Int32
    public partial class RemoteBundleLocator
    {
        public CatalogDB?                               Db                                      { get; set; }
        public string                                   DownloadDataRoot                        { get; set; }
        public int                                      TotalEntries                            { get; set; }

        public static RemoteBundleLocator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RemoteBundleLocator();

            value.Db                                        = GetObject<CatalogDB>(new IntPtr(p + 0x010), ReversePrism.DataModels.CatalogDB.FromPointer); // 027003E1FCC8 0x10 Db                          ( 00018654BDF0 ModelClassType CatalogDB CatalogDB CatalogDB Pointer )
            value.DownloadDataRoot                          = GetString(new IntPtr(p + 0x018)); // 027003E1FCE8 0x18 DownloadDataRoot            ( 000186672F10 ModelPrimitiveType string string string String )
            value.TotalEntries                              = GetInt32(new IntPtr(p + 0x020)); // 027003E1FD08 0x20 TotalEntries                ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
