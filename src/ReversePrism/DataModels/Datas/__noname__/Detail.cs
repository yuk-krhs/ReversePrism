using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Consent_type                             0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 Consent_flg                              0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class Detail
    {
        public int                                      Consent_type                            { get; set; }
        public int                                      Consent_flg                             { get; set; }

        public static Detail? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Detail();

            value.Consent_type                              = GetInt32(new IntPtr(p + 0x010)); // 027004E53618 0x10 Consent_type                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Consent_flg                               = GetInt32(new IntPtr(p + 0x014)); // 027004E53638 0x14 Consent_flg                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
