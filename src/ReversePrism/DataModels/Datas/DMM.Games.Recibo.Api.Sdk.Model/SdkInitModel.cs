using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ApplicationId                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 GamesId                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 GamesIdSignature                         000186671910 ModelPrimitiveType string string string String
    // 020 ViewerId                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 ViewerIdSignature                        000186671910 ModelPrimitiveType string string string String
    // 030 PointChargeUrl                           000186671910 ModelPrimitiveType string string string String
    // 038 IsAdult                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class SdkInitModel : DataModel
    {
        public int                                      ApplicationId                           { get; set; }
        public int                                      GamesId                                 { get; set; }
        public string                                   GamesIdSignature                        { get; set; }
        public int                                      ViewerId                                { get; set; }
        public string                                   ViewerIdSignature                       { get; set; }
        public string                                   PointChargeUrl                          { get; set; }
        public bool                                     IsAdult                                 { get; set; }

        public static SdkInitModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SdkInitModel() { Pointer= p0 };

            value.ApplicationId                             = GetInt32(new IntPtr(p + 0x010)); // 0245A4BECDC8 0x10 ApplicationId               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.GamesId                                   = GetInt32(new IntPtr(p + 0x014)); // 0245A4BECDE8 0x14 GamesId                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.GamesIdSignature                          = GetString(new IntPtr(p + 0x018)); // 0245A4BECE08 0x18 GamesIdSignature            ( 000186671910 ModelPrimitiveType string string string String )
            value.ViewerId                                  = GetInt32(new IntPtr(p + 0x020)); // 0245A4BECE28 0x20 ViewerId                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ViewerIdSignature                         = GetString(new IntPtr(p + 0x028)); // 0245A4BECE48 0x28 ViewerIdSignature           ( 000186671910 ModelPrimitiveType string string string String )
            value.PointChargeUrl                            = GetString(new IntPtr(p + 0x030)); // 0245A4BECE68 0x30 PointChargeUrl              ( 000186671910 ModelPrimitiveType string string string String )
            value.IsAdult                                   = GetBool(new IntPtr(p + 0x038)); // 0245A4BECE88 0x38 IsAdult                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
