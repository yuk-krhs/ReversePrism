using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 QueryText                                ModelPrimitiveType string string string String
    // 018 OkayButtonText                           ModelPrimitiveType string string string String
    // 020 CancelButtonText                         ModelPrimitiveType string string string String
    // 028 Options                                  ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 030 Callback                                 Action`2<bool, int> IL2CPP_TYPE_GENERICINST
    public partial class DialogRequest : DataModel
    {
        public string                                   QueryText                               { get; set; }
        public string                                   OkayButtonText                          { get; set; }
        public string                                   CancelButtonText                        { get; set; }
        public List<string>?                            Options                                 { get; set; }

        public static DialogRequest? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DialogRequest() { Pointer= p0 };

            value.QueryText                                 = GetString(new IntPtr(p + 0x010)); // 0x10 QueryText                   ( ModelPrimitiveType string string string String )
            value.OkayButtonText                            = GetString(new IntPtr(p + 0x018)); // 0x18 OkayButtonText              ( ModelPrimitiveType string string string String )
            value.CancelButtonText                          = GetString(new IntPtr(p + 0x020)); // 0x20 CancelButtonText            ( ModelPrimitiveType string string string String )
            value.Options                                   = GetStringList(new IntPtr(p + 0x028)); // 0x28 Options                     ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )

            return value;
        }
    }
}
