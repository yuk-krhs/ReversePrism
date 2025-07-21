using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DatabaseUrl                              ModelClassType Uri Uri Uri Pointer
    // 018 AppId                                    ModelPrimitiveType string string string String
    // 020 ApiKey                                   ModelPrimitiveType string string string String
    // 028 MessageSenderId                          ModelPrimitiveType string string string String
    // 030 StorageBucket                            ModelPrimitiveType string string string String
    // 038 ProjectId                                ModelPrimitiveType string string string String
    // 040 PackageName                              ModelPrimitiveType string string string String
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

            value.DatabaseUrl                               = GetObject<Uri>(new IntPtr(p + 0x010), ReversePrism.DataModels.Uri.FromPointer); // 0x10 DatabaseUrl                 ( ModelClassType Uri Uri Uri Pointer )
            value.AppId                                     = GetString(new IntPtr(p + 0x018)); // 0x18 AppId                       ( ModelPrimitiveType string string string String )
            value.ApiKey                                    = GetString(new IntPtr(p + 0x020)); // 0x20 ApiKey                      ( ModelPrimitiveType string string string String )
            value.MessageSenderId                           = GetString(new IntPtr(p + 0x028)); // 0x28 MessageSenderId             ( ModelPrimitiveType string string string String )
            value.StorageBucket                             = GetString(new IntPtr(p + 0x030)); // 0x30 StorageBucket               ( ModelPrimitiveType string string string String )
            value.ProjectId                                 = GetString(new IntPtr(p + 0x038)); // 0x38 ProjectId                   ( ModelPrimitiveType string string string String )
            value.PackageName                               = GetString(new IntPtr(p + 0x040)); // 0x40 PackageName                 ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
