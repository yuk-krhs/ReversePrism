using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     ModelClassType Type Type Type Pointer
    // 018 UpdateDelegate                           ModelClassType UpdateFunction UpdateFunction UpdateFunction Pointer
    // 020 updateFunction                           <int> IL2CPP_TYPE_I
    // 028 loopConditionFunction                    <int> IL2CPP_TYPE_I
    // 030 NumSubSystems                            ModelPrimitiveType int int int Int32
    public partial class PlayerLoopSystemInternal : DataModel
    {
        public Type?                                    Type                                    { get; set; }
        public UpdateFunction?                          UpdateDelegate                          { get; set; }
        public int                                      NumSubSystems                           { get; set; }

        public static PlayerLoopSystemInternal? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlayerLoopSystemInternal() { Pointer= p0 };

            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0x10 Type                        ( ModelClassType Type Type Type Pointer )
            value.UpdateDelegate                            = GetObject<UpdateFunction>(new IntPtr(p + 0x018), ReversePrism.DataModels.UpdateFunction.FromPointer); // 0x18 UpdateDelegate              ( ModelClassType UpdateFunction UpdateFunction UpdateFunction Pointer )
            value.NumSubSystems                             = GetInt32(new IntPtr(p + 0x030)); // 0x30 NumSubSystems               ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
