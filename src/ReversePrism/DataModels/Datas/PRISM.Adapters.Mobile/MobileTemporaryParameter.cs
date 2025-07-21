using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CurrentUserCategory                      ModelEnumType UserCategory UserCategory UserCategory Int32
    // 014 CurrentPhoneHeaderTabIndex               ModelPrimitiveType int int int Int32
    public partial class MobileTemporaryParameter : DataModel
    {
        public UserCategory                             CurrentUserCategory                     { get; set; }
        public int                                      CurrentPhoneHeaderTabIndex              { get; set; }

        public static MobileTemporaryParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MobileTemporaryParameter() { Pointer= p0 };

            value.CurrentUserCategory                       = (UserCategory)GetInt32(new IntPtr(p + 0x010)); // 0x10 CurrentUserCategory         ( ModelEnumType UserCategory UserCategory UserCategory Int32 )
            value.CurrentPhoneHeaderTabIndex                = GetInt32(new IntPtr(p + 0x014)); // 0x14 CurrentPhoneHeaderTabIndex  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
