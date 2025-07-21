using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 GroupList                                ModelClassListType List`1<ProduceTutorialEventGroup> List`1<ProduceTutorialEventGroup> List<ProduceTutorialEventGroup> Pointer
    // 018 Progress                                 ModelPrimitiveType int int int Int32
    // 020 CurrentGruup                             ModelClassType ProduceTutorialEventGroup ProduceTutorialEventGroup ProduceTutorialEventGroup Pointer
    // 028 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 OnEndSequence                            ModelClassType Action Action Action Pointer
    public partial class ProduceTutorialSequenceBase : DataModel
    {
        public List<ProduceTutorialEventGroup>?         GroupList                               { get; set; }
        public int                                      Progress                                { get; set; }
        public ProduceTutorialEventGroup?               CurrentGruup                            { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public Action?                                  OnEndSequence                           { get; set; }

        public static ProduceTutorialSequenceBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceTutorialSequenceBase() { Pointer= p0 };

            value.GroupList                                 = GetObjectList<ProduceTutorialEventGroup>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProduceTutorialEventGroup.FromPointer); // 0x10 GroupList                   ( ModelClassListType List`1<ProduceTutorialEventGroup> List`1<ProduceTutorialEventGroup> List<ProduceTutorialEventGroup> Pointer )
            value.Progress                                  = GetInt32(new IntPtr(p + 0x018)); // 0x18 Progress                    ( ModelPrimitiveType int int int Int32 )
            value.CurrentGruup                              = GetObject<ProduceTutorialEventGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceTutorialEventGroup.FromPointer); // 0x20 CurrentGruup                ( ModelClassType ProduceTutorialEventGroup ProduceTutorialEventGroup ProduceTutorialEventGroup Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x28 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.OnEndSequence                             = GetObject<Action>(new IntPtr(p + 0x030), ReversePrism.DataModels.Action.FromPointer); // 0x30 OnEndSequence               ( ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
