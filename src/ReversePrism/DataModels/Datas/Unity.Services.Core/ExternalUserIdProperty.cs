using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UserIdChanged                            Action`1<string> IL2CPP_TYPE_GENERICINST
    // 018 M_UserId                                 ModelPrimitiveType string string string String
    public partial class ExternalUserIdProperty : DataModel
    {
        public string                                   M_UserId                                { get; set; }

        public static ExternalUserIdProperty? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExternalUserIdProperty() { Pointer= p0 };

            value.M_UserId                                  = GetString(new IntPtr(p + 0x018)); // 0x18 M_UserId                    ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
