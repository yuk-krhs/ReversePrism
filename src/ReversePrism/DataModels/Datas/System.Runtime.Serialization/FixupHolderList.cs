using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_values                                 000185B7FA00 ModelClassListType FixupHolder[] FixupHolder[] List<FixupHolder> Pointer
    // 018 M_count                                  0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class FixupHolderList : DataModel
    {
        public List<FixupHolder>?                       M_values                                { get; set; }
        public int                                      M_count                                 { get; set; }

        public static FixupHolderList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FixupHolderList() { Pointer= p0 };

            value.M_values                                  = GetObjectList<FixupHolder>(new IntPtr(p + 0x010), ReversePrism.DataModels.FixupHolder.FromPointer); // 024666C8FEC0 0x10 M_values                    ( 000185B7FA00 ModelClassListType FixupHolder[] FixupHolder[] List<FixupHolder> Pointer )
            value.M_count                                   = GetInt32(new IntPtr(p + 0x018)); // 024666C8FEE0 0x18 M_count                     ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
