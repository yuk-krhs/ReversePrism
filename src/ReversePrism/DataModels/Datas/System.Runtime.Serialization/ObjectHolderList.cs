using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_values                                 000185B98BA0 ModelClassListType ObjectHolder[] ObjectHolder[] List<ObjectHolder> Pointer
    // 018 M_count                                  0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class ObjectHolderList
    {
        public List<ObjectHolder>?                      M_values                                { get; set; }
        public int                                      M_count                                 { get; set; }

        public static ObjectHolderList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObjectHolderList();

            value.M_values                                  = GetObjectList<ObjectHolder>(new IntPtr(p + 0x010), ReversePrism.DataModels.ObjectHolder.FromPointer); // 0270D6C1ED50 0x10 M_values                    ( 000185B98BA0 ModelClassListType ObjectHolder[] ObjectHolder[] List<ObjectHolder> Pointer )
            value.M_count                                   = GetInt32(new IntPtr(p + 0x018)); // 0270D6C1ED70 0x18 M_count                     ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
