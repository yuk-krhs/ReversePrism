using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BirthYear                                ModelPrimitiveType int int int Int32
    // 024 BirthMonth                               ModelPrimitiveType int int int Int32
    // 028 BirthDay                                 ModelPrimitiveType int int int Int32
    public partial class PersonalLocalSave : DataModel
    {
        public int                                      BirthYear                               { get; set; }
        public int                                      BirthMonth                              { get; set; }
        public int                                      BirthDay                                { get; set; }

        public static PersonalLocalSave? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PersonalLocalSave() { Pointer= p0 };

            value.BirthYear                                 = GetInt32(new IntPtr(p + 0x020)); // 0x20 BirthYear                   ( ModelPrimitiveType int int int Int32 )
            value.BirthMonth                                = GetInt32(new IntPtr(p + 0x024)); // 0x24 BirthMonth                  ( ModelPrimitiveType int int int Int32 )
            value.BirthDay                                  = GetInt32(new IntPtr(p + 0x028)); // 0x28 BirthDay                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
