using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SelectedCharacterInfoId                  0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class LegacyDressUpRoomParameter
    {
        public int                                      SelectedCharacterInfoId                 { get; set; }

        public static LegacyDressUpRoomParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LegacyDressUpRoomParameter();

            value.SelectedCharacterInfoId                   = GetInt32(new IntPtr(p + 0x010)); // 0270D4EF2B48 0x10 SelectedCharacterInfoId     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
