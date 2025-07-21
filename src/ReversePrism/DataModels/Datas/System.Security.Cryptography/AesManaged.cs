using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 048 M_rijndael                               ModelClassType RijndaelManaged RijndaelManaged RijndaelManaged Pointer
    public partial class AesManaged : DataModel
    {
        public RijndaelManaged?                         M_rijndael                              { get; set; }

        public static AesManaged? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AesManaged() { Pointer= p0 };

            value.M_rijndael                                = GetObject<RijndaelManaged>(new IntPtr(p + 0x048), ReversePrism.DataModels.RijndaelManaged.FromPointer); // 0x48 M_rijndael                  ( ModelClassType RijndaelManaged RijndaelManaged RijndaelManaged Pointer )

            return value;
        }
    }
}
