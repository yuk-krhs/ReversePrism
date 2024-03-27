using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Width                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 M_Height                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 M_Pool                                   0001866CE6F0 ModelClassType AtlasNodePool AtlasNodePool AtlasNodePool Pointer
    // 020 M_Root                                   0001865F1060 ModelPrimitiveType short short short Int16
    // 028 m_NodeFromID                             Dictionary`2<int, short> IL2CPP_TYPE_GENERICINST
    public partial class AtlasAllocatorDynamic
    {
        public int                                      M_Width                                 { get; set; }
        public int                                      M_Height                                { get; set; }
        public AtlasNodePool?                           M_Pool                                  { get; set; }
        public short                                    M_Root                                  { get; set; }

        public static AtlasAllocatorDynamic? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AtlasAllocatorDynamic();

            value.M_Width                                   = GetInt32(new IntPtr(p + 0x010)); // 0270D927FF88 0x10 M_Width                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_Height                                  = GetInt32(new IntPtr(p + 0x014)); // 0270D927FFA8 0x14 M_Height                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_Pool                                    = GetObject<AtlasNodePool>(new IntPtr(p + 0x018), ReversePrism.DataModels.AtlasNodePool.FromPointer); // 0270D927FFC8 0x18 M_Pool                      ( 0001866CE6F0 ModelClassType AtlasNodePool AtlasNodePool AtlasNodePool Pointer )
            value.M_Root                                    = GetInt16(new IntPtr(p + 0x020)); // 0270D927FFE8 0x20 M_Root                      ( 0001865F1060 ModelPrimitiveType short short short Int16 )

            return value;
        }
    }
}
