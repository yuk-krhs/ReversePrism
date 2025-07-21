using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BackgroundType                           ModelPrimitiveType int int int Int32
    // 018 BackgroundKey                            ModelPrimitiveType string string string String
    // 020 BgmCueSheetName                          ModelPrimitiveType string string string String
    // 028 BgmCueName                               ModelPrimitiveType string string string String
    // 030 TitleCallCueSheetName                    ModelPrimitiveType string string string String
    // 038 TitleCallCueName                         ModelPrimitiveType string string string String
    // 040 BeginDate                                ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 048 EndDate                                  ModelPrimitiveType DateTime DateTime DateTime DateTime
    public partial class MstTitleBackground : DataModel
    {
        public int                                      BackgroundType                          { get; set; }
        public string                                   BackgroundKey                           { get; set; }
        public string                                   BgmCueSheetName                         { get; set; }
        public string                                   BgmCueName                              { get; set; }
        public string                                   TitleCallCueSheetName                   { get; set; }
        public string                                   TitleCallCueName                        { get; set; }
        public DateTime                                 BeginDate                               { get; set; }
        public DateTime                                 EndDate                                 { get; set; }

        public static MstTitleBackground? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstTitleBackground() { Pointer= p0 };

            value.BackgroundType                            = GetInt32(new IntPtr(p + 0x010)); // 0x10 BackgroundType              ( ModelPrimitiveType int int int Int32 )
            value.BackgroundKey                             = GetString(new IntPtr(p + 0x018)); // 0x18 BackgroundKey               ( ModelPrimitiveType string string string String )
            value.BgmCueSheetName                           = GetString(new IntPtr(p + 0x020)); // 0x20 BgmCueSheetName             ( ModelPrimitiveType string string string String )
            value.BgmCueName                                = GetString(new IntPtr(p + 0x028)); // 0x28 BgmCueName                  ( ModelPrimitiveType string string string String )
            value.TitleCallCueSheetName                     = GetString(new IntPtr(p + 0x030)); // 0x30 TitleCallCueSheetName       ( ModelPrimitiveType string string string String )
            value.TitleCallCueName                          = GetString(new IntPtr(p + 0x038)); // 0x38 TitleCallCueName            ( ModelPrimitiveType string string string String )
            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x040)); // 0x40 BeginDate                   ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x048)); // 0x48 EndDate                     ( ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
