using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 parentCache                              Dictionary`2<long, Nullable`1<ulong>> IL2CPP_TYPE_GENERICINST
    // 028 realNameCache                            Dictionary`2<ulong, string> IL2CPP_TYPE_GENERICINST
    // 030 resourceTypeCache                        Dictionary`2<ulong, int> IL2CPP_TYPE_GENERICINST
    // 038 seedCache                                Dictionary`2<ulong, ulong> IL2CPP_TYPE_GENERICINST
    // 040 queryAssetInfo                           PreparedSqliteQueryCommand`1<AssetInfoRow> IL2CPP_TYPE_GENERICINST
    // 048 queryParentLabel                         PreparedSqliteExecuteScalarCommand`1<long> IL2CPP_TYPE_GENERICINST
    // 050 querySeed                                PreparedSqliteExecuteScalarCommand`1<long> IL2CPP_TYPE_GENERICINST
    // 058 queryResourceType                        PreparedSqliteExecuteScalarCommand`1<int> IL2CPP_TYPE_GENERICINST
    // 060 updateAssetInfo                          PreparedSqliteUpdateCommand`1<AssetInfoRow> IL2CPP_TYPE_GENERICINST
    // 068 updateCatalogInfo                        PreparedSqliteUpdateCommand`1<CatalogInfoRow> IL2CPP_TYPE_GENERICINST
    // 070 DeleteAssetInfo                          000186777330 ModelClassType PreparedSqliteExecuteCommand PreparedSqliteExecuteCommand PreparedSqliteExecuteCommand Pointer
    // 078 DeleteCatalogInfo                        000186777330 ModelClassType PreparedSqliteExecuteCommand PreparedSqliteExecuteCommand PreparedSqliteExecuteCommand Pointer
    public partial class CatalogDB
    {
        public PreparedSqliteExecuteCommand?            DeleteAssetInfo                         { get; set; }
        public PreparedSqliteExecuteCommand?            DeleteCatalogInfo                       { get; set; }

        public static CatalogDB? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CatalogDB();

            value.DeleteAssetInfo                           = GetObject<PreparedSqliteExecuteCommand>(new IntPtr(p + 0x070), ReversePrism.DataModels.PreparedSqliteExecuteCommand.FromPointer); // 027003DE59C8 0x70 DeleteAssetInfo             ( 000186777330 ModelClassType PreparedSqliteExecuteCommand PreparedSqliteExecuteCommand PreparedSqliteExecuteCommand Pointer )
            value.DeleteCatalogInfo                         = GetObject<PreparedSqliteExecuteCommand>(new IntPtr(p + 0x078), ReversePrism.DataModels.PreparedSqliteExecuteCommand.FromPointer); // 027003DE59E8 0x78 DeleteCatalogInfo           ( 000186777330 ModelClassType PreparedSqliteExecuteCommand PreparedSqliteExecuteCommand PreparedSqliteExecuteCommand Pointer )

            return value;
        }
    }
}
