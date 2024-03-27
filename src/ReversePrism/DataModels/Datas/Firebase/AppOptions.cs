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
    public partial class AppOptions
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
            var value   = new AppOptions();

            value.DatabaseUrl                               = GetObject<Uri>(new IntPtr(p + 0x010), ReversePrism.DataModels.Uri.FromPointer); // 0270DB743230 0x10 DatabaseUrl                 ( 0001866A4270 ModelClassType Uri Uri Uri Pointer )
            value.AppId                                     = GetString(new IntPtr(p + 0x018)); // 0270DB743250 0x18 AppId                       ( 000186671910 ModelPrimitiveType string string string String )
            value.ApiKey                                    = GetString(new IntPtr(p + 0x020)); // 0270DB743270 0x20 ApiKey                      ( 000186671910 ModelPrimitiveType string string string String )
            value.MessageSenderId                           = GetString(new IntPtr(p + 0x028)); // 0270DB743290 0x28 MessageSenderId             ( 000186671910 ModelPrimitiveType string string string String )
            value.StorageBucket                             = GetString(new IntPtr(p + 0x030)); // 0270DB7432B0 0x30 StorageBucket               ( 000186671910 ModelPrimitiveType string string string String )
            value.ProjectId                                 = GetString(new IntPtr(p + 0x038)); // 0270DB7432D0 0x38 ProjectId                   ( 000186671910 ModelPrimitiveType string string string String )
            value.PackageName                               = GetString(new IntPtr(p + 0x040)); // 0270DB7432F0 0x40 PackageName                 ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
