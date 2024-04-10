using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SelectedCharacterInfoId                  0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class LegacyDressUpRoomParameter : DataModel
    {
        public int                                      SelectedCharacterInfoId                 { get; set; }

        public static LegacyDressUpRoomParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LegacyDressUpRoomParameter() { Pointer= p0 };

            value.SelectedCharacterInfoId                   = GetInt32(new IntPtr(p + 0x010)); // 024664F586E0 0x10 SelectedCharacterInfoId     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
