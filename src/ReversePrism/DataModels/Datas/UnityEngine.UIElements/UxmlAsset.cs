using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_FullTypeName                           ModelPrimitiveType string string string String
    // 018 M_Id                                     ModelPrimitiveType int int int Int32
    // 01C M_OrderInDocument                        ModelPrimitiveType int int int Int32
    // 020 M_ParentId                               ModelPrimitiveType int int int Int32
    // 028 M_Properties                             ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    public partial class UxmlAsset : DataModel
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
            var value   = new UxmlAsset() { Pointer= p0 };

            value.M_FullTypeName                            = GetString(new IntPtr(p + 0x010)); // 0x10 M_FullTypeName              ( ModelPrimitiveType string string string String )
            value.M_Id                                      = GetInt32(new IntPtr(p + 0x018)); // 0x18 M_Id                        ( ModelPrimitiveType int int int Int32 )
            value.M_OrderInDocument                         = GetInt32(new IntPtr(p + 0x01C)); // 0x1C M_OrderInDocument           ( ModelPrimitiveType int int int Int32 )
            value.M_ParentId                                = GetInt32(new IntPtr(p + 0x020)); // 0x20 M_ParentId                  ( ModelPrimitiveType int int int Int32 )
            value.M_Properties                              = GetStringList(new IntPtr(p + 0x028)); // 0x28 M_Properties                ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )

            return value;
        }
    }
}
