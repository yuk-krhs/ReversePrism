using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Root                                   0001866CDE60 ModelClassType AtlasNode AtlasNode AtlasNode Pointer
    // 018 M_Width                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C M_Height                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 PowerOfTwoPadding                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 m_NodePool                               ObjectPool`1<AtlasNode> IL2CPP_TYPE_GENERICINST
    public partial class AtlasAllocator
    {
        public AtlasNode?                               M_Root                                  { get; set; }
        public int                                      M_Width                                 { get; set; }
        public int                                      M_Height                                { get; set; }
        public bool                                     PowerOfTwoPadding                       { get; set; }

        public static AtlasAllocator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AtlasAllocator();

            value.M_Root                                    = GetObject<AtlasNode>(new IntPtr(p + 0x010), ReversePrism.DataModels.AtlasNode.FromPointer); // 0270D92787C8 0x10 M_Root                      ( 0001866CDE60 ModelClassType AtlasNode AtlasNode AtlasNode Pointer )
            value.M_Width                                   = GetInt32(new IntPtr(p + 0x018)); // 0270D92787E8 0x18 M_Width                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_Height                                  = GetInt32(new IntPtr(p + 0x01C)); // 0270D9278808 0x1C M_Height                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PowerOfTwoPadding                         = GetBool(new IntPtr(p + 0x020)); // 0270D9278828 0x20 PowerOfTwoPadding           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
