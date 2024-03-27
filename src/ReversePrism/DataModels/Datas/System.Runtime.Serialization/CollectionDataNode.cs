using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 items                                    IList`1<IDataNode> IL2CPP_TYPE_GENERICINST
    // 058 ItemName                                 000186671910 ModelPrimitiveType string string string String
    // 060 ItemNamespace                            000186671910 ModelPrimitiveType string string string String
    // 068 Size                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class CollectionDataNode
    {
        public string                                   ItemName                                { get; set; }
        public string                                   ItemNamespace                           { get; set; }
        public int                                      Size                                    { get; set; }

        public static CollectionDataNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CollectionDataNode();

            value.ItemName                                  = GetString(new IntPtr(p + 0x058)); // 0270D7D35988 0x58 ItemName                    ( 000186671910 ModelPrimitiveType string string string String )
            value.ItemNamespace                             = GetString(new IntPtr(p + 0x060)); // 0270D7D359A8 0x60 ItemNamespace               ( 000186671910 ModelPrimitiveType string string string String )
            value.Size                                      = GetInt32(new IntPtr(p + 0x068)); // 0270D7D359C8 0x68 Size                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
