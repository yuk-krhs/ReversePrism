using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_BlockData                              0001866CD820 ModelEnumType Block Block Block Int32
    // 030 m_CurrentBlock                           IntPtr IL2CPP_TYPE_PTR
    // 038 m_CurrentPtr                             IntPtr IL2CPP_TYPE_PTR
    // 040 m_CurrentBlockEnd                        IntPtr IL2CPP_TYPE_PTR
    // 048 M_ForeachIndex                           0001865F2F90 ModelPrimitiveType int int int Int32
    // 04C M_ElementCount                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 050 m_FirstBlock                             IntPtr IL2CPP_TYPE_PTR
    // 058 M_FirstOffset                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 05C M_NumberOfBlocks                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 060 M_ThreadIndex                            0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class Writer : DataModel
    {
        public Block                                    M_BlockData                             { get; set; }
        public int                                      M_ForeachIndex                          { get; set; }
        public int                                      M_ElementCount                          { get; set; }
        public int                                      M_FirstOffset                           { get; set; }
        public int                                      M_NumberOfBlocks                        { get; set; }
        public int                                      M_ThreadIndex                           { get; set; }

        public static Writer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Writer() { Pointer= p0 };

            value.M_BlockData                               = (Block)GetInt32(new IntPtr(p + 0x010)); // 024669CB0158 0x10 M_BlockData                 ( 0001866CD820 ModelEnumType Block Block Block Int32 )
            value.M_ForeachIndex                            = GetInt32(new IntPtr(p + 0x048)); // 024669CB01D8 0x48 M_ForeachIndex              ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_ElementCount                            = GetInt32(new IntPtr(p + 0x04C)); // 024669CB01F8 0x4C M_ElementCount              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_FirstOffset                             = GetInt32(new IntPtr(p + 0x058)); // 024669CB0238 0x58 M_FirstOffset               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_NumberOfBlocks                          = GetInt32(new IntPtr(p + 0x05C)); // 024669CB0258 0x5C M_NumberOfBlocks            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_ThreadIndex                             = GetInt32(new IntPtr(p + 0x060)); // 024669CB0278 0x60 M_ThreadIndex               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
