using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Db                                       ModelClassType CatalogDB CatalogDB CatalogDB Pointer
    // 018 TotalDeletes                             ModelPrimitiveType int int int Int32
    public partial class CatalogDBUpdater : DataModel
    {
        public CatalogDB?                               Db                                      { get; set; }
        public int                                      TotalDeletes                            { get; set; }

        public static CatalogDBUpdater? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CatalogDBUpdater() { Pointer= p0 };

            value.Db                                        = GetObject<CatalogDB>(new IntPtr(p + 0x010), ReversePrism.DataModels.CatalogDB.FromPointer); // 0x10 Db                          ( ModelClassType CatalogDB CatalogDB CatalogDB Pointer )
            value.TotalDeletes                              = GetInt32(new IntPtr(p + 0x018)); // 0x18 TotalDeletes                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
