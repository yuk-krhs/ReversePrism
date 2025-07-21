using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Name                                     ModelPrimitiveType string string string String
    // 020 Info                                     ModelPrimitiveType int int int Int32
    // 024 ArgumentCount                            ModelPrimitiveType int int int Int32
    // 028 Arguments                                ModelClassListType ExpressionNode[] ExpressionNode[] List<ExpressionNode> Pointer
    // 030 CapturedLimiter                          ModelClassType TypeLimiter TypeLimiter TypeLimiter Pointer
    // 000 s_funcs                                  Function[] IL2CPP_TYPE_SZARRAY
    public partial class FunctionNode : DataModel
    {
        public string                                   Name                                    { get; set; }
        public int                                      Info                                    { get; set; }
        public int                                      ArgumentCount                           { get; set; }
        public List<ExpressionNode>?                    Arguments                               { get; set; }
        public TypeLimiter?                             CapturedLimiter                         { get; set; }

        public static FunctionNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FunctionNode() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Name                        ( ModelPrimitiveType string string string String )
            value.Info                                      = GetInt32(new IntPtr(p + 0x020)); // 0x20 Info                        ( ModelPrimitiveType int int int Int32 )
            value.ArgumentCount                             = GetInt32(new IntPtr(p + 0x024)); // 0x24 ArgumentCount               ( ModelPrimitiveType int int int Int32 )
            value.Arguments                                 = GetObjectList<ExpressionNode>(new IntPtr(p + 0x028), ReversePrism.DataModels.ExpressionNode.FromPointer); // 0x28 Arguments                   ( ModelClassListType ExpressionNode[] ExpressionNode[] List<ExpressionNode> Pointer )
            value.CapturedLimiter                           = GetObject<TypeLimiter>(new IntPtr(p + 0x030), ReversePrism.DataModels.TypeLimiter.FromPointer); // 0x30 CapturedLimiter             ( ModelClassType TypeLimiter TypeLimiter TypeLimiter Pointer )

            return value;
        }
    }
}
