using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Nodes                                  ModelEnumListType AtlasNode[] AtlasNode[] List<AtlasNode> Pointer
    // 018 M_Next                                   ModelPrimitiveType short short short Int16
    // 01A M_FreelistHead                           ModelPrimitiveType short short short Int16
    public partial class AtlasNodePool : DataModel
    {
        public List<AtlasNode>?                         M_Nodes                                 { get; set; }
        public short                                    M_Next                                  { get; set; }
        public short                                    M_FreelistHead                          { get; set; }

        public static AtlasNodePool? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AtlasNodePool() { Pointer= p0 };

            value.M_Nodes                                   = GetEnumList<AtlasNode>(new IntPtr(p + 0x010)); // 0x10 M_Nodes                     ( ModelEnumListType AtlasNode[] AtlasNode[] List<AtlasNode> Pointer )
            value.M_Next                                    = GetInt16(new IntPtr(p + 0x018)); // 0x18 M_Next                      ( ModelPrimitiveType short short short Int16 )
            value.M_FreelistHead                            = GetInt16(new IntPtr(p + 0x01A)); // 0x1A M_FreelistHead              ( ModelPrimitiveType short short short Int16 )

            return value;
        }
    }
}
