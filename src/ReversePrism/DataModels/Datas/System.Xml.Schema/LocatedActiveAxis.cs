using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Column                                   ModelPrimitiveType int int int Int32
    // 02C IsMatched                                ModelPrimitiveType bool bool bool Bool
    // 030 Ks                                       ModelClassType KeySequence KeySequence KeySequence Pointer
    public partial class LocatedActiveAxis : DataModel
    {
        public int                                      Column                                  { get; set; }
        public bool                                     IsMatched                               { get; set; }
        public KeySequence?                             Ks                                      { get; set; }

        public static LocatedActiveAxis? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LocatedActiveAxis() { Pointer= p0 };

            value.Column                                    = GetInt32(new IntPtr(p + 0x028)); // 0x28 Column                      ( ModelPrimitiveType int int int Int32 )
            value.IsMatched                                 = GetBool(new IntPtr(p + 0x02C)); // 0x2C IsMatched                   ( ModelPrimitiveType bool bool bool Bool )
            value.Ks                                        = GetObject<KeySequence>(new IntPtr(p + 0x030), ReversePrism.DataModels.KeySequence.FromPointer); // 0x30 Ks                          ( ModelClassType KeySequence KeySequence KeySequence Pointer )

            return value;
        }
    }
}
