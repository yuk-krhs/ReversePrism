using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 OK                                       MessagePopupButtonParameter IL2CPP_TYPE_CLASS
    // 008 Close                                    MessagePopupButtonParameter IL2CPP_TYPE_CLASS
    // 010 Cancel                                   000186609690 ModelClassType MessagePopupButtonParameter MessagePopupButtonParameter MessagePopupButtonParameter Pointer
    // 018 No                                       000186609690 ModelClassType MessagePopupButtonParameter MessagePopupButtonParameter MessagePopupButtonParameter Pointer
    // 020 Yes                                      000186609690 ModelClassType MessagePopupButtonParameter MessagePopupButtonParameter MessagePopupButtonParameter Pointer
    // 028 Decide                                   000186609690 ModelClassType MessagePopupButtonParameter MessagePopupButtonParameter MessagePopupButtonParameter Pointer
    // 010 <TextKey>k__BackingField                 ValueTuple`2<string, int> IL2CPP_TYPE_GENERICINST
    public partial class MessagePopupButtonParameter : DataModel
    {
        public MessagePopupButtonParameter?             Cancel                                  { get; set; }
        public MessagePopupButtonParameter?             No                                      { get; set; }
        public MessagePopupButtonParameter?             Yes                                     { get; set; }
        public MessagePopupButtonParameter?             Decide                                  { get; set; }

        public static MessagePopupButtonParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MessagePopupButtonParameter() { Pointer= p0 };

            value.Cancel                                    = GetObject<MessagePopupButtonParameter>(new IntPtr(p + 0x010), ReversePrism.DataModels.MessagePopupButtonParameter.FromPointer); // 024666486C90 0x10 Cancel                      ( 000186609690 ModelClassType MessagePopupButtonParameter MessagePopupButtonParameter MessagePopupButtonParameter Pointer )
            value.No                                        = GetObject<MessagePopupButtonParameter>(new IntPtr(p + 0x018), ReversePrism.DataModels.MessagePopupButtonParameter.FromPointer); // 024666486CB0 0x18 No                          ( 000186609690 ModelClassType MessagePopupButtonParameter MessagePopupButtonParameter MessagePopupButtonParameter Pointer )
            value.Yes                                       = GetObject<MessagePopupButtonParameter>(new IntPtr(p + 0x020), ReversePrism.DataModels.MessagePopupButtonParameter.FromPointer); // 024666486CD0 0x20 Yes                         ( 000186609690 ModelClassType MessagePopupButtonParameter MessagePopupButtonParameter MessagePopupButtonParameter Pointer )
            value.Decide                                    = GetObject<MessagePopupButtonParameter>(new IntPtr(p + 0x028), ReversePrism.DataModels.MessagePopupButtonParameter.FromPointer); // 024666486CF0 0x28 Decide                      ( 000186609690 ModelClassType MessagePopupButtonParameter MessagePopupButtonParameter MessagePopupButtonParameter Pointer )

            return value;
        }
    }
}
