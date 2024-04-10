using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Length                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 Disposed                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 Data                                     000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class SecureString : DataModel
    {
        public int                                      Length                                  { get; set; }
        public bool                                     Disposed                                { get; set; }
        public List<sbyte>?                             Data                                    { get; set; }

        public static SecureString? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SecureString() { Pointer= p0 };

            value.Length                                    = GetInt32(new IntPtr(p + 0x010)); // 024666BE16D0 0x10 Length                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x014)); // 024666BE16F0 0x14 Disposed                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Data                                      = GetSByteList(new IntPtr(p + 0x018)); // 024666BE1710 0x18 Data                        ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
