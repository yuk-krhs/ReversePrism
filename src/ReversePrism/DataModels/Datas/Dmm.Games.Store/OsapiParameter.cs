using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Oauth                                    0001866C4140 ModelClassType OAuthModel OAuthModel OAuthModel Pointer
    // 018 IsTwoLeggedOAuth                         000186595960 ModelPrimitiveType bool bool bool Bool
    // 020 Endpoint                                 0001866722E0 ModelPrimitiveType string string string String
    public partial class OsapiParameter : DataModel
    {
        public OAuthModel?                              Oauth                                   { get; set; }
        public bool                                     IsTwoLeggedOAuth                        { get; set; }
        public string                                   Endpoint                                { get; set; }

        public static OsapiParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OsapiParameter() { Pointer= p0 };

            value.Oauth                                     = GetObject<OAuthModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.OAuthModel.FromPointer); // 02466B5153F0 0x10 Oauth                       ( 0001866C4140 ModelClassType OAuthModel OAuthModel OAuthModel Pointer )
            value.IsTwoLeggedOAuth                          = GetBool(new IntPtr(p + 0x018)); // 02466B515410 0x18 IsTwoLeggedOAuth            ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Endpoint                                  = GetString(new IntPtr(p + 0x020)); // 02466B515430 0x20 Endpoint                    ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
