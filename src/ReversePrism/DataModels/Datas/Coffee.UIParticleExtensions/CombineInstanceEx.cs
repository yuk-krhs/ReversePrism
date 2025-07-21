using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Count                                    ModelPrimitiveType int int int Int32
    // 018 Hash                                     ModelPrimitiveType long long long Int64
    // 020 Index                                    ModelPrimitiveType int int int Int32
    // 028 CombineInstances                         ModelEnumListType List`1<CombineInstance> List`1<CombineInstance> List<CombineInstance> Pointer
    // 030 Mesh                                     ModelClassType Mesh Mesh Mesh Pointer
    // 038 Transform                                ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    public partial class CombineInstanceEx : DataModel
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
            var value   = new CombineInstanceEx() { Pointer= p0 };

            value.Count                                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 Count                       ( ModelPrimitiveType int int int Int32 )
            value.Hash                                      = GetInt64(new IntPtr(p + 0x018)); // 0x18 Hash                        ( ModelPrimitiveType long long long Int64 )
            value.Index                                     = GetInt32(new IntPtr(p + 0x020)); // 0x20 Index                       ( ModelPrimitiveType int int int Int32 )
            value.CombineInstances                          = GetEnumList<CombineInstance>(new IntPtr(p + 0x028)); // 0x28 CombineInstances            ( ModelEnumListType List`1<CombineInstance> List`1<CombineInstance> List<CombineInstance> Pointer )
            value.Mesh                                      = GetObject<Mesh>(new IntPtr(p + 0x030), ReversePrism.DataModels.Mesh.FromPointer); // 0x30 Mesh                        ( ModelClassType Mesh Mesh Mesh Pointer )
            value.Transform                                 = (Matrix4x4)GetInt32(new IntPtr(p + 0x038)); // 0x38 Transform                   ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )

            return value;
        }
    }
}
