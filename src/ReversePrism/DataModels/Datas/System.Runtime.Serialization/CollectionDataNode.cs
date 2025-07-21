using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 items                                    IList`1<IDataNode> IL2CPP_TYPE_GENERICINST
    // 058 ItemName                                 ModelPrimitiveType string string string String
    // 060 ItemNamespace                            ModelPrimitiveType string string string String
    // 068 Size                                     ModelPrimitiveType int int int Int32
    public partial class CollectionDataNode : DataModel
    {
        public string                                   ItemName                                { get; set; }
        public string                                   ItemNamespace                           { get; set; }
        public int                                      Size                                    { get; set; }

        public static CollectionDataNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CollectionDataNode() { Pointer= p0 };

            value.ItemName                                  = GetString(new IntPtr(p + 0x058)); // 0x58 ItemName                    ( ModelPrimitiveType string string string String )
            value.ItemNamespace                             = GetString(new IntPtr(p + 0x060)); // 0x60 ItemNamespace               ( ModelPrimitiveType string string string String )
            value.Size                                      = GetInt32(new IntPtr(p + 0x068)); // 0x68 Size                        ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
