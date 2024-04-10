using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 CatalogBinaryVersion                     sbyte IL2CPP_TYPE_U1
    // 000 RootCatalogSecret                        sbyte[] IL2CPP_TYPE_SZARRAY
    // FFFFFFFF RealNameWorkBuf                          sbyte[] IL2CPP_TYPE_SZARRAY
    // 000 GetRealnameWorkBufSize                   int IL2CPP_TYPE_I4
    // FFFFFFFF MD5                                      MD5 IL2CPP_TYPE_CLASS
    // 000 AssetbundleFileMagic                     sbyte IL2CPP_TYPE_U1
    // 000 CatalogFileMagic                         sbyte IL2CPP_TYPE_U1
    // 000 CatalogDBVersion                         string IL2CPP_TYPE_STRING
    // 000 CatalogDBVersionKey                      string IL2CPP_TYPE_STRING
    // 000 LocalAssetsRootName                      string IL2CPP_TYPE_STRING
    public partial class CatalogDefinition : DataModel
    {

        public static CatalogDefinition? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CatalogDefinition() { Pointer= p0 };


            return value;
        }
    }
}
