using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     ModelClassType Type Type Type Pointer
    // 018 Is_pinned                                ModelPrimitiveType bool bool bool Bool
    // 01A Position                                 ModelPrimitiveType ushort ushort ushort UInt16
    public partial class LocalVariableInfo : DataModel
    {
        public Type?                                    Type                                    { get; set; }
        public bool                                     Is_pinned                               { get; set; }
        public ushort                                   Position                                { get; set; }

        public static LocalVariableInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LocalVariableInfo() { Pointer= p0 };

            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0x10 Type                        ( ModelClassType Type Type Type Pointer )
            value.Is_pinned                                 = GetBool(new IntPtr(p + 0x018)); // 0x18 Is_pinned                   ( ModelPrimitiveType bool bool bool Bool )
            value.Position                                  = GetUInt16(new IntPtr(p + 0x01A)); // 0x1A Position                    ( ModelPrimitiveType ushort ushort ushort UInt16 )

            return value;
        }
    }
}
