using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Indexer                                  000186613DA0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 020 _obj                                     Nullable`1<LocalDefinition> IL2CPP_TYPE_GENERICINST
    // 038 Args                                     000185B92450 ModelEnumListType LocalDefinition[] LocalDefinition[] List<LocalDefinition> Pointer
    public partial class IndexMethodByRefUpdater
    {
        public MethodInfo?                              Indexer                                 { get; set; }
        public List<LocalDefinition>?                   Args                                    { get; set; }

        public static IndexMethodByRefUpdater? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IndexMethodByRefUpdater();

            value.Indexer                                   = GetObject<MethodInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.MethodInfo.FromPointer); // 0270DA00D280 0x18 Indexer                     ( 000186613DA0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.Args                                      = GetEnumList<LocalDefinition>(new IntPtr(p + 0x038)); // 0270DA00D2C0 0x38 Args                        ( 000185B92450 ModelEnumListType LocalDefinition[] LocalDefinition[] List<LocalDefinition> Pointer )

            return value;
        }
    }
}
