using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<UnreadStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 LastUpdateDateTypeFieldNumber            int IL2CPP_TYPE_I4
    // 018 LastUpdateDateType                       00018677A280 ModelEnumType LastUpdateDateType LastUpdateDateType LastUpdateDateType Int32
    // 000 IsUnreadFieldNumber                      int IL2CPP_TYPE_I4
    // 01C IsUnread                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class UnreadStatus : DataModel
    {
        public LastUpdateDateType                       LastUpdateDateType                      { get; set; }
        public bool                                     IsUnread                                { get; set; }

        public static UnreadStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnreadStatus() { Pointer= p0 };

            value.LastUpdateDateType                        = (LastUpdateDateType)GetInt32(new IntPtr(p + 0x018)); // 024660B56C90 0x18 LastUpdateDateType          ( 00018677A280 ModelEnumType LastUpdateDateType LastUpdateDateType LastUpdateDateType Int32 )
            value.IsUnread                                  = GetBool(new IntPtr(p + 0x01C)); // 024660B56CD0 0x1C IsUnread                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
