using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Serialization                            int IL2CPP_TYPE_I4
    // 000 WriteObjectBegin                         int IL2CPP_TYPE_I4
    // 000 WriteObjectEnd                           int IL2CPP_TYPE_I4
    // 000 WriteObjectContentBegin                  int IL2CPP_TYPE_I4
    // 000 WriteObjectContentEnd                    int IL2CPP_TYPE_I4
    // 000 ReadObjectBegin                          int IL2CPP_TYPE_I4
    // 000 ReadObjectEnd                            int IL2CPP_TYPE_I4
    // 000 ElementIgnored                           int IL2CPP_TYPE_I4
    // 000 XsdExportBegin                           int IL2CPP_TYPE_I4
    // 000 XsdExportEnd                             int IL2CPP_TYPE_I4
    // 000 XsdImportBegin                           int IL2CPP_TYPE_I4
    // 000 XsdImportEnd                             int IL2CPP_TYPE_I4
    // 000 XsdExportError                           int IL2CPP_TYPE_I4
    // 000 XsdImportError                           int IL2CPP_TYPE_I4
    // 000 XsdExportAnnotationFailed                int IL2CPP_TYPE_I4
    // 000 XsdImportAnnotationFailed                int IL2CPP_TYPE_I4
    // 000 XsdExportDupItems                        int IL2CPP_TYPE_I4
    // 000 FactoryTypeNotFound                      int IL2CPP_TYPE_I4
    // 000 ObjectWithLargeDepth                     int IL2CPP_TYPE_I4
    public partial class TraceCode
    {

        public static TraceCode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TraceCode();


            return value;
        }
    }
}
