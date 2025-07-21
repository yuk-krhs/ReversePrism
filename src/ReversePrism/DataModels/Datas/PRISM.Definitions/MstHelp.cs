using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 SortId                                   ModelPrimitiveType int int int Int32
    // 018 MstHelpGroupId                           ModelPrimitiveType int int int Int32
    // 01C IsMobile                                 ModelPrimitiveType bool bool bool Bool
    // 01D IsGpg                                    ModelPrimitiveType bool bool bool Bool
    // 01E IsDmm                                    ModelPrimitiveType bool bool bool Bool
    // 020 BeginDate                                ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 028 EndDate                                  ModelPrimitiveType DateTime DateTime DateTime DateTime
    public partial class MstHelp : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      SortId                                  { get; set; }
        public int                                      MstHelpGroupId                          { get; set; }
        public bool                                     IsMobile                                { get; set; }
        public bool                                     IsGpg                                   { get; set; }
        public bool                                     IsDmm                                   { get; set; }
        public DateTime                                 BeginDate                               { get; set; }
        public DateTime                                 EndDate                                 { get; set; }

        public static MstHelp? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstHelp() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x014)); // 0x14 SortId                      ( ModelPrimitiveType int int int Int32 )
            value.MstHelpGroupId                            = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstHelpGroupId              ( ModelPrimitiveType int int int Int32 )
            value.IsMobile                                  = GetBool(new IntPtr(p + 0x01C)); // 0x1C IsMobile                    ( ModelPrimitiveType bool bool bool Bool )
            value.IsGpg                                     = GetBool(new IntPtr(p + 0x01D)); // 0x1D IsGpg                       ( ModelPrimitiveType bool bool bool Bool )
            value.IsDmm                                     = GetBool(new IntPtr(p + 0x01E)); // 0x1E IsDmm                       ( ModelPrimitiveType bool bool bool Bool )
            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x020)); // 0x20 BeginDate                   ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x028)); // 0x28 EndDate                     ( ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
