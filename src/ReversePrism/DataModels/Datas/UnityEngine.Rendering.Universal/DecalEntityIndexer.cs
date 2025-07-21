using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Entities                               ModelEnumListType List`1<DecalEntityItem> List`1<DecalEntityItem> List<DecalEntityItem> Pointer
    // 018 m_FreeIndices                            Queue`1<int> IL2CPP_TYPE_GENERICINST
    public partial class DecalEntityIndexer : DataModel
    {
        public List<DecalEntityItem>?                   M_Entities                              { get; set; }

        public static DecalEntityIndexer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DecalEntityIndexer() { Pointer= p0 };

            value.M_Entities                                = GetEnumList<DecalEntityItem>(new IntPtr(p + 0x010)); // 0x10 M_Entities                  ( ModelEnumListType List`1<DecalEntityItem> List`1<DecalEntityItem> List<DecalEntityItem> Pointer )

            return value;
        }
    }
}
