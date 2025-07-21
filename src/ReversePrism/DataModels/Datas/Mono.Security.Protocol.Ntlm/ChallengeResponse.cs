using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 magic                                    sbyte[] IL2CPP_TYPE_SZARRAY
    // 008 nullEncMagic                             sbyte[] IL2CPP_TYPE_SZARRAY
    // 010 Disposed                                 ModelPrimitiveType bool bool bool Bool
    // 018 Challenge                                ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 Lmpwd                                    ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 028 Ntpwd                                    ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class ChallengeResponse : DataModel
    {
        public bool                                     Disposed                                { get; set; }
        public List<sbyte>?                             Challenge                               { get; set; }
        public List<sbyte>?                             Lmpwd                                   { get; set; }
        public List<sbyte>?                             Ntpwd                                   { get; set; }

        public static ChallengeResponse? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeResponse() { Pointer= p0 };

            value.Disposed                                  = GetBool(new IntPtr(p + 0x010)); // 0x10 Disposed                    ( ModelPrimitiveType bool bool bool Bool )
            value.Challenge                                 = GetSByteList(new IntPtr(p + 0x018)); // 0x18 Challenge                   ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Lmpwd                                     = GetSByteList(new IntPtr(p + 0x020)); // 0x20 Lmpwd                       ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Ntpwd                                     = GetSByteList(new IntPtr(p + 0x028)); // 0x28 Ntpwd                       ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
