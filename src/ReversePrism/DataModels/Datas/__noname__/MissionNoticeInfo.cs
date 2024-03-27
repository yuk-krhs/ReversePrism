using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 Type                                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 CategoryId                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C AddMore                                  0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class MissionNoticeInfo
    {
        public int                                      Id                                      { get; set; }
        public int                                      Type                                    { get; set; }
        public int                                      CategoryId                              { get; set; }
        public int                                      AddMore                                 { get; set; }

        public static MissionNoticeInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionNoticeInfo();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0270D0A82BF8 0x10 Id                          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Type                                      = GetInt32(new IntPtr(p + 0x014)); // 0270D0A82C18 0x14 Type                        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.CategoryId                                = GetInt32(new IntPtr(p + 0x018)); // 0270D0A82C38 0x18 CategoryId                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.AddMore                                   = GetInt32(new IntPtr(p + 0x01C)); // 0270D0A82C58 0x1C AddMore                     ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
