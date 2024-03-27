using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Nodes                                  000185CB65B8 ModelEnumListType AtlasNode[] AtlasNode[] List<AtlasNode> Pointer
    // 018 M_Next                                   0001865F1060 ModelPrimitiveType short short short Int16
    // 01A M_FreelistHead                           0001865F1060 ModelPrimitiveType short short short Int16
    public partial class AtlasNodePool
    {
        public List<AtlasNode>?                         M_Nodes                                 { get; set; }
        public short                                    M_Next                                  { get; set; }
        public short                                    M_FreelistHead                          { get; set; }

        public static AtlasNodePool? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AtlasNodePool();

            value.M_Nodes                                   = GetEnumList<AtlasNode>(new IntPtr(p + 0x010)); // 0270D927F7F8 0x10 M_Nodes                     ( 000185CB65B8 ModelEnumListType AtlasNode[] AtlasNode[] List<AtlasNode> Pointer )
            value.M_Next                                    = GetInt16(new IntPtr(p + 0x018)); // 0270D927F818 0x18 M_Next                      ( 0001865F1060 ModelPrimitiveType short short short Int16 )
            value.M_FreelistHead                            = GetInt16(new IntPtr(p + 0x01A)); // 0270D927F838 0x1A M_FreelistHead              ( 0001865F1060 ModelPrimitiveType short short short Int16 )

            return value;
        }
    }
}
