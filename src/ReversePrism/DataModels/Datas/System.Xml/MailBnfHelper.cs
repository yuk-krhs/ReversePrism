using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_fqtext                                 bool[] IL2CPP_TYPE_SZARRAY
    // 008 s_ttext                                  bool[] IL2CPP_TYPE_SZARRAY
    // 010 S_digits                                 ModelPrimitiveListType bool[] bool[] List<bool> Pointer
    // 018 S_boundary                               ModelPrimitiveListType bool[] bool[] List<bool> Pointer
    public partial class MailBnfHelper : DataModel
    {
        public List<bool>?                              S_digits                                { get; set; }
        public List<bool>?                              S_boundary                              { get; set; }

        public static MailBnfHelper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MailBnfHelper() { Pointer= p0 };

            value.S_digits                                  = GetBoolList(new IntPtr(p + 0x010)); // 0x10 S_digits                    ( ModelPrimitiveListType bool[] bool[] List<bool> Pointer )
            value.S_boundary                                = GetBoolList(new IntPtr(p + 0x018)); // 0x18 S_boundary                  ( ModelPrimitiveListType bool[] bool[] List<bool> Pointer )

            return value;
        }
    }
}
