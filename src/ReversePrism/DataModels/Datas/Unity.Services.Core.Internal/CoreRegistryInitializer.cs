using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Registry                               000186625910 ModelClassType CoreRegistry CoreRegistry CoreRegistry Pointer
    // 018 M_SortedPackageTypeHashes                000185CED1B8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    public partial class CoreRegistryInitializer : DataModel
    {
        public CoreRegistry?                            M_Registry                              { get; set; }
        public List<int>?                               M_SortedPackageTypeHashes               { get; set; }

        public static CoreRegistryInitializer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CoreRegistryInitializer() { Pointer= p0 };

            value.M_Registry                                = GetObject<CoreRegistry>(new IntPtr(p + 0x010), ReversePrism.DataModels.CoreRegistry.FromPointer); // 0245A65E4570 0x10 M_Registry                  ( 000186625910 ModelClassType CoreRegistry CoreRegistry CoreRegistry Pointer )
            value.M_SortedPackageTypeHashes                 = GetInt32List(new IntPtr(p + 0x018)); // 0245A65E4590 0x18 M_SortedPackageTypeHashes   ( 000185CED1B8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )

            return value;
        }
    }
}
