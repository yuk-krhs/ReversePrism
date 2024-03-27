using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BeforeRate                               000186666F40 ModelPrimitiveType float float float Single
    // 014 AfterRate                                000186666F40 ModelPrimitiveType float float float Single
    // 018 IsAlreadyMaxLevel                        000186596AF0 ModelPrimitiveType bool bool bool Bool
    // 01C MaxLevel                                 0001865F4940 ModelPrimitiveType int int int Int32
    // 020 DiffExp                                  0001865F4940 ModelPrimitiveType int int int Int32
    public partial class LiveResultIdolGaugeViewModel
    {
        public float                                    BeforeRate                              { get; set; }
        public float                                    AfterRate                               { get; set; }
        public bool                                     IsAlreadyMaxLevel                       { get; set; }
        public int                                      MaxLevel                                { get; set; }
        public int                                      DiffExp                                 { get; set; }

        public static LiveResultIdolGaugeViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveResultIdolGaugeViewModel();

            value.BeforeRate                                = GetSingle(new IntPtr(p + 0x010)); // 0270D5238010 0x10 BeforeRate                  ( 000186666F40 ModelPrimitiveType float float float Single )
            value.AfterRate                                 = GetSingle(new IntPtr(p + 0x014)); // 0270D5238030 0x14 AfterRate                   ( 000186666F40 ModelPrimitiveType float float float Single )
            value.IsAlreadyMaxLevel                         = GetBool(new IntPtr(p + 0x018)); // 0270D5238050 0x18 IsAlreadyMaxLevel           ( 000186596AF0 ModelPrimitiveType bool bool bool Bool )
            value.MaxLevel                                  = GetInt32(new IntPtr(p + 0x01C)); // 0270D5238070 0x1C MaxLevel                    ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.DiffExp                                   = GetInt32(new IntPtr(p + 0x020)); // 0270D5238090 0x20 DiffExp                     ( 0001865F4940 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
