using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstId                                    ModelPrimitiveType int int int Int32
    // 018 MessageText                              ModelPrimitiveType string string string String
    // 020 CueName                                  ModelPrimitiveType string string string String
    // 028 CueSheetName                             ModelPrimitiveType string string string String
    // 030 IsLeaveAction                            ModelPrimitiveType bool bool bool Bool
    public partial class HomeCharacterActionViewModel : DataModel
    {
        public int                                      MstId                                   { get; set; }
        public string                                   MessageText                             { get; set; }
        public string                                   CueName                                 { get; set; }
        public string                                   CueSheetName                            { get; set; }
        public bool                                     IsLeaveAction                           { get; set; }

        public static HomeCharacterActionViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeCharacterActionViewModel() { Pointer= p0 };

            value.MstId                                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 MstId                       ( ModelPrimitiveType int int int Int32 )
            value.MessageText                               = GetString(new IntPtr(p + 0x018)); // 0x18 MessageText                 ( ModelPrimitiveType string string string String )
            value.CueName                                   = GetString(new IntPtr(p + 0x020)); // 0x20 CueName                     ( ModelPrimitiveType string string string String )
            value.CueSheetName                              = GetString(new IntPtr(p + 0x028)); // 0x28 CueSheetName                ( ModelPrimitiveType string string string String )
            value.IsLeaveAction                             = GetBool(new IntPtr(p + 0x030)); // 0x30 IsLeaveAction               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
