using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 ParentId                                 ModelPrimitiveType int int int Int32
    // 018 <childrenIds>k__BackingField             IEnumerable`1<int> IL2CPP_TYPE_GENERICINST
    public partial class TreeItem : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      ParentId                                { get; set; }

        public static TreeItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TreeItem() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.ParentId                                  = GetInt32(new IntPtr(p + 0x014)); // 0x14 ParentId                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
