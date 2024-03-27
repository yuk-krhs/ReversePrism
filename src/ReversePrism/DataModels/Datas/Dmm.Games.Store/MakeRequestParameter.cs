using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Url                                      0001866722E0 ModelPrimitiveType string string string String
    // 030 Parameters                               000185CFA278 ModelClassListType List`1<PostData> List`1<PostData> List<PostData> Pointer
    // 038 SignaturePublicKey                       0001866722E0 ModelPrimitiveType string string string String
    public partial class MakeRequestParameter
    {
        public string                                   Url                                     { get; set; }
        public List<PostData>?                          Parameters                              { get; set; }
        public string                                   SignaturePublicKey                      { get; set; }

        public static MakeRequestParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MakeRequestParameter();

            value.Url                                       = GetString(new IntPtr(p + 0x028)); // 0270DB4985B0 0x28 Url                         ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Parameters                                = GetObjectList<PostData>(new IntPtr(p + 0x030), ReversePrism.DataModels.PostData.FromPointer); // 0270DB4985D0 0x30 Parameters                  ( 000185CFA278 ModelClassListType List`1<PostData> List`1<PostData> List<PostData> Pointer )
            value.SignaturePublicKey                        = GetString(new IntPtr(p + 0x038)); // 0270DB4985F0 0x38 SignaturePublicKey          ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
