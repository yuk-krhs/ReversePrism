using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     000186692A80 ModelClassType Type Type Type Pointer
    // 018 Is_pinned                                000186595210 ModelPrimitiveType bool bool bool Bool
    // 01A Position                                 000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16
    public partial class LocalVariableInfo
    {
        public Type?                                    Type                                    { get; set; }
        public bool                                     Is_pinned                               { get; set; }
        public ushort                                   Position                                { get; set; }

        public static LocalVariableInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LocalVariableInfo();

            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0270D6CEE278 0x10 Type                        ( 000186692A80 ModelClassType Type Type Type Pointer )
            value.Is_pinned                                 = GetBool(new IntPtr(p + 0x018)); // 0270D6CEE298 0x18 Is_pinned                   ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.Position                                  = GetUInt16(new IntPtr(p + 0x01A)); // 0270D6CEE2B8 0x1A Position                    ( 000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16 )

            return value;
        }
    }
}
