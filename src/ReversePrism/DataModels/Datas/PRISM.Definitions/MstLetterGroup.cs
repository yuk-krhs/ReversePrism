using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 018 Name                                     000186672F10 ModelPrimitiveType string string string String
    public partial class MstLetterGroup : DataModel
    {
        public int                                      Id                                      { get; set; }
        public string                                   Name                                    { get; set; }

        public static MstLetterGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstLetterGroup() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0245A46E18D0 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0245A46E18F0 0x18 Name                        ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
