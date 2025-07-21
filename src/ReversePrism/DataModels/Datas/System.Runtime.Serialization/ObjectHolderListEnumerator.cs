using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_isFixupEnumerator                      ModelPrimitiveType bool bool bool Bool
    // 018 M_list                                   ModelClassType ObjectHolderList ObjectHolderList ObjectHolderList Pointer
    // 020 M_startingVersion                        ModelPrimitiveType int int int Int32
    // 024 M_currPos                                ModelPrimitiveType int int int Int32
    public partial class ObjectHolderListEnumerator : DataModel
    {
        public bool                                     M_isFixupEnumerator                     { get; set; }
        public ObjectHolderList?                        M_list                                  { get; set; }
        public int                                      M_startingVersion                       { get; set; }
        public int                                      M_currPos                               { get; set; }

        public static ObjectHolderListEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObjectHolderListEnumerator() { Pointer= p0 };

            value.M_isFixupEnumerator                       = GetBool(new IntPtr(p + 0x010)); // 0x10 M_isFixupEnumerator         ( ModelPrimitiveType bool bool bool Bool )
            value.M_list                                    = GetObject<ObjectHolderList>(new IntPtr(p + 0x018), ReversePrism.DataModels.ObjectHolderList.FromPointer); // 0x18 M_list                      ( ModelClassType ObjectHolderList ObjectHolderList ObjectHolderList Pointer )
            value.M_startingVersion                         = GetInt32(new IntPtr(p + 0x020)); // 0x20 M_startingVersion           ( ModelPrimitiveType int int int Int32 )
            value.M_currPos                                 = GetInt32(new IntPtr(p + 0x024)); // 0x24 M_currPos                   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
