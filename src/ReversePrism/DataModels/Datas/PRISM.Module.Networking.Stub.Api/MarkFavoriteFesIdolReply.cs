using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<MarkFavoriteFesIdolReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 FesIdolFieldNumber                       int IL2CPP_TYPE_I4
    // 018 FesIdol                                  000186565F50 ModelClassType FesIdolStatus FesIdolStatus FesIdolStatus Pointer
    public partial class MarkFavoriteFesIdolReply : DataModel
    {
        public FesIdolStatus?                           FesIdol                                 { get; set; }

        public static MarkFavoriteFesIdolReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MarkFavoriteFesIdolReply() { Pointer= p0 };

            value.FesIdol                                   = GetObject<FesIdolStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.FesIdolStatus.FromPointer); // 024661222388 0x18 FesIdol                     ( 000186565F50 ModelClassType FesIdolStatus FesIdolStatus FesIdolStatus Pointer )

            return value;
        }
    }
}
