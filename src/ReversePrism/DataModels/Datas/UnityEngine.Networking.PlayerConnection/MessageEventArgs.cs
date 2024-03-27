using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PlayerId                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 Data                                     000185B79C30 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class MessageEventArgs
    {
        public int                                      PlayerId                                { get; set; }
        public List<sbyte>?                             Data                                    { get; set; }

        public static MessageEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MessageEventArgs();

            value.PlayerId                                  = GetInt32(new IntPtr(p + 0x010)); // 0270068C5E48 0x10 PlayerId                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Data                                      = GetSByteList(new IntPtr(p + 0x018)); // 0270068C5E68 0x18 Data                        ( 000185B79C30 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
