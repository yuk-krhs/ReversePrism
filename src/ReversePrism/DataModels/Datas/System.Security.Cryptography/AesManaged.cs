using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 048 M_rijndael                               00018668FB20 ModelClassType RijndaelManaged RijndaelManaged RijndaelManaged Pointer
    public partial class AesManaged
    {
        public RijndaelManaged?                         M_rijndael                              { get; set; }

        public static AesManaged? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AesManaged();

            value.M_rijndael                                = GetObject<RijndaelManaged>(new IntPtr(p + 0x048), ReversePrism.DataModels.RijndaelManaged.FromPointer); // 0270D9EB16A0 0x48 M_rijndael                  ( 00018668FB20 ModelClassType RijndaelManaged RijndaelManaged RijndaelManaged Pointer )

            return value;
        }
    }
}
