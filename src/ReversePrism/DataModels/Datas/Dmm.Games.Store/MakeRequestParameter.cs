using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Url                                      ModelPrimitiveType string string string String
    // 030 Parameters                               ModelClassListType List`1<PostData> List`1<PostData> List<PostData> Pointer
    // 038 SignaturePublicKey                       ModelPrimitiveType string string string String
    public partial class MakeRequestParameter : DataModel
    {
        public string                                   Url                                     { get; set; }
        public List<PostData>?                          Parameters                              { get; set; }
        public string                                   SignaturePublicKey                      { get; set; }

        public static MakeRequestParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MakeRequestParameter() { Pointer= p0 };

            value.Url                                       = GetString(new IntPtr(p + 0x028)); // 0x28 Url                         ( ModelPrimitiveType string string string String )
            value.Parameters                                = GetObjectList<PostData>(new IntPtr(p + 0x030), ReversePrism.DataModels.PostData.FromPointer); // 0x30 Parameters                  ( ModelClassListType List`1<PostData> List`1<PostData> List<PostData> Pointer )
            value.SignaturePublicKey                        = GetString(new IntPtr(p + 0x038)); // 0x38 SignaturePublicKey          ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
