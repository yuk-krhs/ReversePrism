using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Count                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 Hash                                     0001865F7E40 ModelPrimitiveType long long long Int64
    // 020 Index                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 CombineInstances                         000185CD3AD8 ModelEnumListType List`1<CombineInstance> List`1<CombineInstance> List<CombineInstance> Pointer
    // 030 Mesh                                     0001866109A0 ModelClassType Mesh Mesh Mesh Pointer
    // 038 Transform                                00018660DFD0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    public partial class CombineInstanceEx
    {
        public int                                      Count                                   { get; set; }
        public long                                     Hash                                    { get; set; }
        public int                                      Index                                   { get; set; }
        public List<CombineInstance>?                   CombineInstances                        { get; set; }
        public Mesh?                                    Mesh                                    { get; set; }
        public Matrix4x4                                Transform                               { get; set; }

        public static CombineInstanceEx? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CombineInstanceEx();

            value.Count                                     = GetInt32(new IntPtr(p + 0x010)); // 027003C5CC58 0x10 Count                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Hash                                      = GetInt64(new IntPtr(p + 0x018)); // 027003C5CC78 0x18 Hash                        ( 0001865F7E40 ModelPrimitiveType long long long Int64 )
            value.Index                                     = GetInt32(new IntPtr(p + 0x020)); // 027003C5CC98 0x20 Index                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.CombineInstances                          = GetEnumList<CombineInstance>(new IntPtr(p + 0x028)); // 027003C5CCB8 0x28 CombineInstances            ( 000185CD3AD8 ModelEnumListType List`1<CombineInstance> List`1<CombineInstance> List<CombineInstance> Pointer )
            value.Mesh                                      = GetObject<Mesh>(new IntPtr(p + 0x030), ReversePrism.DataModels.Mesh.FromPointer); // 027003C5CCD8 0x30 Mesh                        ( 0001866109A0 ModelClassType Mesh Mesh Mesh Pointer )
            value.Transform                                 = (Matrix4x4)GetInt32(new IntPtr(p + 0x038)); // 027003C5CCF8 0x38 Transform                   ( 00018660DFD0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )

            return value;
        }
    }
}
