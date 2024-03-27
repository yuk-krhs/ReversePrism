using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Node                                   000186747380 ModelClassType JSONNode JSONNode JSONNode Pointer
    // 018 M_Key                                    000186671910 ModelPrimitiveType string string string String
    public partial class JSONLazyCreator
    {
        public JSONNode?                                M_Node                                  { get; set; }
        public string                                   M_Key                                   { get; set; }

        public static JSONLazyCreator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JSONLazyCreator();

            value.M_Node                                    = GetObject<JSONNode>(new IntPtr(p + 0x010), ReversePrism.DataModels.JSONNode.FromPointer); // 0270DBB0C308 0x10 M_Node                      ( 000186747380 ModelClassType JSONNode JSONNode JSONNode Pointer )
            value.M_Key                                     = GetString(new IntPtr(p + 0x018)); // 0270DBB0C328 0x18 M_Key                       ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
