using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 SortId                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 018 HelpType                                 0001865F4260 ModelPrimitiveType int int int Int32
    // 020 BeginDate                                0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 028 EndDate                                  0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    public partial class MstHelpGroup
    {
        public int                                      Id                                      { get; set; }
        public int                                      SortId                                  { get; set; }
        public int                                      HelpType                                { get; set; }
        public DateTime                                 BeginDate                               { get; set; }
        public DateTime                                 EndDate                                 { get; set; }

        public static MstHelpGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstHelpGroup();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0270045A8C30 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x014)); // 0270045A8C50 0x14 SortId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.HelpType                                  = GetInt32(new IntPtr(p + 0x018)); // 0270045A8C70 0x18 HelpType                    ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x020)); // 0270045A8C90 0x20 BeginDate                   ( 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x028)); // 0270045A8CB0 0x28 EndDate                     ( 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
