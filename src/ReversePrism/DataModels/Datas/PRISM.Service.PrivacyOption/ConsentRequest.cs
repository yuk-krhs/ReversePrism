using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 User_id                                  ModelPrimitiveType string string string String
    // 018 Errors                                   ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 020 Details                                  ModelClassListType List`1<Detail> List`1<Detail> List<Detail> Pointer
    public partial class ConsentRequest : DataModel
    {
        public string                                   User_id                                 { get; set; }
        public List<string>?                            Errors                                  { get; set; }
        public List<Detail>?                            Details                                 { get; set; }

        public static ConsentRequest? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConsentRequest() { Pointer= p0 };

            value.User_id                                   = GetString(new IntPtr(p + 0x010)); // 0x10 User_id                     ( ModelPrimitiveType string string string String )
            value.Errors                                    = GetStringList(new IntPtr(p + 0x018)); // 0x18 Errors                      ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.Details                                   = GetObjectList<Detail>(new IntPtr(p + 0x020), ReversePrism.DataModels.Detail.FromPointer); // 0x20 Details                     ( ModelClassListType List`1<Detail> List`1<Detail> List<Detail> Pointer )

            return value;
        }
    }
}
