using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 InitialTabIndex                          0001865F4260 ModelPrimitiveType int int int Int32
    // 014 MstCharacterInfoId                       0001865F4260 ModelPrimitiveType int int int Int32
    public partial class IdolBaseDetailViewModel
    {
        public int                                      InitialTabIndex                         { get; set; }
        public int                                      MstCharacterInfoId                      { get; set; }

        public static IdolBaseDetailViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolBaseDetailViewModel();

            value.InitialTabIndex                           = GetInt32(new IntPtr(p + 0x010)); // 0270D5E87F80 0x10 InitialTabIndex             ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x014)); // 0270D5E87FA0 0x14 MstCharacterInfoId          ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
