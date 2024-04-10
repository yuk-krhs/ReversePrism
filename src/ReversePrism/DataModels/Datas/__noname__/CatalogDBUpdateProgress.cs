using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MapCatalogEntries                        int IL2CPP_TYPE_I4
    // 000 AnalyzeDiff                              int IL2CPP_TYPE_I4
    // 000 DeleteObsoleteEntries                    int IL2CPP_TYPE_I4
    // 000 UpdateModifiedEntries                    int IL2CPP_TYPE_I4
    // 000 InsertNewEntries                         int IL2CPP_TYPE_I4
    // 000 End                                      int IL2CPP_TYPE_I4
    public partial class CatalogDBUpdateProgress : DataModel
    {

        public static CatalogDBUpdateProgress? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CatalogDBUpdateProgress() { Pointer= p0 };


            return value;
        }
    }
}
