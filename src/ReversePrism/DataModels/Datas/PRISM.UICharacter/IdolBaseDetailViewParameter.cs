using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CharacterId                              ModelPrimitiveType int int int Int32
    // 014 ReturnFromCasualCostumeSelection         ModelPrimitiveType bool bool bool Bool
    public partial class IdolBaseDetailViewParameter : DataModel
    {
        public int                                      CharacterId                             { get; set; }
        public bool                                     ReturnFromCasualCostumeSelection        { get; set; }

        public static IdolBaseDetailViewParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolBaseDetailViewParameter() { Pointer= p0 };

            value.CharacterId                               = GetInt32(new IntPtr(p + 0x010)); // 0x10 CharacterId                 ( ModelPrimitiveType int int int Int32 )
            value.ReturnFromCasualCostumeSelection          = GetBool(new IntPtr(p + 0x014)); // 0x14 ReturnFromCasualCostumeSelection ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
