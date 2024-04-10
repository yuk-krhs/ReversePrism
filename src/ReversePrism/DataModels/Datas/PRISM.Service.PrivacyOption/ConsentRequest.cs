using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 User_id                                  0001866722E0 ModelPrimitiveType string string string String
    // 018 Errors                                   000185D0D6C8 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 020 Details                                  000185D20E18 ModelClassListType List`1<Detail> List`1<Detail> List<Detail> Pointer
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

            value.User_id                                   = GetString(new IntPtr(p + 0x010)); // 0246669637F8 0x10 User_id                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Errors                                    = GetStringList(new IntPtr(p + 0x018)); // 024666963818 0x18 Errors                      ( 000185D0D6C8 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.Details                                   = GetObjectList<Detail>(new IntPtr(p + 0x020), ReversePrism.DataModels.Detail.FromPointer); // 024666963838 0x20 Details                     ( 000185D20E18 ModelClassListType List`1<Detail> List`1<Detail> List<Detail> Pointer )

            return value;
        }
    }
}
