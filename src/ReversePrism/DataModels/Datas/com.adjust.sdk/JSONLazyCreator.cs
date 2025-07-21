using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Node                                   ModelClassType JSONNode JSONNode JSONNode Pointer
    // 018 M_Key                                    ModelPrimitiveType string string string String
    public partial class JSONLazyCreator : DataModel
    {
        public JSONNode?                                M_Node                                  { get; set; }
        public string                                   M_Key                                   { get; set; }

        public static JSONLazyCreator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JSONLazyCreator() { Pointer= p0 };

            value.M_Node                                    = GetObject<JSONNode>(new IntPtr(p + 0x010), ReversePrism.DataModels.JSONNode.FromPointer); // 0x10 M_Node                      ( ModelClassType JSONNode JSONNode JSONNode Pointer )
            value.M_Key                                     = GetString(new IntPtr(p + 0x018)); // 0x18 M_Key                       ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
