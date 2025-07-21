using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BeforeRate                               ModelPrimitiveType float float float Single
    // 014 AfterRate                                ModelPrimitiveType float float float Single
    // 018 IsAlreadyMaxLevel                        ModelPrimitiveType bool bool bool Bool
    // 01C MaxLevel                                 ModelPrimitiveType int int int Int32
    // 020 DiffExp                                  ModelPrimitiveType int int int Int32
    public partial class LiveResultIdolGaugeViewModel : DataModel
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
            var value   = new LiveResultIdolGaugeViewModel() { Pointer= p0 };

            value.BeforeRate                                = GetSingle(new IntPtr(p + 0x010)); // 0x10 BeforeRate                  ( ModelPrimitiveType float float float Single )
            value.AfterRate                                 = GetSingle(new IntPtr(p + 0x014)); // 0x14 AfterRate                   ( ModelPrimitiveType float float float Single )
            value.IsAlreadyMaxLevel                         = GetBool(new IntPtr(p + 0x018)); // 0x18 IsAlreadyMaxLevel           ( ModelPrimitiveType bool bool bool Bool )
            value.MaxLevel                                  = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MaxLevel                    ( ModelPrimitiveType int int int Int32 )
            value.DiffExp                                   = GetInt32(new IntPtr(p + 0x020)); // 0x20 DiffExp                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
