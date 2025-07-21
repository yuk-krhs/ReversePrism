using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     ModelClassType Type Type Type Pointer
    // 018 SubSystemList                            ModelEnumListType PlayerLoopSystem[] PlayerLoopSystem[] List<PlayerLoopSystem> Pointer
    // 020 UpdateDelegate                           ModelClassType UpdateFunction UpdateFunction UpdateFunction Pointer
    // 028 updateFunction                           <int> IL2CPP_TYPE_I
    // 030 loopConditionFunction                    <int> IL2CPP_TYPE_I
    public partial class PlayerLoopSystem : DataModel
    {
        public Type?                                    Type                                    { get; set; }
        public List<PlayerLoopSystem>?                  SubSystemList                           { get; set; }
        public UpdateFunction?                          UpdateDelegate                          { get; set; }

        public static PlayerLoopSystem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlayerLoopSystem() { Pointer= p0 };

            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0x10 Type                        ( ModelClassType Type Type Type Pointer )
            value.SubSystemList                             = GetEnumList<PlayerLoopSystem>(new IntPtr(p + 0x018)); // 0x18 SubSystemList               ( ModelEnumListType PlayerLoopSystem[] PlayerLoopSystem[] List<PlayerLoopSystem> Pointer )
            value.UpdateDelegate                            = GetObject<UpdateFunction>(new IntPtr(p + 0x020), ReversePrism.DataModels.UpdateFunction.FromPointer); // 0x20 UpdateDelegate              ( ModelClassType UpdateFunction UpdateFunction UpdateFunction Pointer )

            return value;
        }
    }
}
