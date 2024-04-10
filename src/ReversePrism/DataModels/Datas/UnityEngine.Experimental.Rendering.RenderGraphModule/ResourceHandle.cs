using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kValidityMask                            uint IL2CPP_TYPE_U4
    // 000 kIndexMask                               uint IL2CPP_TYPE_U4
    // 010 M_Value                                  000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 000 s_CurrentValidBit                        uint IL2CPP_TYPE_U4
    // 004 s_SharedResourceValidBit                 uint IL2CPP_TYPE_U4
    // 014 Type                                     000186656710 ModelEnumType RenderGraphResourceType RenderGraphResourceType RenderGraphResourceType Int32
    public partial class ResourceHandle : DataModel
    {
        public uint                                     M_Value                                 { get; set; }
        public RenderGraphResourceType                  Type                                    { get; set; }

        public static ResourceHandle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ResourceHandle() { Pointer= p0 };

            value.M_Value                                   = GetUInt32(new IntPtr(p + 0x010)); // 0246690BBC30 0x10 M_Value                     ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.Type                                      = (RenderGraphResourceType)GetInt32(new IntPtr(p + 0x014)); // 0246690BBC90 0x14 Type                        ( 000186656710 ModelEnumType RenderGraphResourceType RenderGraphResourceType RenderGraphResourceType Int32 )

            return value;
        }
    }
}
