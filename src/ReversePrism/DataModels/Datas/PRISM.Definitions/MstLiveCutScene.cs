using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 MstSongId                                ModelPrimitiveType int int int Int32
    // 018 CutSceneName                             ModelPrimitiveType string string string String
    // 020 ConditionType                            ModelPrimitiveType int int int Int32
    public partial class MstLiveCutScene : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstSongId                               { get; set; }
        public string                                   CutSceneName                            { get; set; }
        public int                                      ConditionType                           { get; set; }

        public static MstLiveCutScene? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstLiveCutScene() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.MstSongId                                 = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstSongId                   ( ModelPrimitiveType int int int Int32 )
            value.CutSceneName                              = GetString(new IntPtr(p + 0x018)); // 0x18 CutSceneName                ( ModelPrimitiveType string string string String )
            value.ConditionType                             = GetInt32(new IntPtr(p + 0x020)); // 0x20 ConditionType               ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
