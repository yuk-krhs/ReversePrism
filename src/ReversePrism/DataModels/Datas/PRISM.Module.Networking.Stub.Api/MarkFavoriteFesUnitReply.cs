using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<MarkFavoriteFesUnitReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 FesUnitFieldNumber                       int IL2CPP_TYPE_I4
    // 018 FesUnit                                  00018656E120 ModelClassType FesUnitStatus FesUnitStatus FesUnitStatus Pointer
    public partial class MarkFavoriteFesUnitReply : DataModel
    {
        public FesUnitStatus?                           FesUnit                                 { get; set; }

        public static MarkFavoriteFesUnitReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MarkFavoriteFesUnitReply() { Pointer= p0 };

            value.FesUnit                                   = GetObject<FesUnitStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.FesUnitStatus.FromPointer); // 0246612A67B8 0x18 FesUnit                     ( 00018656E120 ModelClassType FesUnitStatus FesUnitStatus FesUnitStatus Pointer )

            return value;
        }
    }
}
