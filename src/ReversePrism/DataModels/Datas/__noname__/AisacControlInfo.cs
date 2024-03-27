using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     0001866722E0 ModelPrimitiveType string string string String
    // 018 Id                                       0001866992B0 ModelPrimitiveType uint uint uint UInt32
    public partial class AisacControlInfo
    {
        public string                                   Name                                    { get; set; }
        public uint                                     Id                                      { get; set; }

        public static AisacControlInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AisacControlInfo();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0270DACC10B8 0x10 Name                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Id                                        = GetUInt32(new IntPtr(p + 0x018)); // 0270DACC10D8 0x18 Id                          ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
