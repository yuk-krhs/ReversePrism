using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Host                                     0001866722E0 ModelPrimitiveType string string string String
    // 018 ScopeId                                  0001866722E0 ModelPrimitiveType string string string String
    // 020 String                                   0001866722E0 ModelPrimitiveType string string string String
    // 028 Offset                                   0001866BFD90 ModelEnumType Offset Offset Offset Int32
    // 038 DnsSafeHost                              0001866722E0 ModelPrimitiveType string string string String
    // 040 MoreInfo                                 0001866BF870 ModelClassType MoreInfo MoreInfo MoreInfo Pointer
    public partial class UriInfo
    {
        public string                                   Host                                    { get; set; }
        public string                                   ScopeId                                 { get; set; }
        public string                                   String                                  { get; set; }
        public Offset                                   Offset                                  { get; set; }
        public string                                   DnsSafeHost                             { get; set; }
        public MoreInfo?                                MoreInfo                                { get; set; }

        public static UriInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UriInfo();

            value.Host                                      = GetString(new IntPtr(p + 0x010)); // 027004C27700 0x10 Host                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ScopeId                                   = GetString(new IntPtr(p + 0x018)); // 027004C27720 0x18 ScopeId                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.String                                    = GetString(new IntPtr(p + 0x020)); // 027004C27740 0x20 String                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Offset                                    = (Offset)GetInt32(new IntPtr(p + 0x028)); // 027004C27760 0x28 Offset                      ( 0001866BFD90 ModelEnumType Offset Offset Offset Int32 )
            value.DnsSafeHost                               = GetString(new IntPtr(p + 0x038)); // 027004C27780 0x38 DnsSafeHost                 ( 0001866722E0 ModelPrimitiveType string string string String )
            value.MoreInfo                                  = GetObject<MoreInfo>(new IntPtr(p + 0x040), ReversePrism.DataModels.MoreInfo.FromPointer); // 027004C277A0 0x40 MoreInfo                    ( 0001866BF870 ModelClassType MoreInfo MoreInfo MoreInfo Pointer )

            return value;
        }
    }
}
