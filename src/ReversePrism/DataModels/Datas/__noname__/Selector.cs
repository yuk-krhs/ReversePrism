using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 usedCharacterIds                         HashSet`1<int> IL2CPP_TYPE_GENERICINST
    // 018 Candidates                               000185B90A40 ModelClassListType LiveIdol[] LiveIdol[] List<LiveIdol> Pointer
    // 020 Selected                                 000185B90A40 ModelClassListType LiveIdol[] LiveIdol[] List<LiveIdol> Pointer
    // 028 SelectedCount                            0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class Selector : DataModel
    {
        public List<LiveIdol>?                          Candidates                              { get; set; }
        public List<LiveIdol>?                          Selected                                { get; set; }
        public int                                      SelectedCount                           { get; set; }

        public static Selector? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Selector() { Pointer= p0 };

            value.Candidates                                = GetObjectList<LiveIdol>(new IntPtr(p + 0x018), ReversePrism.DataModels.LiveIdol.FromPointer); // 0246652F99A0 0x18 Candidates                  ( 000185B90A40 ModelClassListType LiveIdol[] LiveIdol[] List<LiveIdol> Pointer )
            value.Selected                                  = GetObjectList<LiveIdol>(new IntPtr(p + 0x020), ReversePrism.DataModels.LiveIdol.FromPointer); // 0246652F99C0 0x20 Selected                    ( 000185B90A40 ModelClassListType LiveIdol[] LiveIdol[] List<LiveIdol> Pointer )
            value.SelectedCount                             = GetInt32(new IntPtr(p + 0x028)); // 0246652F99E0 0x28 SelectedCount               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
