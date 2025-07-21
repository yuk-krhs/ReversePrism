using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 ItemType                                 ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 040 MinListSize                              ModelPrimitiveType int int int Int32
    public partial class Datatype_List : DataModel
    {
        public DatatypeImplementation?                  ItemType                                { get; set; }
        public int                                      MinListSize                             { get; set; }

        public static Datatype_List? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Datatype_List() { Pointer= p0 };

            value.ItemType                                  = GetObject<DatatypeImplementation>(new IntPtr(p + 0x038), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x38 ItemType                    ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.MinListSize                               = GetInt32(new IntPtr(p + 0x040)); // 0x40 MinListSize                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
