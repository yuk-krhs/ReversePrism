using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType string string string String
    // 018 Timing                                   ModelPrimitiveType int int int Int32
    // 020 CsType                                   ModelPrimitiveType string string string String
    // 028 CharaId                                  ModelPrimitiveType int int int Int32
    // 030 BaseString                               ModelPrimitiveType string string string String
    public partial class MvCutSceneID : DataModel
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
            var value   = new MvCutSceneID() { Pointer= p0 };

            value.Id                                        = GetString(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType string string string String )
            value.Timing                                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 Timing                      ( ModelPrimitiveType int int int Int32 )
            value.CsType                                    = GetString(new IntPtr(p + 0x020)); // 0x20 CsType                      ( ModelPrimitiveType string string string String )
            value.CharaId                                   = GetInt32(new IntPtr(p + 0x028)); // 0x28 CharaId                     ( ModelPrimitiveType int int int Int32 )
            value.BaseString                                = GetString(new IntPtr(p + 0x030)); // 0x30 BaseString                  ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
