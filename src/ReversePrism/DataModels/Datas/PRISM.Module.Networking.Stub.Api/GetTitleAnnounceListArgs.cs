using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetTitleAnnounceListArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 PlatformFieldNumber                      int IL2CPP_TYPE_I4
    // 018 Platform                                 000186671910 ModelPrimitiveType string string string String
    // 000 CursorFieldNumber                        int IL2CPP_TYPE_I4
    // 020 Cursor                                   000186671910 ModelPrimitiveType string string string String
    // 000 LimitFieldNumber                         int IL2CPP_TYPE_I4
    // 028 Limit                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 CategoryFieldNumber                      int IL2CPP_TYPE_I4
    // 02C Category                                 0001866BDDB0 ModelEnumType AnnounceCategory AnnounceCategory AnnounceCategory Int32
    public partial class GetTitleAnnounceListArgs : DataModel
    {
        public string                                   Platform                                { get; set; }
        public string                                   Cursor                                  { get; set; }
        public int                                      Limit                                   { get; set; }
        public AnnounceCategory                         Category                                { get; set; }

        public static GetTitleAnnounceListArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetTitleAnnounceListArgs() { Pointer= p0 };

            value.Platform                                  = GetString(new IntPtr(p + 0x018)); // 024662AE7598 0x18 Platform                    ( 000186671910 ModelPrimitiveType string string string String )
            value.Cursor                                    = GetString(new IntPtr(p + 0x020)); // 024662AE75D8 0x20 Cursor                      ( 000186671910 ModelPrimitiveType string string string String )
            value.Limit                                     = GetInt32(new IntPtr(p + 0x028)); // 024662AE7618 0x28 Limit                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Category                                  = (AnnounceCategory)GetInt32(new IntPtr(p + 0x02C)); // 024662AE7658 0x2C Category                    ( 0001866BDDB0 ModelEnumType AnnounceCategory AnnounceCategory AnnounceCategory Int32 )

            return value;
        }
    }
}
