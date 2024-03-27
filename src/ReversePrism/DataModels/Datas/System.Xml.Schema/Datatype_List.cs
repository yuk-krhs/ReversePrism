using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 ItemType                                 000186687B60 ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 040 MinListSize                              0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class Datatype_List
    {
        public DatatypeImplementation?                  ItemType                                { get; set; }
        public int                                      MinListSize                             { get; set; }

        public static Datatype_List? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Datatype_List();

            value.ItemType                                  = GetObject<DatatypeImplementation>(new IntPtr(p + 0x038), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0270D7503320 0x38 ItemType                    ( 000186687B60 ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.MinListSize                               = GetInt32(new IntPtr(p + 0x040)); // 0270D7503340 0x40 MinListSize                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
