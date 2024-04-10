using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CharacterNumList                         000185CECF28 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 018 NewLineWaitTimePerCharacter              000186666050 ModelPrimitiveType float float float Single
    public partial class CountCalculater : DataModel
    {
        public List<int>?                               CharacterNumList                        { get; set; }
        public float                                    NewLineWaitTimePerCharacter             { get; set; }

        public static CountCalculater? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CountCalculater() { Pointer= p0 };

            value.CharacterNumList                          = GetInt32List(new IntPtr(p + 0x010)); // 0245A6955B58 0x10 CharacterNumList            ( 000185CECF28 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.NewLineWaitTimePerCharacter               = GetSingle(new IntPtr(p + 0x018)); // 0245A6955B78 0x18 NewLineWaitTimePerCharacter ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
