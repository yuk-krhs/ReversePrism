using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ParameterId                              000186541690 ModelEnumType Parameter Parameter Parameter Int32
    // 010 AisacIds                                 0001866992B0 ModelPrimitiveType uint uint uint UInt32
    public partial class Target : DataModel
    {
        public Parameter                                ParameterId                             { get; set; }
        public uint                                     AisacIds                                { get; set; }

        public static Target? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Target() { Pointer= p0 };

            value.ParameterId                               = (Parameter)GetInt32(new IntPtr(p + 0x010)); // 02466ACE1958 0x10 ParameterId                 ( 000186541690 ModelEnumType Parameter Parameter Parameter Int32 )
            value.AisacIds                                  = GetUInt32(new IntPtr(p + 0x010)); // 02466ACE1978 0x10 AisacIds                    ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
