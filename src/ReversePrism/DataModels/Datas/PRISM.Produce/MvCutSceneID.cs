using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001866722E0 ModelPrimitiveType string string string String
    // 018 Timing                                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 CsType                                   0001866722E0 ModelPrimitiveType string string string String
    // 028 CharaId                                  0001865F36C0 ModelPrimitiveType int int int Int32
    // 030 BaseString                               000186671910 ModelPrimitiveType string string string String
    public partial class MvCutSceneID
    {
        public string                                   Id                                      { get; set; }
        public int                                      Timing                                  { get; set; }
        public string                                   CsType                                  { get; set; }
        public int                                      CharaId                                 { get; set; }
        public string                                   BaseString                              { get; set; }

        public static MvCutSceneID? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MvCutSceneID();

            value.Id                                        = GetString(new IntPtr(p + 0x010)); // 0270D5BEBC80 0x10 Id                          ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Timing                                    = GetInt32(new IntPtr(p + 0x018)); // 0270D5BEBCA0 0x18 Timing                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.CsType                                    = GetString(new IntPtr(p + 0x020)); // 0270D5BEBCC0 0x20 CsType                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.CharaId                                   = GetInt32(new IntPtr(p + 0x028)); // 0270D5BEBCE0 0x28 CharaId                     ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.BaseString                                = GetString(new IntPtr(p + 0x030)); // 0270D5BEBD00 0x30 BaseString                  ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
