using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Message                                  ModelPrimitiveType string string string String
    // 018 Title                                    ModelPrimitiveType string string string String
    // 020 Buttons                                  ModelClassListType MessagePopupButtonParameter[] MessagePopupButtonParameter[] List<MessagePopupButtonParameter> Pointer
    // 028 SizeType                                 ModelEnumType PopupSizeType PopupSizeType PopupSizeType Int32
    // 02C IsEnableOutOfRange                       ModelPrimitiveType bool bool bool Bool
    public partial class MessagePopupParameter : DataModel
    {
        public string                                   Message                                 { get; set; }
        public string                                   Title                                   { get; set; }
        public List<MessagePopupButtonParameter>?       Buttons                                 { get; set; }
        public PopupSizeType                            SizeType                                { get; set; }
        public bool                                     IsEnableOutOfRange                      { get; set; }

        public static MessagePopupParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MessagePopupParameter() { Pointer= p0 };

            value.Message                                   = GetString(new IntPtr(p + 0x010)); // 0x10 Message                     ( ModelPrimitiveType string string string String )
            value.Title                                     = GetString(new IntPtr(p + 0x018)); // 0x18 Title                       ( ModelPrimitiveType string string string String )
            value.Buttons                                   = GetObjectList<MessagePopupButtonParameter>(new IntPtr(p + 0x020), ReversePrism.DataModels.MessagePopupButtonParameter.FromPointer); // 0x20 Buttons                     ( ModelClassListType MessagePopupButtonParameter[] MessagePopupButtonParameter[] List<MessagePopupButtonParameter> Pointer )
            value.SizeType                                  = (PopupSizeType)GetInt32(new IntPtr(p + 0x028)); // 0x28 SizeType                    ( ModelEnumType PopupSizeType PopupSizeType PopupSizeType Int32 )
            value.IsEnableOutOfRange                        = GetBool(new IntPtr(p + 0x02C)); // 0x2C IsEnableOutOfRange          ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
