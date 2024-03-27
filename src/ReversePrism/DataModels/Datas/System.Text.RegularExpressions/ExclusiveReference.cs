using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Ref                                      0001866406D0 ModelClassType RegexRunner RegexRunner RegexRunner Pointer
    // 018 Obj                                      0001866406D0 ModelClassType RegexRunner RegexRunner RegexRunner Pointer
    // 020 Locked                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ExclusiveReference
    {
        public RegexRunner?                             Ref                                     { get; set; }
        public RegexRunner?                             Obj                                     { get; set; }
        public int                                      Locked                                  { get; set; }

        public static ExclusiveReference? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExclusiveReference();

            value.Ref                                       = GetObject<RegexRunner>(new IntPtr(p + 0x010), ReversePrism.DataModels.RegexRunner.FromPointer); // 027003493900 0x10 Ref                         ( 0001866406D0 ModelClassType RegexRunner RegexRunner RegexRunner Pointer )
            value.Obj                                       = GetObject<RegexRunner>(new IntPtr(p + 0x018), ReversePrism.DataModels.RegexRunner.FromPointer); // 027003493920 0x18 Obj                         ( 0001866406D0 ModelClassType RegexRunner RegexRunner RegexRunner Pointer )
            value.Locked                                    = GetInt32(new IntPtr(p + 0x020)); // 027003493940 0x20 Locked                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
