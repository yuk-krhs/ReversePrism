using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetAnnounceListArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 CursorFieldNumber                        int IL2CPP_TYPE_I4
    // 018 Cursor                                   000186671910 ModelPrimitiveType string string string String
    // 000 LimitFieldNumber                         int IL2CPP_TYPE_I4
    // 020 Limit                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 CategoryFieldNumber                      int IL2CPP_TYPE_I4
    // 024 Category                                 0001866BDDB0 ModelEnumType AnnounceCategory AnnounceCategory AnnounceCategory Int32
    public partial class GetAnnounceListArgs
    {
        public string                                   Cursor                                  { get; set; }
        public int                                      Limit                                   { get; set; }
        public AnnounceCategory                         Category                                { get; set; }

        public static GetAnnounceListArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetAnnounceListArgs();

            value.Cursor                                    = GetString(new IntPtr(p + 0x018)); // 0270D0B23A68 0x18 Cursor                      ( 000186671910 ModelPrimitiveType string string string String )
            value.Limit                                     = GetInt32(new IntPtr(p + 0x020)); // 0270D0B23AA8 0x20 Limit                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Category                                  = (AnnounceCategory)GetInt32(new IntPtr(p + 0x024)); // 0270D0B23AE8 0x24 Category                    ( 0001866BDDB0 ModelEnumType AnnounceCategory AnnounceCategory AnnounceCategory Int32 )

            return value;
        }
    }
}
