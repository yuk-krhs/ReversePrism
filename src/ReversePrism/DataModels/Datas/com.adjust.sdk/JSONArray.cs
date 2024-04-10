using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_List                                   000185CEE5D8 ModelClassListType List`1<JSONNode> List`1<JSONNode> List<JSONNode> Pointer
    public partial class JSONArray : DataModel
    {
        public List<JSONNode>?                          M_List                                  { get; set; }

        public static JSONArray? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JSONArray() { Pointer= p0 };

            value.M_List                                    = GetObjectList<JSONNode>(new IntPtr(p + 0x010), ReversePrism.DataModels.JSONNode.FromPointer); // 02466BB67E78 0x10 M_List                      ( 000185CEE5D8 ModelClassListType List`1<JSONNode> List`1<JSONNode> List<JSONNode> Pointer )

            return value;
        }
    }
}
