using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_FullTypeName                           000186671910 ModelPrimitiveType string string string String
    // 018 M_Id                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C M_OrderInDocument                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 M_ParentId                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 M_Properties                             000185D0D618 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    public partial class UxmlAsset
    {
        public string                                   M_FullTypeName                          { get; set; }
        public int                                      M_Id                                    { get; set; }
        public int                                      M_OrderInDocument                       { get; set; }
        public int                                      M_ParentId                              { get; set; }
        public List<string>?                            M_Properties                            { get; set; }

        public static UxmlAsset? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UxmlAsset();

            value.M_FullTypeName                            = GetString(new IntPtr(p + 0x010)); // 02700684E648 0x10 M_FullTypeName              ( 000186671910 ModelPrimitiveType string string string String )
            value.M_Id                                      = GetInt32(new IntPtr(p + 0x018)); // 02700684E668 0x18 M_Id                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_OrderInDocument                         = GetInt32(new IntPtr(p + 0x01C)); // 02700684E688 0x1C M_OrderInDocument           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_ParentId                                = GetInt32(new IntPtr(p + 0x020)); // 02700684E6A8 0x20 M_ParentId                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_Properties                              = GetStringList(new IntPtr(p + 0x028)); // 02700684E6C8 0x28 M_Properties                ( 000185D0D618 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )

            return value;
        }
    }
}
