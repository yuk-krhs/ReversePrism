using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Db                                       00018654BDF0 ModelClassType CatalogDB CatalogDB CatalogDB Pointer
    // 018 TotalDeletes                             0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class CatalogDBUpdater
    {
        public CatalogDB?                               Db                                      { get; set; }
        public int                                      TotalDeletes                            { get; set; }

        public static CatalogDBUpdater? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CatalogDBUpdater();

            value.Db                                        = GetObject<CatalogDB>(new IntPtr(p + 0x010), ReversePrism.DataModels.CatalogDB.FromPointer); // 0270DB4CF900 0x10 Db                          ( 00018654BDF0 ModelClassType CatalogDB CatalogDB CatalogDB Pointer )
            value.TotalDeletes                              = GetInt32(new IntPtr(p + 0x018)); // 0270DB4CF920 0x18 TotalDeletes                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
