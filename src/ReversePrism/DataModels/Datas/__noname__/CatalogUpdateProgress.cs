using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 LocateRootCatalog                        int IL2CPP_TYPE_I4
    // 000 DownloadRootCatalog                      int IL2CPP_TYPE_I4
    // 000 ParseRootCatalog                         int IL2CPP_TYPE_I4
    // 000 ResetCatalogDB                           int IL2CPP_TYPE_I4
    // 000 LoadPreviousEntries                      int IL2CPP_TYPE_I4
    // 000 DownloadSubCatalog                       int IL2CPP_TYPE_I4
    // 000 ParseSubCatalogs                         int IL2CPP_TYPE_I4
    // 000 UpdateDBEntries                          int IL2CPP_TYPE_I4
    // 000 UpdateDBRelations                        int IL2CPP_TYPE_I4
    // 000 RecordDeleteFiles                        int IL2CPP_TYPE_I4
    // 000 OptimizeCatalogDB                        int IL2CPP_TYPE_I4
    // 000 End                                      int IL2CPP_TYPE_I4
    public partial class CatalogUpdateProgress : DataModel
    {

        public static CatalogUpdateProgress? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CatalogUpdateProgress() { Pointer= p0 };


            return value;
        }
    }
}
