using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Title                                    000186672F10 ModelPrimitiveType string string string String
    // 018 MarkType                                 00018658BC10 ModelEnumType PopupMarkType PopupMarkType PopupMarkType Int32
    // 020 OnInfoClick                              00018667A3C0 ModelClassType Action Action Action Pointer
    public partial class HeaderInfoParameter
    {
        public string                                   Title                                   { get; set; }
        public PopupMarkType                            MarkType                                { get; set; }
        public Action?                                  OnInfoClick                             { get; set; }

        public static HeaderInfoParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HeaderInfoParameter();

            value.Title                                     = GetString(new IntPtr(p + 0x010)); // 0270DB561F28 0x10 Title                       ( 000186672F10 ModelPrimitiveType string string string String )
            value.MarkType                                  = (PopupMarkType)GetInt32(new IntPtr(p + 0x018)); // 0270DB561F48 0x18 MarkType                    ( 00018658BC10 ModelEnumType PopupMarkType PopupMarkType PopupMarkType Int32 )
            value.OnInfoClick                               = GetObject<Action>(new IntPtr(p + 0x020), ReversePrism.DataModels.Action.FromPointer); // 0270DB561F68 0x20 OnInfoClick                 ( 00018667A3C0 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
