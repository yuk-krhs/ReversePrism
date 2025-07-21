using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 onSelect                                 Subject`1<string> IL2CPP_TYPE_GENERICINST
    // 018 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    public partial class EtceteraCellListContext : DataModel
    {
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static EtceteraCellListContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EtceteraCellListContext() { Pointer= p0 };

            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x018), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x18 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
