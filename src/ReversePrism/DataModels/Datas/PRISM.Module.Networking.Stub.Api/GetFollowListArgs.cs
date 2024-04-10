using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetFollowListArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 CursorFieldNumber                        int IL2CPP_TYPE_I4
    // 018 Cursor                                   000186671910 ModelPrimitiveType string string string String
    // 000 SortOrderTypeFieldNumber                 int IL2CPP_TYPE_I4
    // 020 SortOrderType                            000186531D00 ModelEnumType SortOrderType SortOrderType SortOrderType Int32
    public partial class GetFollowListArgs : DataModel
    {
        public string                                   Cursor                                  { get; set; }
        public SortOrderType                            SortOrderType                           { get; set; }

        public static GetFollowListArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetFollowListArgs() { Pointer= p0 };

            value.Cursor                                    = GetString(new IntPtr(p + 0x018)); // 0246613961F8 0x18 Cursor                      ( 000186671910 ModelPrimitiveType string string string String )
            value.SortOrderType                             = (SortOrderType)GetInt32(new IntPtr(p + 0x020)); // 024661396238 0x20 SortOrderType               ( 000186531D00 ModelEnumType SortOrderType SortOrderType SortOrderType Int32 )

            return value;
        }
    }
}
