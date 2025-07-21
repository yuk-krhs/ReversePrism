using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 keyDiversifier                           sbyte[] IL2CPP_TYPE_SZARRAY
    // 008 ivDiversifier                            sbyte[] IL2CPP_TYPE_SZARRAY
    // 010 MacDiversifier                           ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 010 HashName                                 ModelPrimitiveType string string string String
    // 018 Iterations                               ModelPrimitiveType int int int Int32
    // 020 Password                                 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 028 Salt                                     ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class DeriveBytes : DataModel
    {
        public List<sbyte>?                             MacDiversifier                          { get; set; }
        public string                                   HashName                                { get; set; }
        public int                                      Iterations                              { get; set; }
        public List<sbyte>?                             Password                                { get; set; }
        public List<sbyte>?                             Salt                                    { get; set; }

        public static DeriveBytes? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DeriveBytes() { Pointer= p0 };

            value.MacDiversifier                            = GetSByteList(new IntPtr(p + 0x010)); // 0x10 MacDiversifier              ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.HashName                                  = GetString(new IntPtr(p + 0x010)); // 0x10 HashName                    ( ModelPrimitiveType string string string String )
            value.Iterations                                = GetInt32(new IntPtr(p + 0x018)); // 0x18 Iterations                  ( ModelPrimitiveType int int int Int32 )
            value.Password                                  = GetSByteList(new IntPtr(p + 0x020)); // 0x20 Password                    ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Salt                                      = GetSByteList(new IntPtr(p + 0x028)); // 0x28 Salt                        ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
