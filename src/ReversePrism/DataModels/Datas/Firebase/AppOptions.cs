using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DatabaseUrl                              0001866A4270 ModelClassType Uri Uri Uri Pointer
    // 018 AppId                                    000186671910 ModelPrimitiveType string string string String
    // 020 ApiKey                                   000186671910 ModelPrimitiveType string string string String
    // 028 MessageSenderId                          000186671910 ModelPrimitiveType string string string String
    // 030 StorageBucket                            000186671910 ModelPrimitiveType string string string String
    // 038 ProjectId                                000186671910 ModelPrimitiveType string string string String
    // 040 PackageName                              000186671910 ModelPrimitiveType string string string String
    public partial class AppOptions : DataModel
    {
        public Uri?                                     DatabaseUrl                             { get; set; }
        public string                                   AppId                                   { get; set; }
        public string                                   ApiKey                                  { get; set; }
        public string                                   MessageSenderId                         { get; set; }
        public string                                   StorageBucket                           { get; set; }
        public string                                   ProjectId                               { get; set; }
        public string                                   PackageName                             { get; set; }

        public static AppOptions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AppOptions() { Pointer= p0 };

            value.DatabaseUrl                               = GetObject<Uri>(new IntPtr(p + 0x010), ReversePrism.DataModels.Uri.FromPointer); // 02466B7C78A0 0x10 DatabaseUrl                 ( 0001866A4270 ModelClassType Uri Uri Uri Pointer )
            value.AppId                                     = GetString(new IntPtr(p + 0x018)); // 02466B7C78C0 0x18 AppId                       ( 000186671910 ModelPrimitiveType string string string String )
            value.ApiKey                                    = GetString(new IntPtr(p + 0x020)); // 02466B7C78E0 0x20 ApiKey                      ( 000186671910 ModelPrimitiveType string string string String )
            value.MessageSenderId                           = GetString(new IntPtr(p + 0x028)); // 02466B7C7900 0x28 MessageSenderId             ( 000186671910 ModelPrimitiveType string string string String )
            value.StorageBucket                             = GetString(new IntPtr(p + 0x030)); // 02466B7C7920 0x30 StorageBucket               ( 000186671910 ModelPrimitiveType string string string String )
            value.ProjectId                                 = GetString(new IntPtr(p + 0x038)); // 02466B7C7940 0x38 ProjectId                   ( 000186671910 ModelPrimitiveType string string string String )
            value.PackageName                               = GetString(new IntPtr(p + 0x040)); // 02466B7C7960 0x40 PackageName                 ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
