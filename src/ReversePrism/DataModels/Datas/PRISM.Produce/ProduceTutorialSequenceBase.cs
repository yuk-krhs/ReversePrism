using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 GroupList                                000185CFD2C8 ModelClassListType List`1<ProduceTutorialEventGroup> List`1<ProduceTutorialEventGroup> List<ProduceTutorialEventGroup> Pointer
    // 018 Progress                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 CurrentGruup                             00018658E4E0 ModelClassType ProduceTutorialEventGroup ProduceTutorialEventGroup ProduceTutorialEventGroup Pointer
    // 028 Cts                                      0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 OnEndSequence                            0001866792B0 ModelClassType Action Action Action Pointer
    public partial class ProduceTutorialSequenceBase
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
            var value   = new ProduceTutorialSequenceBase();

            value.GroupList                                 = GetObjectList<ProduceTutorialEventGroup>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProduceTutorialEventGroup.FromPointer); // 0270D5D504D0 0x10 GroupList                   ( 000185CFD2C8 ModelClassListType List`1<ProduceTutorialEventGroup> List`1<ProduceTutorialEventGroup> List<ProduceTutorialEventGroup> Pointer )
            value.Progress                                  = GetInt32(new IntPtr(p + 0x018)); // 0270D5D504F0 0x18 Progress                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentGruup                              = GetObject<ProduceTutorialEventGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceTutorialEventGroup.FromPointer); // 0270D5D50510 0x20 CurrentGruup                ( 00018658E4E0 ModelClassType ProduceTutorialEventGroup ProduceTutorialEventGroup ProduceTutorialEventGroup Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D5D50530 0x28 Cts                         ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.OnEndSequence                             = GetObject<Action>(new IntPtr(p + 0x030), ReversePrism.DataModels.Action.FromPointer); // 0270D5D50550 0x30 OnEndSequence               ( 0001866792B0 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
