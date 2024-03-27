using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 MstCharacterInfoId                       0001865F4260 ModelPrimitiveType int int int Int32
    public partial class MstPhoneUser
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstCharacterInfoId                      { get; set; }

        public static MstPhoneUser? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstPhoneUser();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 02700460B2F8 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x014)); // 02700460B318 0x14 MstCharacterInfoId          ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
