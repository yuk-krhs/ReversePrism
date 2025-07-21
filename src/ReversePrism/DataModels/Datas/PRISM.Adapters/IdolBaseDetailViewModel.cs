using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 InitialTabIndex                          ModelPrimitiveType int int int Int32
    // 014 MstCharacterInfoId                       ModelPrimitiveType int int int Int32
    public partial class IdolBaseDetailViewModel : DataModel
    {
        public int                                      InitialTabIndex                         { get; set; }
        public int                                      MstCharacterInfoId                      { get; set; }

        public static IdolBaseDetailViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolBaseDetailViewModel() { Pointer= p0 };

            value.InitialTabIndex                           = GetInt32(new IntPtr(p + 0x010)); // 0x10 InitialTabIndex             ( ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstCharacterInfoId          ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
