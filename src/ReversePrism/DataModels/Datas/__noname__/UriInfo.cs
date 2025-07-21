using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Host                                     ModelPrimitiveType string string string String
    // 018 ScopeId                                  ModelPrimitiveType string string string String
    // 020 String                                   ModelPrimitiveType string string string String
    // 028 Offset                                   ModelEnumType Offset Offset Offset Int32
    // 038 DnsSafeHost                              ModelPrimitiveType string string string String
    // 040 MoreInfo                                 ModelClassType MoreInfo MoreInfo MoreInfo Pointer
    public partial class UriInfo : DataModel
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
            var value   = new UriInfo() { Pointer= p0 };

            value.Host                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Host                        ( ModelPrimitiveType string string string String )
            value.ScopeId                                   = GetString(new IntPtr(p + 0x018)); // 0x18 ScopeId                     ( ModelPrimitiveType string string string String )
            value.String                                    = GetString(new IntPtr(p + 0x020)); // 0x20 String                      ( ModelPrimitiveType string string string String )
            value.Offset                                    = (Offset)GetInt32(new IntPtr(p + 0x028)); // 0x28 Offset                      ( ModelEnumType Offset Offset Offset Int32 )
            value.DnsSafeHost                               = GetString(new IntPtr(p + 0x038)); // 0x38 DnsSafeHost                 ( ModelPrimitiveType string string string String )
            value.MoreInfo                                  = GetObject<MoreInfo>(new IntPtr(p + 0x040), ReversePrism.DataModels.MoreInfo.FromPointer); // 0x40 MoreInfo                    ( ModelClassType MoreInfo MoreInfo MoreInfo Pointer )

            return value;
        }
    }
}
